using System.Windows.Forms;

namespace Masasamjant.FileRenameManager
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void linkClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FileRenameLogProvider.Current.Log.Write("Close About form.");
            Close();
        }
    }
}
