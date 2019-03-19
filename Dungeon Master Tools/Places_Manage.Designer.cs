namespace Dungeon_Master_Tools
{
    partial class Places_Manage
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
            this.listViewPlaces = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderParent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.comboBoxFilterParent = new System.Windows.Forms.ComboBox();
            this.txtPlace_id = new System.Windows.Forms.TextBox();
            this.txtParentLocation = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblPlaceId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblParent = new System.Windows.Forms.Label();
            this.lblFilterParent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewPlaces
            // 
            this.listViewPlaces.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listViewPlaces.AutoArrange = false;
            this.listViewPlaces.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderParent});
            this.listViewPlaces.FullRowSelect = true;
            this.listViewPlaces.GridLines = true;
            this.listViewPlaces.Location = new System.Drawing.Point(12, 12);
            this.listViewPlaces.Name = "listViewPlaces";
            this.listViewPlaces.Size = new System.Drawing.Size(400, 359);
            this.listViewPlaces.TabIndex = 0;
            this.listViewPlaces.UseCompatibleStateImageBehavior = false;
            this.listViewPlaces.View = System.Windows.Forms.View.Details;
            this.listViewPlaces.SelectedIndexChanged += new System.EventHandler(this.listViewPlaces_SelectedIndexChanged);
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 200;
            // 
            // columnHeaderParent
            // 
            this.columnHeaderParent.Text = "Parent Location";
            this.columnHeaderParent.Width = 200;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(582, 390);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(491, 390);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(139, 390);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // comboBoxFilterParent
            // 
            this.comboBoxFilterParent.FormattingEnabled = true;
            this.comboBoxFilterParent.Location = new System.Drawing.Point(12, 390);
            this.comboBoxFilterParent.Name = "comboBoxFilterParent";
            this.comboBoxFilterParent.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFilterParent.TabIndex = 4;
            this.comboBoxFilterParent.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilterParent_SelectedIndexChanged);
            // 
            // txtPlace_id
            // 
            this.txtPlace_id.Location = new System.Drawing.Point(501, 12);
            this.txtPlace_id.Name = "txtPlace_id";
            this.txtPlace_id.Size = new System.Drawing.Size(156, 20);
            this.txtPlace_id.TabIndex = 5;
            // 
            // txtParentLocation
            // 
            this.txtParentLocation.Location = new System.Drawing.Point(501, 68);
            this.txtParentLocation.Name = "txtParentLocation";
            this.txtParentLocation.Size = new System.Drawing.Size(156, 20);
            this.txtParentLocation.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(501, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(156, 20);
            this.txtName.TabIndex = 7;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(501, 94);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(156, 97);
            this.txtDescription.TabIndex = 8;
            // 
            // lblPlaceId
            // 
            this.lblPlaceId.AutoSize = true;
            this.lblPlaceId.Location = new System.Drawing.Point(418, 15);
            this.lblPlaceId.Name = "lblPlaceId";
            this.lblPlaceId.Size = new System.Drawing.Size(51, 13);
            this.lblPlaceId.TabIndex = 9;
            this.lblPlaceId.Text = "Place_ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(418, 41);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Name";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(418, 97);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 11;
            this.lblDescription.Text = "Description";
            // 
            // lblParent
            // 
            this.lblParent.AutoSize = true;
            this.lblParent.Location = new System.Drawing.Point(418, 71);
            this.lblParent.Name = "lblParent";
            this.lblParent.Size = new System.Drawing.Size(82, 13);
            this.lblParent.TabIndex = 12;
            this.lblParent.Text = "Parent Location";
            // 
            // lblFilterParent
            // 
            this.lblFilterParent.AutoSize = true;
            this.lblFilterParent.Location = new System.Drawing.Point(12, 374);
            this.lblFilterParent.Name = "lblFilterParent";
            this.lblFilterParent.Size = new System.Drawing.Size(121, 13);
            this.lblFilterParent.TabIndex = 13;
            this.lblFilterParent.Text = "Filter by Parent Location";
            // 
            // Places_Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 421);
            this.Controls.Add(this.lblFilterParent);
            this.Controls.Add(this.lblParent);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPlaceId);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtParentLocation);
            this.Controls.Add(this.txtPlace_id);
            this.Controls.Add(this.comboBoxFilterParent);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.listViewPlaces);
            this.Name = "Places_Manage";
            this.Text = "Places_Manage";
            this.Load += new System.EventHandler(this.Places_Manage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewPlaces;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox comboBoxFilterParent;
        private System.Windows.Forms.TextBox txtPlace_id;
        private System.Windows.Forms.TextBox txtParentLocation;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblPlaceId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblParent;
        private System.Windows.Forms.Label lblFilterParent;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderParent;
    }
}