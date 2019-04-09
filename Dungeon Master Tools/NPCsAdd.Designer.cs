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
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblHomeCity = new System.Windows.Forms.Label();
            this.lblOccupation = new System.Windows.Forms.Label();
            this.comboBoxHomeCity = new System.Windows.Forms.ComboBox();
            this.comboBoxOccupation = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 95);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description";
            // 
            // lblHomeCity
            // 
            this.lblHomeCity.AutoSize = true;
            this.lblHomeCity.Location = new System.Drawing.Point(12, 41);
            this.lblHomeCity.Name = "lblHomeCity";
            this.lblHomeCity.Size = new System.Drawing.Size(55, 13);
            this.lblHomeCity.TabIndex = 2;
            this.lblHomeCity.Text = "Home City";
            // 
            // lblOccupation
            // 
            this.lblOccupation.AutoSize = true;
            this.lblOccupation.Location = new System.Drawing.Point(12, 68);
            this.lblOccupation.Name = "lblOccupation";
            this.lblOccupation.Size = new System.Drawing.Size(62, 13);
            this.lblOccupation.TabIndex = 3;
            this.lblOccupation.Text = "Occupation";
            // 
            // comboBoxHomeCity
            // 
            this.comboBoxHomeCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxHomeCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxHomeCity.FormattingEnabled = true;
            this.comboBoxHomeCity.Location = new System.Drawing.Point(110, 38);
            this.comboBoxHomeCity.Name = "comboBoxHomeCity";
            this.comboBoxHomeCity.Size = new System.Drawing.Size(154, 21);
            this.comboBoxHomeCity.TabIndex = 2;
            // 
            // comboBoxOccupation
            // 
            this.comboBoxOccupation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxOccupation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxOccupation.FormattingEnabled = true;
            this.comboBoxOccupation.Location = new System.Drawing.Point(110, 65);
            this.comboBoxOccupation.Name = "comboBoxOccupation";
            this.comboBoxOccupation.Size = new System.Drawing.Size(154, 21);
            this.comboBoxOccupation.TabIndex = 3;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(110, 92);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(154, 99);
            this.txtDescription.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(110, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(154, 20);
            this.txtName.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(110, 198);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // NPCsAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 240);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.comboBoxOccupation);
            this.Controls.Add(this.comboBoxHomeCity);
            this.Controls.Add(this.lblOccupation);
            this.Controls.Add(this.lblHomeCity);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblName);
            this.Name = "NPCsAdd";
            this.Text = "NPCsAdd";
            this.Load += new System.EventHandler(this.NPCsAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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