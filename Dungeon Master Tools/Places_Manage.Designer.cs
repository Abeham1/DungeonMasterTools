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
            listViewPlaces = new System.Windows.Forms.ListView();
            columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeaderParent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            btnDelete = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            btnRefresh = new System.Windows.Forms.Button();
            comboBoxFilterParent = new System.Windows.Forms.ComboBox();
            txtPlace_id = new System.Windows.Forms.TextBox();
            txtParentLocation = new System.Windows.Forms.TextBox();
            txtName = new System.Windows.Forms.TextBox();
            txtDescription = new System.Windows.Forms.TextBox();
            lblPlaceId = new System.Windows.Forms.Label();
            lblName = new System.Windows.Forms.Label();
            lblDescription = new System.Windows.Forms.Label();
            lblParent = new System.Windows.Forms.Label();
            lblFilterParent = new System.Windows.Forms.Label();
            btnSave = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // listViewPlaces
            // 
            listViewPlaces.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            listViewPlaces.AutoArrange = false;
            listViewPlaces.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeaderName,
            columnHeaderParent});
            listViewPlaces.FullRowSelect = true;
            listViewPlaces.GridLines = true;
            listViewPlaces.Location = new System.Drawing.Point(12, 12);
            listViewPlaces.Name = "listViewPlaces";
            listViewPlaces.Size = new System.Drawing.Size(400, 359);
            listViewPlaces.TabIndex = 0;
            listViewPlaces.UseCompatibleStateImageBehavior = false;
            listViewPlaces.View = System.Windows.Forms.View.Details;
            listViewPlaces.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(listViewPlaces_ColumnClick);
            listViewPlaces.SelectedIndexChanged += new System.EventHandler(listViewPlaces_SelectedIndexChanged);
            // 
            // columnHeaderName
            // 
            columnHeaderName.Text = "Name";
            columnHeaderName.Width = 200;
            // 
            // columnHeaderParent
            // 
            columnHeaderParent.Text = "Parent Location";
            columnHeaderParent.Width = 200;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(582, 390);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(75, 23);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += new System.EventHandler(btnDelete_Click);
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(491, 390);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(75, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += new System.EventHandler(btnAdd_Click);
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new System.Drawing.Point(139, 390);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new System.Drawing.Size(75, 23);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += new System.EventHandler(btnRefresh_Click);
            // 
            // comboBoxFilterParent
            // 
            comboBoxFilterParent.FormattingEnabled = true;
            comboBoxFilterParent.Location = new System.Drawing.Point(12, 390);
            comboBoxFilterParent.Name = "comboBoxFilterParent";
            comboBoxFilterParent.Size = new System.Drawing.Size(121, 21);
            comboBoxFilterParent.TabIndex = 4;
            comboBoxFilterParent.SelectedIndexChanged += new System.EventHandler(comboBoxFilterParent_SelectedIndexChanged);
            // 
            // txtPlace_id
            // 
            txtPlace_id.Location = new System.Drawing.Point(501, 12);
            txtPlace_id.Name = "txtPlace_id";
            txtPlace_id.Size = new System.Drawing.Size(156, 20);
            txtPlace_id.TabIndex = 5;
            // 
            // txtParentLocation
            // 
            txtParentLocation.Location = new System.Drawing.Point(501, 68);
            txtParentLocation.Name = "txtParentLocation";
            txtParentLocation.Size = new System.Drawing.Size(156, 20);
            txtParentLocation.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(501, 38);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(156, 20);
            txtName.TabIndex = 7;
            // 
            // txtDescription
            // 
            txtDescription.Location = new System.Drawing.Point(501, 94);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new System.Drawing.Size(156, 97);
            txtDescription.TabIndex = 8;
            // 
            // lblPlaceId
            // 
            lblPlaceId.AutoSize = true;
            lblPlaceId.Location = new System.Drawing.Point(418, 15);
            lblPlaceId.Name = "lblPlaceId";
            lblPlaceId.Size = new System.Drawing.Size(51, 13);
            lblPlaceId.TabIndex = 9;
            lblPlaceId.Text = "Place_ID";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new System.Drawing.Point(418, 41);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(35, 13);
            lblName.TabIndex = 10;
            lblName.Text = "Name";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new System.Drawing.Point(418, 97);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new System.Drawing.Size(60, 13);
            lblDescription.TabIndex = 11;
            lblDescription.Text = "Description";
            // 
            // lblParent
            // 
            lblParent.AutoSize = true;
            lblParent.Location = new System.Drawing.Point(418, 71);
            lblParent.Name = "lblParent";
            lblParent.Size = new System.Drawing.Size(82, 13);
            lblParent.TabIndex = 12;
            lblParent.Text = "Parent Location";
            // 
            // lblFilterParent
            // 
            lblFilterParent.AutoSize = true;
            lblFilterParent.Location = new System.Drawing.Point(12, 374);
            lblFilterParent.Name = "lblFilterParent";
            lblFilterParent.Size = new System.Drawing.Size(121, 13);
            lblFilterParent.TabIndex = 13;
            lblFilterParent.Text = "Filter by Parent Location";
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(501, 198);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(75, 23);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += new System.EventHandler(btnSave_Click);
            // 
            // Places_Manage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(679, 421);
            Controls.Add(btnSave);
            Controls.Add(lblFilterParent);
            Controls.Add(lblParent);
            Controls.Add(lblDescription);
            Controls.Add(lblName);
            Controls.Add(lblPlaceId);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(txtParentLocation);
            Controls.Add(txtPlace_id);
            Controls.Add(comboBoxFilterParent);
            Controls.Add(btnRefresh);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(listViewPlaces);
            Name = "Places_Manage";
            Text = "Places_Manage";
            Load += new System.EventHandler(Places_Manage_Load);
            ResumeLayout(false);
            PerformLayout();

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
        private System.Windows.Forms.Button btnSave;
    }
}