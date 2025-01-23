using System.Drawing.Printing;
using System.Drawing.Text;
using System.IO;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using GetStartedProject.Properties;


namespace WinFormsApp1
{
    public partial class WordPad : Form
    {
        public string open_path = "";
        public WordPad()
        {
            InitializeComponent();
            List<string> colorList = new List<string>();
            int sumRGB;
            saveFileDialog1.Filter = "Text File(*.txt)|*.txt|TM Wordpad File (*.tm)|*.tm";
            InstalledFontCollection fonts = new InstalledFontCollection();
            foreach (FontFamily family in fonts.Families)
            {
                FBox.Items.Add(family.Name);
            }
            for (int i = 4; i < 100; i += 2)
                SzBox.Items.Add(i);

            foreach (System.Reflection.PropertyInfo prop in typeof(Color).GetProperties())
            {
                if (prop.PropertyType.FullName == "System.Drawing.Color")
                {
                    colorList.Add(prop.Name);
                }
            }


            foreach (string color in colorList)
            {
                ColBox.DropDownItems.Add(color);
            }
            for (int i = 0; i < ColBox.DropDownItems.Count; i++)
            {

                KnownColor selectedColor;
                selectedColor = (KnownColor)System.Enum.Parse(typeof(KnownColor), colorList[i]);
                ColBox.DropDownItems[i].BackColor = Color.FromKnownColor(selectedColor);


                Color col = Color.FromName(colorList[i]);



                sumRGB = ConvertToRGB(col);
                if (sumRGB <= 382)
                {
                    ColBox.DropDownItems[i].ForeColor = Color.White;
                }
                else if (sumRGB > 382)
                {
                    ColBox.DropDownItems[i].ForeColor = Color.Black;
                }
            }
        }

        private int ConvertToRGB(System.Drawing.Color c)
        {
            int r = c.R,
                g = c.G,
                b = c.B;
            int sum = 0;


            sum = r + g + b;

            return sum;
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (!string.IsNullOrEmpty(open_path))
                {
                    
                    File.WriteAllText(open_path, richTextBox1.Text);
                    MessageBox.Show("File was saved sucsessfully");
                }
                else
                {
                    
                    saveAsToolStripMenuItem_Click(sender, e);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Error of saving file!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
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



        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void backgroundColorSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog2.ShowDialog();
            richTextBox1.BackColor = colorDialog2.Color;
        }

        private void toolStripComboBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            using(var findtext = new FindForm())
            {
                if(findtext.ShowDialog() == DialogResult.OK)
                {
                    FindText(findtext.Text);
                }
            }
        }

        private void FBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(FBox.Text, richTextBox1.SelectionFont.Size);
        }

        private void SzBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, Convert.ToInt16(SzBox.Text));
        }
        private void ColBox_DropDownItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {
            KnownColor selectedColor;
            selectedColor = (KnownColor)System.Enum.Parse(typeof(KnownColor), e.ClickedItem.Text);
            richTextBox1.SelectionColor = Color.FromKnownColor(selectedColor);
            ColBox.BackColor = Color.FromKnownColor(selectedColor);
        }

        private void AlignLeftButton_Click(object sender, EventArgs e)
        {
            AlignCenterButton.Checked = false;
            AlignRightButton.Checked = false;
            AlignLeftButton.Checked = true;
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void AlignCenterButton_Click(object sender, EventArgs e)
        {
            AlignCenterButton.Checked = true;
            AlignRightButton.Checked = false;
            AlignLeftButton.Checked = false;
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void RightAlignment_Click(object sender, EventArgs e)
        {
            AlignCenterButton.Checked = false;
            AlignRightButton.Checked = true;
            AlignLeftButton.Checked = false;
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void BoldButton_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont is null)
                return;

            BoldButton.Checked = !BoldButton.Checked;


            FontStyle style = richTextBox1.SelectionFont.Style;

            if (richTextBox1.SelectionFont.Bold)
                style &= ~FontStyle.Bold;
            else
                style |= FontStyle.Bold;

            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);
        }

        private void ItalicButton_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont is null)
                return;

            ItalicButton.Checked = !ItalicButton.Checked;


            FontStyle style = richTextBox1.SelectionFont.Style;

            if (richTextBox1.SelectionFont.Bold)
                style &= ~FontStyle.Italic;
            else
                style |= FontStyle.Italic;

            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);
        }

        private void FindText(string searchText)
        {
            if (!string.IsNullOrEmpty(searchText))
            {
                int startIndex = 0;
                while (startIndex < richTextBox1.TextLength)
                {
                    
                    int foundIndex = richTextBox1.Find(searchText, startIndex, RichTextBoxFinds.None);
                    if (foundIndex != -1)
                    {
                        
                        richTextBox1.SelectionStart = foundIndex;
                        richTextBox1.SelectionLength = searchText.Length;
                        richTextBox1.SelectionBackColor = Color.Yellow; 
                        startIndex = foundIndex + searchText.Length;
                    }
                    else
                    {
                        break; 
                    }
                }
            }
        }


        private void UnderlinedButton_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont is null)
                return;

            UnderlinedButton.Checked = !UnderlinedButton.Checked;


            FontStyle style = richTextBox1.SelectionFont.Style;

            if (richTextBox1.SelectionFont.Bold)
                style &= ~FontStyle.Underline;
            else
                style |= FontStyle.Underline;

            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(var newfile = new CreateFileForm())
            {
                if(newfile.ShowDialog(this) == DialogResult.OK)
                {
                    File.Create(newfile.FileName + ".tm").Close();
                }
            }
        }
    }
}
