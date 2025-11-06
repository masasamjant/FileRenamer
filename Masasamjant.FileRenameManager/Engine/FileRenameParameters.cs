using System;

namespace Masasamjant.FileRenameManager
{
    public class FileRenameParameters
    {
        public bool HasParameterChanges { get; private set; }

        protected void SetHasParameterChanges()
        {
            HasParameterChanges = true;
        }
    }
}
