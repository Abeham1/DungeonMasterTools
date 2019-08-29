namespace Dungeon_Master_Tools
{
    partial class NPCsAdd
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
            lblName = new System.Windows.Forms.Label();
            lblDescription = new System.Windows.Forms.Label();
            lblHomeCity = new System.Windows.Forms.Label();
            lblOccupation = new System.Windows.Forms.Label();
            comboBoxHomeCity = new System.Windows.Forms.ComboBox();
            comboBoxOccupation = new System.Windows.Forms.ComboBox();
            txtDescription = new System.Windows.Forms.TextBox();
            txtName = new System.Windows.Forms.TextBox();
            btnSubmit = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new System.Drawing.Point(12, 15);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(35, 13);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new System.Drawing.Point(12, 95);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new System.Drawing.Size(60, 13);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Description";
            // 
            // lblHomeCity
            // 
            lblHomeCity.AutoSize = true;
            lblHomeCity.Location = new System.Drawing.Point(12, 41);
            lblHomeCity.Name = "lblHomeCity";
            lblHomeCity.Size = new System.Drawing.Size(55, 13);
            lblHomeCity.TabIndex = 2;
            lblHomeCity.Text = "Home City";
            // 
            // lblOccupation
            // 
            lblOccupation.AutoSize = true;
            lblOccupation.Location = new System.Drawing.Point(12, 68);
            lblOccupation.Name = "lblOccupation";
            lblOccupation.Size = new System.Drawing.Size(62, 13);
            lblOccupation.TabIndex = 3;
            lblOccupation.Text = "Occupation";
            // 
            // comboBoxHomeCity
            // 
            comboBoxHomeCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            comboBoxHomeCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            comboBoxHomeCity.FormattingEnabled = true;
            comboBoxHomeCity.Location = new System.Drawing.Point(110, 38);
            comboBoxHomeCity.Name = "comboBoxHomeCity";
            comboBoxHomeCity.Size = new System.Drawing.Size(154, 21);
            comboBoxHomeCity.TabIndex = 2;
            // 
            // comboBoxOccupation
            // 
            comboBoxOccupation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            comboBoxOccupation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            comboBoxOccupation.FormattingEnabled = true;
            comboBoxOccupation.Location = new System.Drawing.Point(110, 65);
            comboBoxOccupation.Name = "comboBoxOccupation";
            comboBoxOccupation.Size = new System.Drawing.Size(154, 21);
            comboBoxOccupation.TabIndex = 3;
            // 
            // txtDescription
            // 
            txtDescription.Location = new System.Drawing.Point(110, 92);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new System.Drawing.Size(154, 99);
            txtDescription.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(110, 12);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(154, 20);
            txtName.TabIndex = 1;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new System.Drawing.Point(110, 198);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new System.Drawing.Size(75, 23);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += new System.EventHandler(btnSubmit_Click);
            // 
            // NPCsAdd
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(277, 240);
            Controls.Add(btnSubmit);
            Controls.Add(txtName);
            Controls.Add(txtDescription);
            Controls.Add(comboBoxOccupation);
            Controls.Add(comboBoxHomeCity);
            Controls.Add(lblOccupation);
            Controls.Add(lblHomeCity);
            Controls.Add(lblDescription);
            Controls.Add(lblName);
            Name = "NPCsAdd";
            Text = "NPCsAdd";
            Load += new System.EventHandler(NPCsAdd_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblHomeCity;
        private System.Windows.Forms.Label lblOccupation;
        private System.Windows.Forms.ComboBox comboBoxHomeCity;
        private System.Windows.Forms.ComboBox comboBoxOccupation;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSubmit;
    }
}