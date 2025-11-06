using System;

namespace Masasamjant.FileRenameManager
{
    public partial class CustomValueControl : InsertUserControl
    {
        public CustomValueControl()
            : this(null)
        { }

        public CustomValueControl(FileRenameInsertParameters parameters)
            : base(parameters)
        {
            InitializeComponent();
        }

        public string CustomValue
        {
            get { return textValue.Text; }
        }

        public bool HasCustomValue
        {
            get { return !string.IsNullOrWhiteSpace(CustomValue); }
        }

        private void OnTextValueTextChanged(object sender, EventArgs e)
        {
            Parameters.CustomValue = CustomValue;
            OnParametersChanged(EventArgs.Empty);
        }
    }
}
