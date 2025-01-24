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
    public partial class ChangeForm : Form
    {
        public string KeyText => KeyBox.Text;
        public string ChangeText => ChangeBox.Text;

        public ChangeForm()
        {
            InitializeComponent();
        }

        private void ChangeForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(KeyBox.Text) && !string.IsNullOrEmpty(ChangeBox.Text))
            {
                DialogResult = DialogResult.OK;
            }
            else MessageBox.Show("Please, type change values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
