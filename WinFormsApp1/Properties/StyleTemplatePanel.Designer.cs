namespace GetStartedProject.Properties
{
    partial class StyleTemplatePanel
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
            btnAdd = new Button();
            listBoxTemplates = new ListBox();
            btnApply = new Button();
            btnDelete = new Button();
            txtTemplateName = new TextBox();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // listBoxTemplates
            // 
            listBoxTemplates.FormattingEnabled = true;
            listBoxTemplates.ItemHeight = 25;
            listBoxTemplates.Location = new Point(12, 61);
            listBoxTemplates.Name = "listBoxTemplates";
            listBoxTemplates.Size = new Size(349, 379);
            listBoxTemplates.TabIndex = 1;
            // 
            // btnApply
            // 
            btnApply.Location = new Point(131, 12);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(112, 34);
            btnApply.TabIndex = 2;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(249, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtTemplateName
            // 
            txtTemplateName.Location = new Point(12, 448);
            txtTemplateName.Name = "txtTemplateName";
            txtTemplateName.Size = new Size(349, 31);
            txtTemplateName.TabIndex = 4;
            // 
            // StyleTemplatePanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 491);
            Controls.Add(txtTemplateName);
            Controls.Add(btnDelete);
            Controls.Add(btnApply);
            Controls.Add(listBoxTemplates);
            Controls.Add(btnAdd);
            Name = "StyleTemplatePanel";
            Text = "Font Style Templates";
            Load += StyleTemplatePanel_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private ListBox listBoxTemplates;
        private Button btnApply;
        private Button btnDelete;
        private TextBox txtTemplateName;
    }
}