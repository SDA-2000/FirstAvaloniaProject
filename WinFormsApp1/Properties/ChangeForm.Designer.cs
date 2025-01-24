namespace GetStartedProject.Properties
{
    partial class ChangeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeForm));
            label1 = new Label();
            KeyBox = new TextBox();
            label2 = new Label();
            ChangeBox = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "Text to change";
            // 
            // KeyBox
            // 
            KeyBox.Location = new Point(12, 27);
            KeyBox.Name = "KeyBox";
            KeyBox.Size = new Size(181, 23);
            KeyBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 2;
            label2.Text = "Change text";
            // 
            // ChangeBox
            // 
            ChangeBox.Location = new Point(12, 71);
            ChangeBox.Name = "ChangeBox";
            ChangeBox.Size = new Size(181, 23);
            ChangeBox.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(201, 85);
            button1.Name = "button1";
            button1.Size = new Size(60, 23);
            button1.TabIndex = 4;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ChangeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(273, 120);
            Controls.Add(button1);
            Controls.Add(ChangeBox);
            Controls.Add(label2);
            Controls.Add(KeyBox);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ChangeForm";
            Text = "Change text";
            Load += ChangeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox KeyBox;
        private Label label2;
        private TextBox ChangeBox;
        private Button button1;
    }
}