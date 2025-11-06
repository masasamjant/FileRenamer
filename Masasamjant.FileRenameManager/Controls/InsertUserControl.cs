using System;
using System.Windows.Forms;

namespace Masasamjant.FileRenameManager
{
    public class InsertUserControl : UserControl
    {
        private FileRenameInsertParameters parameters;

        public event EventHandler ParametersChanged;

        protected InsertUserControl()
            : this(null)
        { }

        protected InsertUserControl(FileRenameInsertParameters parameters)
            : base()
        {
            this.parameters = parameters;
        }

        public FileRenameInsertParameters Parameters
        {
            get
            {
                if (parameters == null)
                    parameters = new FileRenameInsertParameters();

                return parameters;
            }
        }

        protected virtual void OnParametersChanged(EventArgs e)
        {
            ParametersChanged?.Invoke(this, e);
        }
    }
}
