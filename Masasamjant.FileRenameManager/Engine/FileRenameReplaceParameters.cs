namespace Masasamjant.FileRenameManager
{
    public class FileRenameReplaceParameters : FileRenameParameters
    {
        private FileRenameReplace replace;
        private string replaceValue;
        private string replacementValue;

        public FileRenameReplace Replace
        {
            get { return replace; }
            set
            {
                if (replace != value)
                {
                    replace = value;
                    SetHasParameterChanges();
                }
            }
        }

        public string ReplaceValue
        {
            get { return replaceValue; }
            set
            {
                if (replaceValue != value)
                {
                    replaceValue = value;
                    SetHasParameterChanges();
                }
            }
        }

        public string ReplacementValue
        {
            get { return replacementValue; }
            set
            {
                if (replacementValue != value)
                {
                    replacementValue = value;
                    SetHasParameterChanges();
                }
            }
        }
    }
}
