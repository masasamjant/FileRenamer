using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace Masasamjant.FileRenameManager
{
    public enum FileRenameSortOrder
    {
        Ascending,
        Descending
    }

    public enum FileRenameSort
    {
        FileName,
        FileDirectory
    }

    public class FileRenameManager
    {
        /// <summary>
        /// Notifies when renaming file begin.
        /// </summary>
        public event EventHandler<FileRenameEventArgs> Renaming;

        /// <summary>
        /// Notifies when renaming file complete.
        /// </summary>
        public event EventHandler<FileRenameEventArgs> Renamed;

        /// <summary>
        /// Notifies when error in file renaming.
        /// </summary>
        public event EventHandler<FileRenameEventArgs> Error;

        /// <summary>
        /// Notifies when renaming is canceled.
        /// </summary>
        public event EventHandler Canceled;

        /// <summary>
        /// Notifies when renaming is completed.
        /// </summary>
        public event EventHandler Completed;

        /// <summary>
        /// Notifies when undo file renaming begin.
        /// </summary>
        public event EventHandler<FileRenameEventArgs> Undoing;

        /// <summary>
        /// Notifies when undo file renaming complete.
        /// </summary>
        public event EventHandler<FileRenameEventArgs> Undone;

        private long canceledFlag = FlagDisabled;
        private long renamingFlag = FlagDisabled;

        private const long FlagEnabled = 1L;
        private const long FlagDisabled = 0L;
        private const string NameOfUndoThread = "FRM_UNDO_THREAD";
        private const string NameOfRenameThread = "FRM_PERF_THREAD";

        public FileRenameManager()
        {
            Settings = new FileRenameSettings();
            Items = new List<FileRenameItem>();
            History = new List<FileRenameItem>();
        }

        public FileRenameSettings Settings { get; }

        private List<FileRenameItem> Items { get; }

        private List<FileRenameItem> History { get; }

        public FileRenameSortOrder SortOrder { get; set; } = FileRenameSortOrder.Ascending;

        public FileRenameSort Sort { get; set; } = FileRenameSort.FileName;

        private bool IsRenaming
        {
            get { return Interlocked.Read(ref renamingFlag) == FlagEnabled; }
        }

        public void AddItem(string sourceFilePath)
        {
            if (!ContainsSource(sourceFilePath))
            {
                FileRenameLogProvider.Current.Log.Write($"Add source file {sourceFilePath}.");

                FileRenameItem item = new FileRenameItem()
                {
                    SourceFilePath = sourceFilePath,
                    DestinationFilePath = string.Empty
                };

                Items.Add(item);
                ResolveDestinations();
            }
        }

        public void AddItems(IEnumerable<string> sourceFilePaths)
        {
            bool itemsAdded = false;

            foreach (string sourceFilePath in sourceFilePaths)
            {
                if (string.IsNullOrWhiteSpace(sourceFilePath) || ContainsSource(sourceFilePath))
                    continue;

                FileRenameLogProvider.Current.Log.Write($"Add source file {sourceFilePath}.");

                FileRenameItem item = new FileRenameItem()
                {
                    SourceFilePath = sourceFilePath,
                    DestinationFilePath = string.Empty
                };

                Items.Add(item);
                itemsAdded = true;
            }

            if (itemsAdded)
            {
                ResolveDestinations();
            }
        }

        public void RemoveItem(string sourceFilePath)
        {
            FileRenameItem item = Items.FirstOrDefault(x => x.SourceFilePath == sourceFilePath);

            if (item != null)
            {
                FileRenameLogProvider.Current.Log.Write($"Remove source file {sourceFilePath}.");

                Items.Remove(item);
                ResolveDestinations();
            }
        }

        public void RemoveItems(IEnumerable<string> sourceFilePaths)
        {
            bool itemsRemoved = false;

            foreach (string sourceFilePath in sourceFilePaths)
            {
                if (string.IsNullOrWhiteSpace(sourceFilePath)) continue;

                FileRenameItem item = Items.FirstOrDefault(x => x.SourceFilePath == sourceFilePath);

                if (item != null)
                {
                    FileRenameLogProvider.Current.Log.Write($"Remove source file {sourceFilePath}.");

                    Items.Remove(item);
                    itemsRemoved = true;
                }
            }

            if (itemsRemoved)
            {
                ResolveDestinations();
            }
        }

        public void Refresh()
        {
            if (IsRenaming)
                return;

            if (Settings.RenameOperation == FileRenameOperation.Insert)
                Settings.InsertParameters.ResetIncrement();

            FileRenameLogProvider.Current.Log.Write("Renaming refresh.");

            ResolveDestinations();
        }

        public void ClearItems()
        {
            FileRenameLogProvider.Current.Log.Write("Clear rename items and history.");
            Items.Clear();
            History.Clear();
        }

        public IEnumerable<FileRenameItem> GetItems()
        {
            IEnumerable<FileRenameItem> items;

            bool ascending = (SortOrder == FileRenameSortOrder.Ascending);

            if (Sort == FileRenameSort.FileName)
                items = ascending ? Items.OrderBy(x => x.SourceFileName)
                                  : Items.OrderByDescending(x => x.SourceFileName);
            else
                items = ascending ? Items.OrderBy(x => Path.GetDirectoryName(x.SourceFilePath))
                                  : Items.OrderByDescending(x => Path.GetDirectoryName(x.SourceFilePath));
               
            foreach (FileRenameItem item in items)
            {
                yield return item;
            }
        }

        public void PerformRenaming()
        {
            if (Interlocked.Exchange(ref renamingFlag, FlagEnabled) == FlagDisabled)
            {
                if (Items.Count > 0)
                {
                    ThreadStart threadStart = new ThreadStart(DoPerformRenaming);
                    Thread thread = new Thread(threadStart);
                    thread.Name = NameOfRenameThread;
                    thread.Start();
                }
                else
                {
                    Interlocked.Exchange(ref renamingFlag, FlagDisabled);
                }
            }
        }

        public void CancelRenaming()
        {
            if (IsRenaming)
            {
                FileRenameLogProvider.Current.Log.Write("Cancel renaming.");
                Interlocked.Exchange(ref canceledFlag, FlagEnabled);
            }
        }

        public bool CanUndo()
        {
            return History.Count > 0 && !IsRenaming;
        }

        public void Undo()
        {
            if (CanUndo())
            {
                ParameterizedThreadStart threadStart = new ParameterizedThreadStart(DoUndo);
                Thread thread = new Thread(threadStart);
                thread.Name = NameOfUndoThread;
                thread.Start(false);
            }
        }

        private void DoPerformRenaming()
        {
            bool skipErrorPrompt = false;
            bool canceled = false;
            bool revert = false;
            bool simulation = Settings.IsSimulated;

            if (simulation)
                FileRenameLogProvider.Current.Log.Write("Simulate renaming.");
            else
                FileRenameLogProvider.Current.Log.Write("Perform renaming.");

            foreach (FileRenameItem item in Items)
            {
                try
                {
                    FileRenameEventArgs args = new FileRenameEventArgs(item);

                    // Notify about renaming item.
                    Renaming?.Invoke(this, args);

                    // If requested to stop, then stop renaming.
                    if (args.IsCanceled)
                    {
                        FileRenameLogProvider.Current.Log.Write(simulation ? "Renaming simulation canceled." : "Renaming canceled.");
                        Canceled?.Invoke(this, EventArgs.Empty);
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(item.SourceFilePath) || string.IsNullOrWhiteSpace(item.DestinationFilePath) || item.SourceFilePath == item.DestinationFilePath)
                        continue;

                    FileRenameLogProvider.Current.Log.Write($"Renaming {item.SourceFilePath} to {item.DestinationFilePath}.");

                    if (!simulation)
                    {
                        File.Move(item.SourceFilePath, item.DestinationFilePath);
                        File.Delete(item.SourceFilePath);
                    }

                    FileRenameLogProvider.Current.Log.Write($"Renamed {item.SourceFilePath} to {item.DestinationFilePath}.");

                    // After rename add item to history.
                    History.Add(item);

                    // Notify about renamed item.
                    Renamed?.Invoke(this, new FileRenameEventArgs(item));

                    // If requested to stop, then stop renaming.
                    if (args.IsCanceled)
                    {
                        FileRenameLogProvider.Current.Log.Write(simulation ? "Renaming simulation canceled." : "Renaming canceled.");
                        Canceled?.Invoke(this, EventArgs.Empty);
                        return;
                    }
                }
                catch (Exception exception)
                {
                    FileRenameLogProvider.Current.Log.Write(simulation ? $"Simulation error: {exception.Message}" : $"Renaming error: {exception.Message}");
                    FileRenameError error = new FileRenameError(exception);
                    error.SkipErrorPrompt = skipErrorPrompt;

                    // Raise error event.
                    FileRenameEventArgs e = new FileRenameEventArgs(item, error);
                    Error?.Invoke(this, e);

                    // Check how error should be handled.
                    switch (e.Error.Behavior)
                    {
                        case FileRenameErrorBehavior.Continue:
                            FileRenameLogProvider.Current.Log.Write("Continue on error.");
                            // On continue just proceed with renaming and prevent additional
                            // error prompts if so set.
                            skipErrorPrompt = e.Error.SkipErrorPrompt;
                            break;
                        case FileRenameErrorBehavior.Cancel:
                            FileRenameLogProvider.Current.Log.Write("Cancel on error.");
                            // Cancel rename without trying to revert work already done.
                            canceled = true;
                            break;
                        case FileRenameErrorBehavior.Revert:
                            FileRenameLogProvider.Current.Log.Write("Revert on error.");
                            // Cancel rename and try revert work already done.
                            canceled = true;
                            revert = true;
                            break;
                    }

                    // If canceled on error, then do not handle more items.
                    if (canceled)
                        break;
                }
            }

            // Change renaming state.
            Interlocked.Exchange(ref renamingFlag, FlagDisabled);

            // Remove handled items.
            Items.Clear();

            // If reverted on error, then try to do reverting undo.
            if (revert)
            {
                FileRenameLogProvider.Current.Log.Write(simulation ? "Renaming simulation reverted." : "Renaming reverted.");
                DoUndo(revert);
            }

            // If canceled, raise Canceled event.
            if (canceled)
            {
                FileRenameLogProvider.Current.Log.Write(simulation ? "Renaming simulation canceled." : "Renaming canceled.");
                Canceled?.Invoke(this, EventArgs.Empty);
            }

            // And finally raise Completed event.
            Completed?.Invoke(this, EventArgs.Empty);

            if (simulation)
                FileRenameLogProvider.Current.Log.Write("Simulate renaming completed.");
            else
                FileRenameLogProvider.Current.Log.Write("Perform renaming completed.");
        }

        private void DoUndo(object arg)
        {
            bool revert = (bool)arg;
            bool simulation = Settings.IsSimulated;

            if (simulation)
                FileRenameLogProvider.Current.Log.Write("Simulate undo renaming.");
            else
                FileRenameLogProvider.Current.Log.Write("Perform undo renaming.");

            // Nothing to undo.
            if (History.Count == 0)
            {
                if (simulation)
                    FileRenameLogProvider.Current.Log.Write("No undo items. Simulate undo renaming completed.");
                else
                    FileRenameLogProvider.Current.Log.Write("No undo items. Perform undo renaming completed.");

                return;
            }

            FileRenameLogProvider.Current.Log.Write($"{History.Count} undo items.");

            int count = 0;

            foreach (FileRenameItem item in History)
            {
                try
                {
                    FileRenameEventArgs args = new FileRenameEventArgs(item);

                    // Notify what item manager is undoing.
                    Undoing?.Invoke(this, args);

                    FileRenameLogProvider.Current.Log.Write($"Undo renaming {item.SourceFilePath} to {item.DestinationFilePath}.");
                    FileRenameLogProvider.Current.Log.Write($"Renaming {item.DestinationFilePath} to {item.SourceFilePath}.");

                    // Make opposite move to files (Destination => Source, Source => Destination)
                    if (!simulation)
                    {
                        File.Move(item.DestinationFilePath, item.SourceFilePath);
                        File.Delete(item.DestinationFilePath);
                    }

                    FileRenameLogProvider.Current.Log.Write($"Renamed {item.DestinationFilePath} to {item.SourceFilePath}.");

                    // Notify what item manager has undone.
                    Undone?.Invoke(this, args);

                    count++;
                }
                catch (Exception exception)
                {
                    FileRenameLogProvider.Current.Log.Write(simulation ? $"Undo simulation error: {exception.Message}" : $"Undo error: {exception.Message}");

                    // Skip possible errors in undo.
                    continue;
                }
            }

            // Check if reverter (internal undo) or user launched undo.
            if (revert)
            {
                // Just clear history on revert.
                if (History.Count == count)
                {
                    History.Clear();
                }
            }
            else
            {
                // In user launched undo, clear history and complete.
                History.Clear();
                Completed?.Invoke(this, EventArgs.Empty);
            }

            if (simulation)
                FileRenameLogProvider.Current.Log.Write("Simulate undo renaming completed.");
            else
                FileRenameLogProvider.Current.Log.Write("Perform undo renaming completed.");
        }

        private bool ContainsSource(string sourceFilePath)
        {
            return Items.Any(item => item.SourceFilePath == sourceFilePath);
        }

        private void ResolveDestinations()
        {
            FileRenameLogProvider.Current.Log.Write("Resolve rename destinations.");

            foreach (FileRenameItem item in GetItems())
            {
                string destinationFilePath;

                switch (Settings.RenameOperation)
                {
                    case FileRenameOperation.Insert:
                        destinationFilePath = ResolveDestination(item.SourceFilePath, Settings.InsertParameters);                       
                        break;
                    case FileRenameOperation.Replace:
                        destinationFilePath = ResolveDestination(item.SourceFilePath, Settings.ReplaceParameters);
                        break;
                    case FileRenameOperation.Remove:
                        destinationFilePath = ResolveDestination(item.SourceFilePath, Settings.RemoveParameters);
                        break;
                    default:
                        FileRenameLogProvider.Current.Log.Write($"Not supported value: {Settings.RenameOperation}.");
                        throw new NotSupportedException();
                }

                FileRenameLogProvider.Current.Log.Write($"{item.SourceFilePath} to {destinationFilePath}");

                item.DestinationFilePath = destinationFilePath;
            }

            FileRenameLogProvider.Current.Log.Write("Rename destinations resolved.");
        }

        private string ResolveDestination(string sourceFilePath, FileRenameInsertParameters parameters)
        {
            string directoryPath = Path.GetDirectoryName(sourceFilePath);
            string fileName = Path.GetFileNameWithoutExtension(sourceFilePath);
            string fileExtension = Path.GetExtension(sourceFilePath);

            string insertValue = string.Empty;

            switch (parameters.Insert)
            {
                case FileRenameInsert.CustomValue:
                    if (!string.IsNullOrWhiteSpace(parameters.CustomValue))
                        insertValue = parameters.CustomValue;
                    break;
                case FileRenameInsert.Date:
                case FileRenameInsert.DateTime:
                    insertValue = parameters.DateTime.ToString(parameters.DateTimeFormat);
                    break;
                case FileRenameInsert.Increment:
                    insertValue = parameters.CurrentIncrement.ToString();
                    parameters.CurrentIncrement += parameters.Increment;
                    break;
            }

            // Nothing to insert so return the source path.
            if (string.IsNullOrWhiteSpace(insertValue))
                return sourceFilePath;

            bool appendSeparator = !string.IsNullOrWhiteSpace(parameters.Separator);

            FileRenameInsertLocation insertLocation = parameters.Location;

            if (insertLocation == FileRenameInsertLocation.Index && parameters.LocationIndex <= 0)
                insertLocation = FileRenameInsertLocation.Begin;

            if (insertLocation == FileRenameInsertLocation.Index && parameters.LocationIndex >= fileName.Length - 1)
                insertLocation = FileRenameInsertLocation.End;

            switch (insertLocation)
            {
                case FileRenameInsertLocation.Begin:
                    if (appendSeparator)
                        insertValue = insertValue + parameters.Separator;
                    fileName = insertValue + fileName;
                    break;
                case FileRenameInsertLocation.End:
                    if (appendSeparator)
                        insertValue = parameters.Separator + insertValue;
                    fileName = fileName + insertValue;
                    break;
                case FileRenameInsertLocation.Index:
                    if (appendSeparator)
                        insertValue = parameters.Separator + insertValue + parameters.Separator;
                    fileName = fileName.Insert(parameters.LocationIndex, insertValue);
                    break;
            }

            fileName = fileName.Trim();

            return BuildDestinationFilePath(directoryPath, fileName, fileExtension);
        }

        private string ResolveDestination(string sourceFilePath, FileRenameReplaceParameters parameters)
        {
            string directoryPath = Path.GetDirectoryName(sourceFilePath);
            string fileName = Path.GetFileNameWithoutExtension(sourceFilePath);
            string fileExtension = Path.GetExtension(sourceFilePath);
        
            string replacement = parameters.ReplacementValue ?? string.Empty;

            switch (parameters.Replace)
            {
                case FileRenameReplace.Value:
                    string replace = parameters.ReplaceValue;
                    if (!string.IsNullOrEmpty(replace))
                        fileName = fileName.Replace(parameters.ReplaceValue, replacement);
                    break;
                case FileRenameReplace.AnyNumber:
                    fileName = ReplaceChars(fileName, replacement, c => char.IsNumber(c));
                    break;
                case FileRenameReplace.AnyNotLetter:
                    fileName = ReplaceChars(fileName, replacement, c => !char.IsLetter(c));
                    break;
                case FileRenameReplace.AnyNotLetterOrNumber:
                    fileName = ReplaceChars(fileName, replacement, c => !char.IsLetter(c) && !char.IsNumber(c));
                    break;
                case FileRenameReplace.Whitespace:
                    fileName = ReplaceChars(fileName, replacement, c => char.IsWhiteSpace(c));
                    break;
            }

            fileName = fileName.Trim();

            if (fileName.Length == 0)
            {
                FileRenameLogProvider.Current.Log.Write("Replacing file name creates empty value.");
                throw new InvalidOperationException("Replacing file name creates empty value.");
            }

            string destinationFilePath = BuildDestinationFilePath(directoryPath, fileName, fileExtension);

            return destinationFilePath;
        }

        private string ResolveDestination(string sourceFilePath, FileRenameRemoveParameters parameters)
        {
            string directoryPath = Path.GetDirectoryName(sourceFilePath);
            string fileName = Path.GetFileNameWithoutExtension(sourceFilePath);
            string fileExtension = Path.GetExtension(sourceFilePath);

            switch (parameters.Remove)
            {
                case FileRenameRemove.Value:
                    string remove = parameters.RemoveValue;
                    
                    // If something to remove is empty, then removing is not done.
                    if (string.IsNullOrEmpty(remove))
                        return sourceFilePath;

                    fileName = fileName.Replace(remove, string.Empty);
                    break;
                case FileRenameRemove.AnyNumber:
                    fileName = ReplaceChars(fileName, string.Empty, c => char.IsNumber(c));
                    break;
                case FileRenameRemove.AnyNotLetter:
                    fileName = ReplaceChars(fileName, string.Empty, c => !char.IsLetter(c));
                    break;
                case FileRenameRemove.AnyNotLetterOrNumber:
                    fileName = ReplaceChars(fileName, string.Empty, c => !char.IsLetter(c) && !char.IsNumber(c));
                    break;
                case FileRenameRemove.Whitespace:
                    fileName = ReplaceChars(fileName, string.Empty, c => char.IsWhiteSpace(c));
                    break;
            }

            fileName = fileName.Trim();

            if (fileName.Length == 0)
            {
                FileRenameLogProvider.Current.Log.Write("Removing from file name creates empty value.");
                throw new InvalidOperationException("Removing from file name creates empty value.");
            }

            string destinationFilePath = BuildDestinationFilePath(directoryPath, fileName, fileExtension);

            return destinationFilePath;
        }

        private string ReplaceChars(string value, string replacement, Predicate<char> predicate)
        {
            StringBuilder sb = new StringBuilder(value.Length);

            foreach (char c in value)
            {
                if (predicate(c))
                    sb.Append(replacement);
                else
                    sb.Append(c);
            }

            return sb.ToString();
        }

        private static string BuildDestinationFilePath(string directoryPath, string fileName, string fileExtension)
        {
            string fileNameWithExtension = fileName + fileExtension;
            string destinationFilePath = Path.Combine(directoryPath, fileNameWithExtension);
            return destinationFilePath;
        }
    }
}
