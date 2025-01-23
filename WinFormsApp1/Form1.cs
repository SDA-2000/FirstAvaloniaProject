using System.Drawing.Printing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using GetStartedProject.Properties;


namespace WinFormsApp1
{
    public partial class WordPad : Form
    {
        public WordPad()
        {
            InitializeComponent();
            saveFileDialog1.Filter = "Text File(*.txt)|*.txt|TM Wordpad File (*.tm)|*.tm";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            richTextBox1.SaveFile(filename, RichTextBoxStreamType.RichText);
            MessageBox.Show("File saved!");

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            richTextBox1.LoadFile(filename, RichTextBoxStreamType.RichText);
            MessageBox.Show("File opened!");
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0)
            {
                richTextBox1.Copy();
            }

        }

        private void pastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0)
            {
                richTextBox1.Paste();
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0)
            {
                richTextBox1.Cut();
            }
        }

        private void fontSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.SelectionFont = fontDialog1.Font;
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0)
            {
                richTextBox1.SelectAll();
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void richTextBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                richTextBox1.ContextMenuStrip = contextMenuStrip1;
            }
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0)
            {
                richTextBox1.Copy();
            }
        }

        private void pastToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0)
            {
                richTextBox1.Paste();
            }
        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0)
            {
                richTextBox1.Cut();
            }
        }

        private void selectAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0)
            {
                richTextBox1.SelectAll();
            }
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void WordPad_Load(object sender, EventArgs e)
        {
        }

        private void fontColorSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.SelectionColor = colorDialog1.Color;
        }

        private void linkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var linkform = new LinkAddForm())
            {
                if (linkform.ShowDialog() == DialogResult.OK)
                {
                    string name = linkform.LinkName;
                    string url = linkform.LinkUrl;

                    int currentPos = richTextBox1.TextLength;
                    richTextBox1.AppendText(name + ": " + url + "\n");

                    richTextBox1.Select(currentPos, url.Length + name.Length + 2);
                    richTextBox1.SelectionColor = System.Drawing.Color.Blue;
                    richTextBox1.SelectionFont = new System.Drawing.Font(richTextBox1.Font, System.Drawing.FontStyle.Underline);
                    richTextBox1.SelectionStart = richTextBox1.Text.Length;
                    richTextBox1.SelectionLength = 0;

                    richTextBox1.LinkClicked += (sender2, e2) =>
                    {
                        if (e2.LinkText == url)
                        {
                            try
                            {
                                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                                {
                                    FileName = url,
                                    UseShellExecute = true
                                });
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Не удалось открыть ссылку: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    };
                }
            }
        }

        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"; 

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    Image image = Image.FromFile(openFileDialog.FileName);
                    Clipboard.Clear();
                    Clipboard.SetImage(image);
                    richTextBox1.Paste();
                    Clipboard.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string text = richTextBox1.Text;

            Font font = new Font("Arial", 12);
            Brush brush = Brushes.Black;

            float yPos = e.MarginBounds.Top;
            int linesPerPage = (int)(e.MarginBounds.Height / font.GetHeight(e.Graphics));

            int linesPrinted = 0;
            while (linesPrinted < linesPerPage && text.Length > 0)
            {
                string line = text;
                if (line.Length > 0)
                {
                    e.Graphics.DrawString(line, font, brush, e.MarginBounds.Left, yPos);
                    linesPrinted++;
                    yPos += font.GetHeight(e.Graphics);
                    text = text.Substring(line.Length);
                }
            }
            e.HasMorePages = text.Length > 0;
        }
    }
}
