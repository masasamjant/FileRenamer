using System;

namespace Masasamjant.FileRenameManager
{
    public class FileRenameError
    {
        public FileRenameError(Exception exception)
        {
            Exception = exception;
        }

        public Exception Exception { get; }

        public FileRenameErrorBehavior Behavior { get; set; }

        public bool SkipErrorPrompt { get; set; }
    }
}
