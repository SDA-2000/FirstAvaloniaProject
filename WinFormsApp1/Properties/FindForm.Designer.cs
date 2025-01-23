namespace GetStartedProject.Properties
{
    partial class FindForm
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
            KeyBox = new TextBox();
            label1 = new Label();
            OKButton = new Button();
            SuspendLayout();
            // 
            // KeyBox
            // 
            KeyBox.Location = new Point(12, 27);
            KeyBox.Name = "KeyBox";
            KeyBox.Size = new Size(219, 23);
            KeyBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 1;
            label1.Text = "Keywords";
            // 
            // OKButton
            // 
            OKButton.Location = new Point(237, 27);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(57, 23);
            OKButton.TabIndex = 2;
            OKButton.Text = "OK";
            OKButton.UseVisualStyleBackColor = true;
            OKButton.Click += OKButton_Click;
            // 
            // FindForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(306, 62);
            Controls.Add(OKButton);
            Controls.Add(label1);
            Controls.Add(KeyBox);
            Name = "FindForm";
            Text = "Find text";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox KeyBox;
        private Label label1;
        private Button OKButton;
    }
}