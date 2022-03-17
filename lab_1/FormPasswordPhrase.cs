using System;
using System.Windows.Forms;

namespace InfSec
{
    public partial class FormPasswordPhrase : Form
    {
        public string passPhrase;

        public FormPasswordPhrase()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            passPhrase = textBoxPassPhrase.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
