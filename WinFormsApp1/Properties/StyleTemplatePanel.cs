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

            listBoxTemplates.DrawMode = DrawMode.OwnerDrawFixed;
            listBoxTemplates.DrawItem += ListBoxTemplates_DrawItem;

            foreach (var template in Templates)
            {
                listBoxTemplates.Items.Add(template.Name);
            }
        }

        private void ListBoxTemplates_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0 || e.Index >= Templates.Count) return;

            var template = Templates[e.Index];

            e.DrawBackground();
            e.Graphics.FillRectangle(
                e.State.HasFlag(DrawItemState.Selected)
                    ? SystemBrushes.Highlight
                    : new SolidBrush(template.BackgroundColor),
                e.Bounds);

            using (Brush textBrush = new SolidBrush(template.TextColor))
            {
                e.Graphics.DrawString(
                    template.Name,
                    template.Font,
                    textBrush,
                    e.Bounds.Location);
            }

            e.DrawFocusRectangle();
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
    }
}
