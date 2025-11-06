namespace Masasamjant.FileRenameManager
{
    public class FileRenameRemoveParameters : FileRenameParameters
    {
        private FileRenameRemove remove;
        private string removeValue;

        public FileRenameRemove Remove
        {
            get { return remove; }
            set
            {
                if (remove != value)
                {
                    remove = value;
                    SetHasParameterChanges();
                }
            }
        }

        public string RemoveValue
        {
            get { return removeValue; }
            set
            {
                if (removeValue != value)
                {
                    removeValue = value;
                    SetHasParameterChanges();
                }
            }
        }
    }
}
