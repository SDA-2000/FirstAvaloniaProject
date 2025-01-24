namespace GetStartedProject.Properties
{
    partial class LinkAddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LinkAddForm));
            OKbutton = new Button();
            NameLinkLab = new Label();
            URLNameTBox = new TextBox();
            URLTBox = new TextBox();
            LinkLab = new Label();
            SuspendLayout();
            // 
            // OKbutton
            // 
            OKbutton.Location = new Point(258, 93);
            OKbutton.Name = "OKbutton";
            OKbutton.Size = new Size(51, 23);
            OKbutton.TabIndex = 0;
            OKbutton.Text = "OK";
            OKbutton.UseVisualStyleBackColor = true;
            OKbutton.Click += OKbutton_Click;
            // 
            // NameLinkLab
            // 
            NameLinkLab.AutoSize = true;
            NameLinkLab.Location = new Point(12, 9);
            NameLinkLab.Name = "NameLinkLab";
            NameLinkLab.Size = new Size(79, 15);
            NameLinkLab.TabIndex = 1;
            NameLinkLab.Text = "Name for link";
            // 
            // URLNameTBox
            // 
            URLNameTBox.Location = new Point(12, 27);
            URLNameTBox.Name = "URLNameTBox";
            URLNameTBox.Size = new Size(240, 23);
            URLNameTBox.TabIndex = 2;
            // 
            // URLTBox
            // 
            URLTBox.Location = new Point(12, 76);
            URLTBox.Name = "URLTBox";
            URLTBox.Size = new Size(240, 23);
            URLTBox.TabIndex = 3;
            // 
            // LinkLab
            // 
            LinkLab.AutoSize = true;
            LinkLab.Location = new Point(12, 58);
            LinkLab.Name = "LinkLab";
            LinkLab.Size = new Size(29, 15);
            LinkLab.TabIndex = 4;
            LinkLab.Text = "Link";
            // 
            // LinkAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 128);
            Controls.Add(LinkLab);
            Controls.Add(URLTBox);
            Controls.Add(URLNameTBox);
            Controls.Add(NameLinkLab);
            Controls.Add(OKbutton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LinkAddForm";
            Text = "Link import";
            Load += LinkAddForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OKbutton;
        private Label NameLinkLab;
        private TextBox URLNameTBox;
        private TextBox URLTBox;
        private Label LinkLab;
    }
}