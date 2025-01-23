namespace GetStartedProject.Properties
{
    partial class CreateFileForm
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
            Name = new Label();
            textBox1 = new TextBox();
            OKButton = new Button();
            SuspendLayout();
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Location = new Point(12, 9);
            Name.Name = "Name";
            Name.Size = new Size(92, 15);
            Name.TabIndex = 0;
            Name.Text = "Name of the file";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(191, 23);
            textBox1.TabIndex = 1;
            // 
            // OKButton
            // 
            OKButton.Location = new Point(209, 27);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(75, 23);
            OKButton.TabIndex = 2;
            OKButton.Text = "Create";
            OKButton.UseVisualStyleBackColor = true;
            OKButton.Click += OKButton_Click;
            // 
            // CreateFileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 62);
            Controls.Add(OKButton);
            Controls.Add(textBox1);
            Controls.Add(Name);
            Text = "Create File";
            Load += CreateFileForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Name;
        private TextBox textBox1;
        private Button OKButton;
    }
}