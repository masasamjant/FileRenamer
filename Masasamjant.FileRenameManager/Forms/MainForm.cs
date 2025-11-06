using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Masasamjant.FileRenameManager
{
    public partial class MainForm : Form
    {
        private const int FileListViewErrorImageIndex = 1;
        private const int FileListViewAcceptImageIndex = 0;
        private const int NoImageIndex = -1;

        private delegate void EnabledStateChangeHandler(bool enabled);
        private delegate void FileRenameErrorHandler(FileRenameEventArgs e);
        private delegate void FileRenamedHandler(FileRenameEventArgs e);
        private delegate void FileRenameStatusChanged(string statusText);

        public MainForm()
        {
            InitializeComponent();
            Log = new FileRenameLog();
            FileRenameLogProvider.Current = new FileRenameLogProvider(Log);

            FileRenameManager = new FileRenameManager();
            FileRenameManager.Renamed += OnFileRenameManagerRenamed;
            FileRenameManager.Canceled += OnFileRenameManagerCanceled;
            FileRenameManager.Error += OnFileRenameManagerError;
            FileRenameManager.Completed += OnFileRenameManagerCompleted;
            FileRenameManager.Renaming += OnFileRenameManagerRenaming;
            FileRenameManager.Undoing += OnFileRenameManagerUndoing;
            FileRenameManager.Undone += OnFileRenameManagerUndone;
            IsCanceled = false;
        }

        private FileRenameManager FileRenameManager { get; }

        private FileRenameLog Log { get; }

        private bool IsCanceled { get; set; }

        private SortBy SortBy
        {
            get
            {
                if (byNameToolStripMenuItem.Checked)
                    return SortBy.File;

                return SortBy.Folder;
            }
        }

        private void OnMainFormLoad(object sender, EventArgs e)
        {
            Log.Write("Application started.");

            SetupFilesListViewColumns();

            if (customValueToolStripMenuItem.Checked)
            {
                SetInsertControl();
            }

            comboPosition.SelectedIndex = 0;

            // Disable buttons/menu items that require either files to be selected
            // or rename be performed.
            ChangeRemoveAllEnabledState(false);
            ChangeUndoEnabledState(false);
            ChangeRemoveSelectedEnabledState(false);
            ChangeRefreshEnabledState(false);
            ChangeSortEnabledState(false);
            ChangePerformEnabledState(false);
            ChangeStopEnabledState(false);
        }

        private void OnMainFormClosing(object sender, FormClosingEventArgs e)
        {
            Log.Write("Application closed.");
            Log.Dispose();
        }

        private void OnAboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            FileRenameLogProvider.Current.Log.Write("Open About form.");
            using (AboutForm about = new AboutForm())
            {
                about.StartPosition = FormStartPosition.CenterParent;
                about.ShowDialog();
            }
        }

        private void OnHelpToolStripMenuItemClick(object sender, EventArgs e)
        {
            FileRenameLogProvider.Current.Log.Write("Open Help form.");
            using (HelpForm help = new HelpForm())
            {
                help.StartPosition = FormStartPosition.CenterParent;
                help.ShowDialog();
            }
        }

        private void OnShowOptions(object sender, EventArgs e)
        {
            FileRenameLogProvider.Current.Log.Write("Open Options form.");
            using (OptionsForm options = new OptionsForm())
            {
                options.StartPosition = FormStartPosition.CenterParent;
                options.ShowDialog();
            }
        }

        private void OnInsertToolStripMenuItemCheckedChanged(object sender, EventArgs e)
        {
            if (insertToolStripMenuItem.Checked)
            {
                FileRenameLogProvider.Current.Log.Write("Insert action selected.");
                replaceToolStripMenuItem.Checked = false;
                removeToolStripMenuItem.Checked = false;
                operationTabs.SelectedTab = insertTab;
            }
        }

        private void OnReplaceToolStripMenuItemCheckedChanged(object sender, EventArgs e)
        {
            if (replaceToolStripMenuItem.Checked)
            {
                FileRenameLogProvider.Current.Log.Write("Replace action selected.");
                insertToolStripMenuItem.Checked = false;
                removeToolStripMenuItem.Checked = false;
                operationTabs.SelectedTab = replaceTab;
            }
        }

        private void OnRemoveToolStripMenuItemCheckedChanged(object sender, EventArgs e)
        {
            if (removeToolStripMenuItem.Checked)
            {
                FileRenameLogProvider.Current.Log.Write("Remove action selected.");
                insertToolStripMenuItem.Checked = false;
                replaceToolStripMenuItem.Checked = false;
                operationTabs.SelectedTab = removeTab;
            }
        }

        private void OnCustomValueToolStripMenuItemCheckedChanged(object sender, EventArgs e)
        {
            if (customValueToolStripMenuItem.Checked)
            {
                FileRenameLogProvider.Current.Log.Write("Custom value tool selected.");
                dateToolStripMenuItem.Checked = false;
                dateAndTimeToolStripMenuItem.Checked = false;
                incrementToolStripMenuItem.Checked = false;

                if (!radioCustomValue.Checked)
                    radioCustomValue.Checked = true;
            }
        }

        private void OnDateToolStripMenuItemCheckedChanged(object sender, EventArgs e)
        {
            if (dateToolStripMenuItem.Checked)
            {
                FileRenameLogProvider.Current.Log.Write("Date tool selected.");
                customValueToolStripMenuItem.Checked = false;
                dateAndTimeToolStripMenuItem.Checked = false;
                incrementToolStripMenuItem.Checked = false;

                if (!radioDate.Checked)
                    radioDate.Checked = true;
            }
        }

        private void OnDateAndTimeToolStripMenuItemCheckedChanged(object sender, EventArgs e)
        {
            if (dateAndTimeToolStripMenuItem.Checked)
            {
                FileRenameLogProvider.Current.Log.Write("Date and time tool selected.");
                customValueToolStripMenuItem.Checked = false;
                dateToolStripMenuItem.Checked = false;
                incrementToolStripMenuItem.Checked = false;

                if (!radioDateTime.Checked)
                    radioDateTime.Checked = true;
            }
        }

        private void OnIncrementToolStripMenuItemCheckedChanged(object sender, EventArgs e)
        {
            if (incrementToolStripMenuItem.Checked)
            {
                FileRenameLogProvider.Current.Log.Write("Increment tool selected.");
                customValueToolStripMenuItem.Checked = false;
                dateToolStripMenuItem.Checked = false;
                dateAndTimeToolStripMenuItem.Checked = false;

                if (!radioIncrement.Checked)
                    radioIncrement.Checked = true;
            }
        }

        private void OnRadioCustomValueCheckedChanged(object sender, EventArgs e)
        {
            if (radioCustomValue.Checked)
            {
                FileRenameLogProvider.Current.Log.Write("Custom value selected.");
                if (!customValueToolStripMenuItem.Checked)
                    customValueToolStripMenuItem.Checked = true;

                SetInsertControl();

                FileRenameManager.Refresh();
                PopuplateFilesListView(true);
            }
        }

        private void OnRadioDateCheckedChanged(object sender, EventArgs e)
        {
            if (radioDate.Checked)
            {
                FileRenameLogProvider.Current.Log.Write("Date value selected.");
                if (!dateToolStripMenuItem.Checked)
                    dateToolStripMenuItem.Checked = true;

                SetInsertControl();

                FileRenameManager.Refresh();
                PopuplateFilesListView(true);
            }
        }

        private void OnRadioDateTimeCheckedChanged(object sender, EventArgs e)
        {
            if (radioDateTime.Checked)
            {
                FileRenameLogProvider.Current.Log.Write("Date and time value selected.");
                if (!dateAndTimeToolStripMenuItem.Checked)
                    dateAndTimeToolStripMenuItem.Checked = true;

                SetInsertControl();

                FileRenameManager.Refresh();
                PopuplateFilesListView(true);
            }
        }

        private void OnRadioIncrementCheckedChanged(object sender, EventArgs e)
        {
            if (radioIncrement.Checked)
            {
                FileRenameLogProvider.Current.Log.Write("Increment value selected.");
                if (!incrementToolStripMenuItem.Checked)
                    incrementToolStripMenuItem.Checked = true;

                SetInsertControl();

                FileRenameManager.Refresh();
                PopuplateFilesListView(true);
            }
        }

        private void SetInsertControl()
        {
            if (panelInsertControls.Controls.Count > 0)
            {
                FileRenameLogProvider.Current.Log.Write("Remove previous insert controls.");
                foreach (InsertUserControl c in panelInsertControls.Controls)
                {
                    c.ParametersChanged -= OnInsertControlParametersChanged;
                    c.Dispose();
                }

                panelInsertControls.Controls.Clear();
            }

            InsertUserControl control = null;

            if (radioCustomValue.Checked)
            {
                FileRenameLogProvider.Current.Log.Write("Add custom value insert control.");
                control = new CustomValueControl(FileRenameManager.Settings.InsertParameters);
                FileRenameManager.Settings.InsertParameters.Insert = FileRenameInsert.CustomValue;
            }
            else if (radioDate.Checked)
            {
                FileRenameLogProvider.Current.Log.Write("Add date value insert control.");
                control = new DateControl(FileRenameManager.Settings.InsertParameters);
                FileRenameManager.Settings.InsertParameters.Insert = FileRenameInsert.Date;
            }
            else if (radioDateTime.Checked)
            {
                FileRenameLogProvider.Current.Log.Write("Add date and time value insert control.");
                control = new DateTimeControl(FileRenameManager.Settings.InsertParameters);
                FileRenameManager.Settings.InsertParameters.Insert = FileRenameInsert.DateTime;
            }
            else if (radioIncrement.Checked)
            {
                FileRenameLogProvider.Current.Log.Write("Add increment value insert control.");
                control = new IncrementControl(FileRenameManager.Settings.InsertParameters);
                FileRenameManager.Settings.InsertParameters.Insert = FileRenameInsert.Increment;
            }

            if (control != null)
            {
                control.ParametersChanged += OnInsertControlParametersChanged;
                panelInsertControls.Controls.Add(control);
            }
        }

        private void OnInsertControlParametersChanged(object sender, EventArgs e)
        {
            FileRenameLogProvider.Current.Log.Write("Insert value parameters changed.");
            FileRenameManager.Refresh();
            PopuplateFilesListView(true);
        }

        private void ShowToolStripToolTip(string text)
        {
            toolStripToolTip.Text = text;
        }

        private void OnToolButtonMouseEnter(object sender, EventArgs e)
        {
            // Show tool button text on tool strip.
            Button button = (Button)sender;
            string tag = (string)button.Tag;
            string toolTipText = Resources.ToolTip.ResourceManager.GetString(tag);
            ShowToolStripToolTip(toolTipText);
        }

        private void OnToolButtonMouseLeave(object sender, EventArgs e)
        {
            // Remove tool button text from tool strip.
            ShowToolStripToolTip(string.Empty);
        }

        private void OnByNameToolStripMenuItemCheckedChanged(object sender, EventArgs e)
        {
            if (byNameToolStripMenuItem.Checked)
            {
                FileRenameLogProvider.Current.Log.Write("Sort by name selected.");
                byPathToolStripMenuItem.Checked = false;
                FileRenameManager.Sort = FileRenameSort.FileName;
                FileRenameManager.Refresh();
                PopuplateFilesListView(true);
            }
        }

        private void OnByPathToolStripMenuItemCheckedChanged(object sender, EventArgs e)
        {
            if (byPathToolStripMenuItem.Checked)
            {
                FileRenameLogProvider.Current.Log.Write("Sort by path selected.");
                byNameToolStripMenuItem.Checked = false;
                FileRenameManager.Sort = FileRenameSort.FileDirectory;
                FileRenameManager.Refresh();
                PopuplateFilesListView(true);
            }
        }

        private void OnSelectFile(object sender, EventArgs e)
        {
            if (selectFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] selectedFiles = FileSelectionHelper.GetSelectedFiles(selectFileDialog);

                if (selectedFiles.Length > 1)
                    FileRenameManager.AddItems(selectedFiles);
                else if (selectedFiles.Length == 1)
                    FileRenameManager.AddItem(selectedFiles[0]);

                FileRenameManager.Refresh();
                PopuplateFilesListView(true);
            }
        }

        private void SetupFilesListViewColumns()
        {
            if (Program.ShowSingleFileNameColumn)
            {
                fileListView.Columns.RemoveAt(1);
                CalculateFileListViewColumnWidths();
                fileListView.Columns[0].Text = Resources.MainFormResource.File;
            }
        }

        private void PopuplateFilesListView(bool refreshing)
        {
            FileRenameLogProvider.Current.Log.Write("Populate file list view.");
            fileListView.Items.Clear();

            foreach (FileRenameItem item in FileRenameManager.GetItems())
            {
                // Make copy from original for UI so that we can alter it without affecting the original.
                ListViewItem listViewItem = (ListViewItem)item.ListViewItem.Clone();

                // If single column visible, then set to destination file on refreshing.
                if (Program.ShowSingleFileNameColumn && refreshing)
                    listViewItem = new ListViewItem(listViewItem.SubItems[1].Text);

                fileListView.Items.Add(listViewItem);

                int imageIndex = NoImageIndex;
                string toolTipText = string.Empty;

                if (!item.SourceFileExists())
                {
                    imageIndex = FileListViewErrorImageIndex;
                    toolTipText = Resources.ToolTip.SourceFileNotExist;
                }
                else if (item.DestinationFileExists())
                {
                    imageIndex = FileListViewErrorImageIndex;
                    toolTipText = Resources.ToolTip.DestinationFileExist;
                }

                item.ListViewItem.ImageIndex = imageIndex;
                item.ListViewItem.ToolTipText = toolTipText;
            }

            bool enabled = (fileListView.Items.Count > 0);

            // Enabled UI elements requiring files to be selected.
            ChangePerformEnabledState(enabled);
            ChangeRemoveAllEnabledState(enabled);
            ChangeRemoveSelectedEnabledState(enabled);
            ChangeRefreshEnabledState(enabled);
            ChangeSortEnabledState(enabled);
        }

        private void OnFileListViewDrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            ListViewHelper.DrawCustomHeader(fileListView, e);
        }

        private void OnFileListViewDrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void OnFileListViewDrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void OnComboPositionSelectedIndexChanged(object sender, EventArgs e)
        {
            numericIndex.Enabled = comboPosition.SelectedIndex == 2;

            if (!numericIndex.Enabled)
                numericIndex.Value = 0;

            switch (comboPosition.SelectedIndex)
            {
                case 0:
                    FileRenameManager.Settings.InsertParameters.Location = FileRenameInsertLocation.Begin;
                    break;
                case 1:
                    FileRenameManager.Settings.InsertParameters.Location = FileRenameInsertLocation.End;
                    break;
                case 2:
                    FileRenameManager.Settings.InsertParameters.Location = FileRenameInsertLocation.Index;
                    FileRenameManager.Settings.InsertParameters.LocationIndex = Convert.ToInt32(numericIndex.Value);
                    break;
            }

            FileRenameManager.Refresh();
            PopuplateFilesListView(true);
        }

        private void OnNumericIndexValueChanged(object sender, EventArgs e)
        {
            FileRenameManager.Settings.InsertParameters.LocationIndex = Convert.ToInt32(numericIndex.Value);
            FileRenameManager.Refresh();
            PopuplateFilesListView(true);
        }

        private void OnFileListViewColumnClick(object sender, ColumnClickEventArgs e)
        {
            // TODO: Add sorting by clicked column.
            // - Check column to sort.
            // - Check whether sort by file name or by file location.

        }

        private void OnOperationTabsSelected(object sender, TabControlEventArgs e)
        {
            FileRenameOperation operation = (FileRenameOperation)Enum.Parse(typeof(FileRenameOperation), e.TabPage.Tag.ToString());
            FileRenameManager.Settings.RenameOperation = operation;

            switch (operation)
            {
                case FileRenameOperation.Replace:
                    comboReplaceKind.SelectedIndex = 0;
                    FileRenameManager.Settings.ReplaceParameters.Replace = (FileRenameReplace)comboReplaceKind.SelectedIndex;
                    FileRenameManager.Settings.ReplaceParameters.ReplaceValue = textReplace.Text;
                    FileRenameManager.Settings.ReplaceParameters.ReplacementValue = textReplacement.Text;
                    break;
                case FileRenameOperation.Remove:
                    comboRemoveKind.SelectedIndex = 0;
                    FileRenameManager.Settings.RemoveParameters.Remove = (FileRenameRemove)comboRemoveKind.SelectedIndex;
                    FileRenameManager.Settings.RemoveParameters.RemoveValue = textRemove.Text;
                    break;
            }

            FileRenameManager.Refresh();
            PopuplateFilesListView(true);
        }

        private void OnComboReplaceKindSelectedIndexChanged(object sender, EventArgs e)
        {
            textReplace.Enabled = comboReplaceKind.SelectedIndex == 0;

            FileRenameManager.Settings.ReplaceParameters.Replace = (FileRenameReplace)comboReplaceKind.SelectedIndex;

            if (!textReplace.Enabled)
                textReplace.Text = string.Empty;

            FileRenameManager.Refresh();
            PopuplateFilesListView(true);
        }

        private void OnComboRemoveKindSelectedIndexChanged(object sender, EventArgs e)
        {
            textRemove.Enabled = comboRemoveKind.SelectedIndex == 0;

            FileRenameManager.Settings.RemoveParameters.Remove = (FileRenameRemove)comboRemoveKind.SelectedIndex;

            if (!textRemove.Enabled)
                textRemove.Text = string.Empty;

            FileRenameManager.Refresh();
            PopuplateFilesListView(true);
        }

        private void OnSelectFolder(object sender, EventArgs e)
        {
            using (FolderForm form = new FolderForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    FileRenameManager.AddItems(form.SelectedFiles);
                    PopuplateFilesListView(false);
                }
            }
        }

        private void OnButtonPerformClick(object sender, EventArgs e)
        {
            ClearStatusText();
            IsCanceled = false;
            FileRenameManager.PerformRenaming();
            ChangeStopEnabledState(true);
        }

        private void OnButtonStopClick(object sender, EventArgs e)
        {
            IsCanceled = true;
            ClearStatusText();
        }

        private void OnButtonRefreshClick(object sender, EventArgs e)
        {
            ClearStatusText();
            FileRenameManager.Refresh();
            PopuplateFilesListView(true);
        }

        private void OnButtonUndoClick(object sender, EventArgs e)
        {
            ClearStatusText();

            if (FileRenameManager.CanUndo())
                FileRenameManager.Undo();
        }

        private void OnButtonRedoClick(object sender, EventArgs e)
        {
            ClearStatusText();
        }

        private void OnButtonSortClick(object sender, EventArgs e)
        {
            ClearStatusText();

            FileRenameSortOrder order = FileRenameManager.SortOrder;

            if (order == FileRenameSortOrder.Ascending)
                order = FileRenameSortOrder.Descending;
            else
                order = FileRenameSortOrder.Ascending;

            FileRenameManager.SortOrder = order;
            FileRenameManager.Refresh();
            PopuplateFilesListView(true);
        }

        private void OnButtonClearAllClick(object sender, EventArgs e)
        {
            ClearStatusText();
            FileRenameManager.ClearItems();
            PopuplateFilesListView(false);
        }

        private void OnExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            Close();
        }

        private void ChangeRemoveAllEnabledState(bool enabled)
        {
            if (InvokeRequired)
                Invoke(new EnabledStateChangeHandler(ChangeRemoveAllEnabledState), enabled);
            else
            {
                clearToolStripMenuItem.Enabled = enabled;
                buttonClearAll.Enabled = enabled;
            }
        }

        private void ChangeRemoveSelectedEnabledState(bool enabled)
        {
            if (InvokeRequired)
                Invoke(new EnabledStateChangeHandler(ChangeRemoveSelectedEnabledState), enabled);
            else
            {
                removeSelectedToolStripMenuItem.Enabled = enabled;
                removeSelectedContextMenuItem.Enabled = enabled;
            }
        }

        private void ChangeUndoEnabledState(bool enabled)
        {
            if (InvokeRequired)
                Invoke(new EnabledStateChangeHandler(ChangeUndoEnabledState), enabled);
            else
            { 
                undoToolStripMenuItem.Enabled = enabled;
                buttonUndo.Enabled = enabled;
            }
        }

        private void ChangeRefreshEnabledState(bool enabled)
        {
            if (InvokeRequired)
                Invoke(new EnabledStateChangeHandler(ChangeRefreshEnabledState), enabled);
            else
                buttonRefresh.Enabled = enabled;
        }

        private void ChangeSortEnabledState(bool enabled)
        {
            if (InvokeRequired)
                Invoke(new EnabledStateChangeHandler(ChangeSortEnabledState), enabled);
            else
                buttonSort.Enabled = enabled;
        }

        private void ChangePerformEnabledState(bool enabled)
        {
            if (InvokeRequired)
                Invoke(new EnabledStateChangeHandler(ChangePerformEnabledState), enabled);
            else
            {
                buttonPerform.Enabled = enabled;
                buttonPerform2.Enabled = enabled;
            }
        }

        private void ChangeStopEnabledState(bool enabled)
        {
            if (InvokeRequired)
                Invoke(new EnabledStateChangeHandler(ChangeStopEnabledState), enabled);
            else
            {
                buttonStop.Enabled = enabled;
                buttonStop2.Enabled = enabled;
            }
        }

        private void ChangeAddFileEnabledState(bool enabled)
        {
            if (InvokeRequired)
                Invoke(new EnabledStateChangeHandler(ChangeAddFileEnabledState), enabled);
            else
            {
                buttonAddFile.Enabled = enabled;
                addFileToolStripMenuItem.Enabled = enabled;
                addFileContextMenuItem.Enabled = enabled;
            }        
        }

        private void ChangeAddFolderEnabledState(bool enabled)
        {
            if (InvokeRequired)
                Invoke(new EnabledStateChangeHandler(ChangeAddFolderEnabledState), enabled);
            else
            {
                buttonAddFolder.Enabled = enabled;
                addFolderToolStripMenuItem.Enabled = enabled;
                addFolderContextMenuItem.Enabled = enabled;
            }
        }

        private void OnRemoveSelectedToolStripMenuItemClick(object sender, EventArgs e)
        {
            foreach (ListViewItem item in fileListView.SelectedItems)
            {
                FileRenameItem fileRenamItem = (FileRenameItem)item.Tag;
                FileRenameManager.RemoveItem(fileRenamItem.SourceFilePath);
            }

            PopuplateFilesListView(false);
        }

        private void OnTextInsertSeparatorTextChanged(object sender, EventArgs e)
        {
            FileRenameManager.Settings.InsertParameters.Separator = textInsertSeparator.Text;
            FileRenameManager.Refresh();
            PopuplateFilesListView(true);
        }

        private void OnTextReplaceTextChanged(object sender, EventArgs e)
        {
            FileRenameManager.Settings.ReplaceParameters.ReplaceValue = textReplace.Text;

            if (textReplace.Enabled)
            {
                FileRenameManager.Refresh();
                PopuplateFilesListView(true);
            }
        }

        private void OnTextReplacementTextChanged(object sender, EventArgs e)
        {
            FileRenameManager.Settings.ReplaceParameters.ReplacementValue = textReplacement.Text;
            FileRenameManager.Refresh();
            PopuplateFilesListView(true);
        }

        private void OnTextRemoveTextChanged(object sender, EventArgs e)
        {
            FileRenameManager.Settings.RemoveParameters.RemoveValue = textRemove.Text;

            if (textRemove.Enabled)
            {
                FileRenameManager.Refresh();
                PopuplateFilesListView(true);
            }
        }

        private void OnCheckSimulateCheckedChanged(object sender, EventArgs e)
        {
            FileRenameManager.Settings.IsSimulated = checkSimulate.Checked;
        }

        private void ClearStatusText()
        {
            renameStatusLabel.Text = string.Empty;
        }

        #region FileRenameManager event handlers

        private void OnFileRenameManagerUndone(object sender, FileRenameEventArgs e)
        {
            if (InvokeRequired)
                Invoke(new FileRenamedHandler(OnFileUndone), e);
            else
                OnFileUndone(e);
        }

        private void OnFileRenameManagerUndoing(object sender, FileRenameEventArgs e)
        {
            if (InvokeRequired)
                Invoke(new FileRenamedHandler(OnFileUndoing), e);
            else
                OnFileUndoing(e);
        }

        private void OnFileRenameManagerRenaming(object sender, FileRenameEventArgs e)
        {
            if (InvokeRequired)
                Invoke(new FileRenamedHandler(OnFileRenaming), e);
            else
                OnFileRenaming(e);

            e.IsCanceled = IsCanceled;
        }

        private void OnFileRenameManagerCompleted(object sender, EventArgs e)
        {
            ChangeUndoEnabledState(FileRenameManager.CanUndo());
            ChangePerformEnabledState(false);
            ChangeStopEnabledState(false);
            ChangeRefreshEnabledState(false);

            if (!IsCanceled)
            {
                if (InvokeRequired)
                    Invoke(new FileRenameStatusChanged(OnFileRenameStatusChanged), Resources.Status.RenameCompleted);
                else
                    OnFileRenameStatusChanged(Resources.Status.RenameCompleted);
            }
        }

        private void OnFileRenameManagerError(object sender, FileRenameEventArgs e)
        {
            if (InvokeRequired)
                Invoke(new FileRenameErrorHandler(OnFileRenameError), e);
            else
                OnFileRenameError(e);
        }

        private void OnFileRenameManagerCanceled(object sender, EventArgs e)
        {
            if (InvokeRequired)
                Invoke(new FileRenameStatusChanged(OnFileRenameStatusChanged), Resources.Status.RenameCanceled);
            else
                OnFileRenameStatusChanged(Resources.Status.RenameCanceled);
        }

        private void OnFileRenameManagerRenamed(object sender, FileRenameEventArgs e)
        {
            if (InvokeRequired)
                Invoke(new FileRenamedHandler(OnFileRenamed), e);
            else
                OnFileRenamed(e);

            e.IsCanceled = IsCanceled;
        }

        private void OnFileRenameError(FileRenameEventArgs e)
        {
            if (!e.Error.SkipErrorPrompt)
            {
                using (ErrorForm errorForm = new ErrorForm())
                {
                    if (errorForm.ShowDialog() == DialogResult.OK)
                    {
                        e.Error.Behavior = errorForm.ErrorBehavior;
                        e.Error.SkipErrorPrompt = errorForm.SkipErrorPrompt;
                    }
                }
            }

            e.Item.ListViewItem.ImageIndex = FileListViewErrorImageIndex;
            e.Item.ListViewItem.ToolTipText = e.Error.Exception.Message;
        }

        private void OnFileRenameStatusChanged(string statusText)
        {
            renameStatusLabel.Text = statusText;
        }

        private void OnFileRenamed(FileRenameEventArgs e)
        {
            e.Item.ListViewItem.ImageIndex = FileListViewAcceptImageIndex;
            OnFileRenameStatusChanged(string.Format(Resources.Status.RenamedFile, e.Item.DestinationFilePath));
        }

        private void OnFileRenaming(FileRenameEventArgs e)
        {
            OnFileRenameStatusChanged(string.Format(Resources.Status.RenamingFile, e.Item.SourceFilePath));
        }

        private void OnFileUndoing(FileRenameEventArgs e)
        { }

        private void OnFileUndone(FileRenameEventArgs e)
        { }

        private void OnFileListViewResize(object sender, EventArgs e)
        {
            CalculateFileListViewColumnWidths();
        }

        private void CalculateFileListViewColumnWidths()
        {
            int columnsTotalWidth = fileListView.Width - 14;

            // If only single file name column visible, then set it to total width.
            // Otherwise dived width equally with columns.
            if (Program.ShowSingleFileNameColumn)
                fileListView.Columns[0].Width = columnsTotalWidth;
            else
            {
                int columnWidth = columnsTotalWidth / 2;
                fileListView.Columns[0].Width = columnWidth;
                fileListView.Columns[1].Width = columnWidth;
            }
        }


        #endregion

        private void OnMainFormResize(object sender, EventArgs e)
        {
            RelocateControl(buttonPerform2, Width, Height, 80, 222);
            RelocateControl(buttonStop2, Width, Height, 80, 157);
        }

        private static void RelocateControl(Control control, int width, int height, int dx, int dy)
        {
            int x = width - dx;
            int y = height - dy;
            control.Location = new Point(x, y);
        }
    }
}
