namespace GetStartedProject.Properties
{
    partial class AddStyleTemplateDialog
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
            btnChancel = new Button();
            btnOK = new Button();
            label1 = new Label();
            templateName = new TextBox();
            label2 = new Label();
            textColorLabel = new Label();
            btnTextColor = new Button();
            label4 = new Label();
            highlightColorLabel = new Label();
            btnHighlightColor = new Button();
            label3 = new Label();
            fontParameter = new TextBox();
            btnFont = new Button();
            SuspendLayout();
            // 
            // btnChancel
            // 
            btnChancel.Location = new Point(12, 362);
            btnChancel.Name = "btnChancel";
            btnChancel.Size = new Size(112, 34);
            btnChancel.TabIndex = 0;
            btnChancel.Text = "Chancel";
            btnChancel.UseVisualStyleBackColor = true;
            btnChancel.Click += btnChancel_Click;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(170, 362);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(112, 34);
            btnOK.TabIndex = 1;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(166, 25);
            label1.TabIndex = 2;
            label1.Text = "Name for template:";
            // 
            // templateName
            // 
            templateName.Location = new Point(12, 37);
            templateName.Name = "templateName";
            templateName.Size = new Size(270, 31);
            templateName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 167);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 4;
            label2.Text = "Text Color:";
            // 
            // textColorLabel
            // 
            textColorLabel.AutoSize = true;
            textColorLabel.Location = new Point(12, 202);
            textColorLabel.Name = "textColorLabel";
            textColorLabel.Size = new Size(212, 25);
            textColorLabel.TabIndex = 5;
            textColorLabel.Text = "                                        ";
            // 
            // btnTextColor
            // 
            btnTextColor.Location = new Point(238, 197);
            btnTextColor.Name = "btnTextColor";
            btnTextColor.Size = new Size(44, 34);
            btnTextColor.TabIndex = 6;
            btnTextColor.Text = "▼";
            btnTextColor.UseVisualStyleBackColor = true;
            btnTextColor.Click += btnTextColor_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 237);
            label4.Name = "label4";
            label4.Size = new Size(137, 25);
            label4.TabIndex = 7;
            label4.Text = "Highlight Color:";
            // 
            // highlightColorLabel
            // 
            highlightColorLabel.AutoSize = true;
            highlightColorLabel.Location = new Point(12, 274);
            highlightColorLabel.Name = "highlightColorLabel";
            highlightColorLabel.Size = new Size(212, 25);
            highlightColorLabel.TabIndex = 8;
            highlightColorLabel.Text = "                                        ";
            // 
            // btnHighlightColor
            // 
            btnHighlightColor.Location = new Point(238, 269);
            btnHighlightColor.Name = "btnHighlightColor";
            btnHighlightColor.Size = new Size(44, 34);
            btnHighlightColor.TabIndex = 9;
            btnHighlightColor.Text = "▼";
            btnHighlightColor.UseVisualStyleBackColor = true;
            btnHighlightColor.Click += btnHighlightColor_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 85);
            label3.Name = "label3";
            label3.Size = new Size(146, 25);
            label3.TabIndex = 10;
            label3.Text = "Font parameters:";
            // 
            // fontParameter
            // 
            fontParameter.Location = new Point(12, 125);
            fontParameter.Name = "fontParameter";
            fontParameter.ReadOnly = true;
            fontParameter.Size = new Size(212, 31);
            fontParameter.TabIndex = 11;
            // 
            // btnFont
            // 
            btnFont.Location = new Point(238, 125);
            btnFont.Name = "btnFont";
            btnFont.Size = new Size(44, 34);
            btnFont.TabIndex = 12;
            btnFont.Text = "▼";
            btnFont.UseVisualStyleBackColor = true;
            btnFont.Click += btnFont_Click;
            // 
            // AddStyleTemplateDialog
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 408);
            Controls.Add(btnFont);
            Controls.Add(fontParameter);
            Controls.Add(label3);
            Controls.Add(btnHighlightColor);
            Controls.Add(highlightColorLabel);
            Controls.Add(label4);
            Controls.Add(btnTextColor);
            Controls.Add(textColorLabel);
            Controls.Add(label2);
            Controls.Add(templateName);
            Controls.Add(label1);
            Controls.Add(btnOK);
            Controls.Add(btnChancel);
            Name = "AddStyleTemplateDialog";
            Text = "New Font Style Template";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnChancel;
        private Button btnOK;
        private Label label1;
        private TextBox templateName;
        private Label label2;
        private Label textColorLabel;
        private Button btnTextColor;
        private Label label4;
        private Label highlightColorLabel;
        private Button btnHighlightColor;
        private Label label3;
        private TextBox fontParameter;
        private Button btnFont;
    }
}