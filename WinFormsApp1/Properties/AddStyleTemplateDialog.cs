using GetStartedProject.Models;
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
    public partial class AddStyleTemplateDialog : Form
    {
        public TextStyleTemplate SelectedTemplate { get; set; }

        public AddStyleTemplateDialog()
        {
            InitializeComponent();
            textColorLabel.BackColor = Color.Black;
            highlightColorLabel.BackColor = Color.Transparent;
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            using (FontDialog fontDialog = new FontDialog())
            {
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    fontParameter.Font = fontDialog.Font;
                    fontParameter.Text = fontDialog.ToString();
                }
            }
        }

        private void btnTextColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    textColorLabel.BackColor = colorDialog.Color;
                }
            }
        }

        private void btnHighlightColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    highlightColorLabel.BackColor = colorDialog.Color;
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(templateName.Text) ||
                string.IsNullOrEmpty(fontParameter.Text))
            {
                MessageBox.Show("Введите все параметры шаблона");
                return;
            }

            SelectedTemplate = new TextStyleTemplate(
                templateName.Text,
                fontParameter.Font,
                textColorLabel.BackColor,
                highlightColorLabel.BackColor
            );

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnChancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
