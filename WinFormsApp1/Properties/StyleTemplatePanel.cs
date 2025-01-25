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
    public partial class StyleTemplatePanel : Form
    {

        public List<TextStyleTemplate> Templates { get; private set; }
        public TextStyleTemplate SelectedTemplate { get; private set; }

        public StyleTemplatePanel(List<TextStyleTemplate> templates)
        {
            InitializeComponent();
            Templates = templates;

            foreach (var template in Templates)
            {
                listBoxTemplates.Items.Add(template.Name);
            }
        }

        private void StyleTemplatePanel_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (AddStyleTemplateDialog dialog = new AddStyleTemplateDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var newTemplate = dialog.SelectedTemplate;
                    Templates.Add(newTemplate);
                    listBoxTemplates.Items.Add(newTemplate.Name);
                }
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (listBoxTemplates.SelectedIndex != -1)
            {
                SelectedTemplate = Templates[listBoxTemplates.SelectedIndex];
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Выберите шаблон для применения.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBoxTemplates.SelectedIndex != -1)
            {
                int index = listBoxTemplates.SelectedIndex;
                Templates.RemoveAt(index);
                listBoxTemplates.Items.RemoveAt(index);
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {

        }
    }
}
