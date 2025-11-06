using System;

namespace Masasamjant.FileRenameManager
{
    public class FileRenameSettings
    {
        private FileRenameOperation renameOperation;

        public FileRenameSettings()
        {
            InsertParameters = new FileRenameInsertParameters();
            ReplaceParameters = new FileRenameReplaceParameters();
            RemoveParameters = new FileRenameRemoveParameters();
            IsSimulated = false;
        }

        public FileRenameOperation RenameOperation
        {
            get { return renameOperation; }
            set
            {
                if (renameOperation != value)
                {
                    renameOperation = value;
                }
            }
        }

        public FileRenameInsertParameters InsertParameters { get; }

        public FileRenameReplaceParameters ReplaceParameters { get; }

        public FileRenameRemoveParameters RemoveParameters { get; }

        public bool IsSimulated { get; set; }
    }
}
