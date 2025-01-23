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
    public partial class LinkAddForm : Form
    {
        public LinkAddForm()
        {
            InitializeComponent();
        }

        public string LinkName => URLNameTBox.Text;
        public string LinkUrl => URLTBox.Text;

        private void OKbutton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(URLTBox.Text) && !string.IsNullOrEmpty(URLNameTBox.Text))
            {
                DialogResult = DialogResult.OK;
            }
            else MessageBox.Show("Please, type name and link", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LinkAddForm_Load(object sender, EventArgs e)
        {

        }
    }
}
