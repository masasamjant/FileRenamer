using System;

namespace Masasamjant.FileRenameManager
{
    public class FileRenameEventArgs : EventArgs
    {
        public FileRenameEventArgs(FileRenameItem item)
            : this(item, null)
        { }

        public FileRenameEventArgs(FileRenameItem item, FileRenameError error)
        {
            Item = item;
            Error = error;
            IsCanceled = false;
        }

        public FileRenameItem Item { get; }

        public FileRenameError Error { get; }

        public FileRenameResult Result
        {
            get
            {
                if (Error != null)
                    return FileRenameResult.Failure;

                return FileRenameResult.Success;
            }
        }

        public bool IsCanceled { get; set; }
    }

    public enum FileRenameResult : int
    {
        Success = 0,
        Failure = 1
    }
}
