using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetStartedProject.Properties
{
    public partial class FindForm : Form
    {
        public FindForm()
        {
            InitializeComponent();
        }

        public string KeyText => KeyBox.Text;

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(KeyBox.Text))
            {
                DialogResult = DialogResult.OK;
            }
            else MessageBox.Show("Please, type keywords", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
