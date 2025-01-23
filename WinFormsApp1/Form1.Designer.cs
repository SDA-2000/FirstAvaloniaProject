namespace WinFormsApp1
{
    partial class WordPad
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordPad));
            richTextBox1 = new RichTextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            copyToolStripMenuItem1 = new ToolStripMenuItem();
            pastToolStripMenuItem1 = new ToolStripMenuItem();
            cutToolStripMenuItem1 = new ToolStripMenuItem();
            selectAllToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pastToolStripMenuItem = new ToolStripMenuItem();
            cutToolStripMenuItem = new ToolStripMenuItem();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            fontsToolStripMenuItem = new ToolStripMenuItem();
            fontSettingsToolStripMenuItem = new ToolStripMenuItem();
            colorsToolStripMenuItem = new ToolStripMenuItem();
            fontColorSettingsToolStripMenuItem = new ToolStripMenuItem();
            backgroundColorSettingsToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            imageToolStripMenuItem = new ToolStripMenuItem();
            linkToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            fontDialog1 = new FontDialog();
            colorDialog1 = new ColorDialog();
            panel1 = new Panel();
            toolStrip1 = new ToolStrip();
            FBox = new ToolStripComboBox();
            SzBox = new ToolStripComboBox();
            ColBox = new ToolStripDropDownButton();
            AlignLeftButton = new ToolStripButton();
            AlignCenterButton = new ToolStripButton();
            AlignRightButton = new ToolStripButton();
            BoldButton = new ToolStripButton();
            ItalicButton = new ToolStripButton();
            UnderlinedButton = new ToolStripButton();
            colorDialog2 = new ColorDialog();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.FixedSingle;
            richTextBox1.ContextMenuStrip = contextMenuStrip1;
            richTextBox1.Cursor = Cursors.IBeam;
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(940, 554);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            richTextBox1.MouseUp += richTextBox1_MouseUp;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { copyToolStripMenuItem1, pastToolStripMenuItem1, cutToolStripMenuItem1, selectAllToolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(121, 92);
            // 
            // copyToolStripMenuItem1
            // 
            copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            copyToolStripMenuItem1.Size = new Size(120, 22);
            copyToolStripMenuItem1.Text = "Copy";
            copyToolStripMenuItem1.Click += copyToolStripMenuItem1_Click;
            // 
            // pastToolStripMenuItem1
            // 
            pastToolStripMenuItem1.Name = "pastToolStripMenuItem1";
            pastToolStripMenuItem1.Size = new Size(120, 22);
            pastToolStripMenuItem1.Text = "Paste";
            pastToolStripMenuItem1.Click += pastToolStripMenuItem1_Click;
            // 
            // cutToolStripMenuItem1
            // 
            cutToolStripMenuItem1.Name = "cutToolStripMenuItem1";
            cutToolStripMenuItem1.Size = new Size(120, 22);
            cutToolStripMenuItem1.Text = "Cut";
            cutToolStripMenuItem1.Click += cutToolStripMenuItem1_Click;
            // 
            // selectAllToolStripMenuItem1
            // 
            selectAllToolStripMenuItem1.Name = "selectAllToolStripMenuItem1";
            selectAllToolStripMenuItem1.Size = new Size(120, 22);
            selectAllToolStripMenuItem1.Text = "Select all";
            selectAllToolStripMenuItem1.Click += selectAllToolStripMenuItem1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, fontsToolStripMenuItem, colorsToolStripMenuItem, toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(940, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(180, 22);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(180, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(180, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(180, 22);
            saveAsToolStripMenuItem.Text = "Save as...";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { copyToolStripMenuItem, pastToolStripMenuItem, cutToolStripMenuItem, selectAllToolStripMenuItem, toolStripMenuItem2, toolStripMenuItem3 });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(180, 22);
            copyToolStripMenuItem.Text = "Copy";
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // pastToolStripMenuItem
            // 
            pastToolStripMenuItem.Name = "pastToolStripMenuItem";
            pastToolStripMenuItem.Size = new Size(180, 22);
            pastToolStripMenuItem.Text = "Paste";
            pastToolStripMenuItem.Click += pastToolStripMenuItem_Click;
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.Size = new Size(180, 22);
            cutToolStripMenuItem.Text = "Cut";
            cutToolStripMenuItem.Click += cutToolStripMenuItem_Click;
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.Size = new Size(180, 22);
            selectAllToolStripMenuItem.Text = "Select all";
            selectAllToolStripMenuItem.Click += selectAllToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(180, 22);
            toolStripMenuItem2.Text = "Find";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(180, 22);
            toolStripMenuItem3.Text = "Change";
            // 
            // fontsToolStripMenuItem
            // 
            fontsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fontSettingsToolStripMenuItem });
            fontsToolStripMenuItem.Name = "fontsToolStripMenuItem";
            fontsToolStripMenuItem.Size = new Size(48, 20);
            fontsToolStripMenuItem.Text = "Fonts";
            // 
            // fontSettingsToolStripMenuItem
            // 
            fontSettingsToolStripMenuItem.Name = "fontSettingsToolStripMenuItem";
            fontSettingsToolStripMenuItem.Size = new Size(180, 22);
            fontSettingsToolStripMenuItem.Text = "Font Settings";
            fontSettingsToolStripMenuItem.Click += fontSettingsToolStripMenuItem_Click;
            // 
            // colorsToolStripMenuItem
            // 
            colorsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fontColorSettingsToolStripMenuItem, backgroundColorSettingsToolStripMenuItem });
            colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            colorsToolStripMenuItem.Size = new Size(53, 20);
            colorsToolStripMenuItem.Text = "Colors";
            // 
            // fontColorSettingsToolStripMenuItem
            // 
            fontColorSettingsToolStripMenuItem.Name = "fontColorSettingsToolStripMenuItem";
            fontColorSettingsToolStripMenuItem.Size = new Size(212, 22);
            fontColorSettingsToolStripMenuItem.Text = "Font Color Settings";
            fontColorSettingsToolStripMenuItem.Click += fontColorSettingsToolStripMenuItem_Click;
            // 
            // backgroundColorSettingsToolStripMenuItem
            // 
            backgroundColorSettingsToolStripMenuItem.Name = "backgroundColorSettingsToolStripMenuItem";
            backgroundColorSettingsToolStripMenuItem.Size = new Size(212, 22);
            backgroundColorSettingsToolStripMenuItem.Text = "Background ColorSettings";
            backgroundColorSettingsToolStripMenuItem.Click += backgroundColorSettingsToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { imageToolStripMenuItem, linkToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(55, 20);
            toolStripMenuItem1.Text = "Import";
            // 
            // imageToolStripMenuItem
            // 
            imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            imageToolStripMenuItem.Size = new Size(180, 22);
            imageToolStripMenuItem.Text = "Image";
            imageToolStripMenuItem.Click += imageToolStripMenuItem_Click;
            // 
            // linkToolStripMenuItem
            // 
            linkToolStripMenuItem.Name = "linkToolStripMenuItem";
            linkToolStripMenuItem.Size = new Size(180, 22);
            linkToolStripMenuItem.Text = "Link";
            linkToolStripMenuItem.Click += linkToolStripMenuItem_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            panel1.Controls.Add(richTextBox1);
            panel1.Location = new Point(0, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(940, 554);
            panel1.TabIndex = 2;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = SystemColors.AppWorkspace;
            toolStrip1.Items.AddRange(new ToolStripItem[] { FBox, SzBox, ColBox, AlignLeftButton, AlignCenterButton, AlignRightButton, BoldButton, ItalicButton, UnderlinedButton });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(940, 25);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // FBox
            // 
            FBox.Name = "FBox";
            FBox.Size = new Size(121, 25);
            FBox.Text = "Select font...";
            FBox.SelectedIndexChanged += FBox_SelectedIndexChanged;
            FBox.Click += toolStripComboBox1_Click_1;
            // 
            // SzBox
            // 
            SzBox.Name = "SzBox";
            SzBox.Size = new Size(121, 25);
            SzBox.Text = "Select size...";
            SzBox.SelectedIndexChanged += SzBox_SelectedIndexChanged;
            // 
            // ColBox
            // 
            ColBox.Name = "ColBox";
            ColBox.Size = new Size(90, 22);
            ColBox.Text = "Select color...";
            ColBox.DropDownItemClicked += ColBox_DropDownItemClicked_1;
            // 
            // AlignLeftButton
            // 
            AlignLeftButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            AlignLeftButton.Image = (Image)resources.GetObject("AlignLeftButton.Image");
            AlignLeftButton.ImageTransparentColor = Color.Magenta;
            AlignLeftButton.Name = "AlignLeftButton";
            AlignLeftButton.Size = new Size(23, 22);
            AlignLeftButton.Text = "toolStripButton1";
            AlignLeftButton.Click += AlignLeftButton_Click;
            // 
            // AlignCenterButton
            // 
            AlignCenterButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            AlignCenterButton.Image = (Image)resources.GetObject("AlignCenterButton.Image");
            AlignCenterButton.ImageTransparentColor = Color.Magenta;
            AlignCenterButton.Name = "AlignCenterButton";
            AlignCenterButton.Size = new Size(23, 22);
            AlignCenterButton.Text = "toolStripButton1";
            AlignCenterButton.Click += AlignCenterButton_Click;
            // 
            // AlignRightButton
            // 
            AlignRightButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            AlignRightButton.Image = (Image)resources.GetObject("AlignRightButton.Image");
            AlignRightButton.ImageTransparentColor = Color.Magenta;
            AlignRightButton.Name = "AlignRightButton";
            AlignRightButton.Size = new Size(23, 22);
            AlignRightButton.Text = "toolStripButton1";
            AlignRightButton.Click += RightAlignment_Click;
            // 
            // BoldButton
            // 
            BoldButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BoldButton.Image = (Image)resources.GetObject("BoldButton.Image");
            BoldButton.ImageTransparentColor = Color.Magenta;
            BoldButton.Name = "BoldButton";
            BoldButton.Size = new Size(23, 22);
            BoldButton.Text = "toolStripButton1";
            BoldButton.Click += BoldButton_Click;
            // 
            // ItalicButton
            // 
            ItalicButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ItalicButton.Image = (Image)resources.GetObject("ItalicButton.Image");
            ItalicButton.ImageTransparentColor = Color.Magenta;
            ItalicButton.Name = "ItalicButton";
            ItalicButton.Size = new Size(23, 22);
            ItalicButton.Text = "toolStripButton1";
            ItalicButton.Click += ItalicButton_Click;
            // 
            // UnderlinedButton
            // 
            UnderlinedButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            UnderlinedButton.Image = (Image)resources.GetObject("UnderlinedButton.Image");
            UnderlinedButton.ImageTransparentColor = Color.Magenta;
            UnderlinedButton.Name = "UnderlinedButton";
            UnderlinedButton.Size = new Size(23, 22);
            UnderlinedButton.Text = "toolStripButton1";
            UnderlinedButton.Click += UnderlinedButton_Click;
            // 
            // WordPad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(940, 601);
            Controls.Add(toolStrip1);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            ForeColor = Color.Transparent;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "WordPad";
            Text = "TMPad";
            Load += WordPad_Load;
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pastToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ToolStripMenuItem fontsToolStripMenuItem;
        private ToolStripMenuItem fontSettingsToolStripMenuItem;
        private FontDialog fontDialog1;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem copyToolStripMenuItem1;
        private ToolStripMenuItem pastToolStripMenuItem1;
        private ToolStripMenuItem cutToolStripMenuItem1;
        private ToolStripMenuItem selectAllToolStripMenuItem1;
        private ColorDialog colorDialog1;
        private ToolStripMenuItem colorsToolStripMenuItem;
        private ToolStripMenuItem fontColorSettingsToolStripMenuItem;
        private Panel panel1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem imageToolStripMenuItem;
        private ToolStripMenuItem linkToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripComboBox FBox;
        private ToolStripMenuItem backgroundColorSettingsToolStripMenuItem;
        private ColorDialog colorDialog2;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripComboBox SzBox;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripDropDownButton ColBox;
        private ToolStripButton AlignLeftButton;
        private ToolStripButton AlignCenterButton;
        private ToolStripButton AlignRightButton;
        private ToolStripButton BoldButton;
        private ToolStripButton ItalicButton;
        private ToolStripButton UnderlinedButton;
    }
}
