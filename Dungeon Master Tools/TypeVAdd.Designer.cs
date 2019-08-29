namespace Dungeon_Master_Tools
{
    partial class TypeVAdd
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
            txtCategory = new System.Windows.Forms.TextBox();
            lblCategory = new System.Windows.Forms.Label();
            lblDescription = new System.Windows.Forms.Label();
            txtDescription = new System.Windows.Forms.TextBox();
            btnSubmit = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // txtCategory
            // 
            txtCategory.Location = new System.Drawing.Point(78, 12);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new System.Drawing.Size(153, 20);
            txtCategory.TabIndex = 0;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new System.Drawing.Point(12, 15);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new System.Drawing.Size(49, 13);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Category";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new System.Drawing.Point(12, 41);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new System.Drawing.Size(60, 13);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.Location = new System.Drawing.Point(78, 38);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new System.Drawing.Size(153, 98);
            txtDescription.TabIndex = 4;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new System.Drawing.Point(165, 147);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new System.Drawing.Size(75, 23);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += new System.EventHandler(btnSubmit_Click);
            // 
            // TypeVAdd
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(252, 182);
            Controls.Add(btnSubmit);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(lblCategory);
            Controls.Add(txtCategory);
            Name = "TypeVAdd";
            Text = "TypeVAdd";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnSubmit;
    }
}