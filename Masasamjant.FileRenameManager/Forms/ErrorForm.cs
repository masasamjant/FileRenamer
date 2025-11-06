using System;
using System.Windows.Forms;

namespace Masasamjant.FileRenameManager
{
    public partial class ErrorForm : Form
    {
        public ErrorForm()
        {
            InitializeComponent();
        }

        public FileRenameErrorBehavior ErrorBehavior
        {
            get { return (FileRenameErrorBehavior)comboBehavior.SelectedIndex; }
        }

        public bool SkipErrorPrompt
        {
            get { return checkSkipPrompt.Enabled && checkSkipPrompt.Checked; }
        }

        private void OnErrorFormLoad(object sender, EventArgs e)
        {
            comboBehavior.SelectedIndex = 0;
            checkSkipPrompt.Enabled = true;
        }

        private void OnComboBehaviorSelectedIndexChanged(object sender, EventArgs e)
        {
            checkSkipPrompt.Enabled = (comboBehavior.SelectedIndex == 0);
        }

        private void OnButtonOKClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
