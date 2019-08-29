namespace Dungeon_Master_Tools
{
    partial class TYPE_VManage
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
            listViewTypeV = new System.Windows.Forms.ListView();
            headerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            headerCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            comboBoxCategory = new System.Windows.Forms.ComboBox();
            lblCategory = new System.Windows.Forms.Label();
            lblCategoryAdd = new System.Windows.Forms.Label();
            lblDescription = new System.Windows.Forms.Label();
            txtCategory = new System.Windows.Forms.TextBox();
            txtDescription = new System.Windows.Forms.TextBox();
            btnAdd = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            txtType_ID = new System.Windows.Forms.TextBox();
            lblType_ID = new System.Windows.Forms.Label();
            btnRefresh = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // listViewTypeV
            // 
            listViewTypeV.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            listViewTypeV.AutoArrange = false;
            listViewTypeV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            headerName,
            headerCategory});
            listViewTypeV.FullRowSelect = true;
            listViewTypeV.GridLines = true;
            listViewTypeV.Location = new System.Drawing.Point(12, 12);
            listViewTypeV.Name = "listViewTypeV";
            listViewTypeV.Size = new System.Drawing.Size(400, 386);
            listViewTypeV.TabIndex = 0;
            listViewTypeV.UseCompatibleStateImageBehavior = false;
            listViewTypeV.View = System.Windows.Forms.View.Details;
            listViewTypeV.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(listViewTypeV_ColumnClick);
            listViewTypeV.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(listViewTypeV_ItemSelectionChanged);
            // 
            // headerName
            // 
            headerName.Text = "Name";
            headerName.Width = 200;
            // 
            // headerCategory
            // 
            headerCategory.Text = "Category";
            headerCategory.Width = 200;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new System.Drawing.Point(12, 417);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new System.Drawing.Size(121, 21);
            comboBoxCategory.TabIndex = 1;
            comboBoxCategory.SelectedIndexChanged += new System.EventHandler(comboBoxCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new System.Drawing.Point(12, 401);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new System.Drawing.Size(49, 13);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Category";
            // 
            // lblCategoryAdd
            // 
            lblCategoryAdd.AutoSize = true;
            lblCategoryAdd.Location = new System.Drawing.Point(430, 41);
            lblCategoryAdd.Name = "lblCategoryAdd";
            lblCategoryAdd.Size = new System.Drawing.Size(49, 13);
            lblCategoryAdd.TabIndex = 4;
            lblCategoryAdd.Text = "Category";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new System.Drawing.Point(430, 64);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new System.Drawing.Size(60, 13);
            lblDescription.TabIndex = 5;
            lblDescription.Text = "Description";
            // 
            // txtCategory
            // 
            txtCategory.Location = new System.Drawing.Point(496, 38);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new System.Drawing.Size(177, 20);
            txtCategory.TabIndex = 7;
            // 
            // txtDescription
            // 
            txtDescription.Location = new System.Drawing.Point(496, 64);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new System.Drawing.Size(177, 119);
            txtDescription.TabIndex = 8;
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(517, 415);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(75, 23);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += new System.EventHandler(btnAdd_Click);
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(598, 415);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(75, 23);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += new System.EventHandler(btnDelete_Click);
            // 
            // txtType_ID
            // 
            txtType_ID.Location = new System.Drawing.Point(496, 12);
            txtType_ID.Name = "txtType_ID";
            txtType_ID.Size = new System.Drawing.Size(177, 20);
            txtType_ID.TabIndex = 11;
            // 
            // lblType_ID
            // 
            lblType_ID.AutoSize = true;
            lblType_ID.Location = new System.Drawing.Point(430, 15);
            lblType_ID.Name = "lblType_ID";
            lblType_ID.Size = new System.Drawing.Size(52, 13);
            lblType_ID.TabIndex = 12;
            lblType_ID.Text = "TYPE_ID";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new System.Drawing.Point(337, 415);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new System.Drawing.Size(75, 23);
            btnRefresh.TabIndex = 13;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += new System.EventHandler(btnRefresh_Click);
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(496, 190);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(75, 23);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += new System.EventHandler(btnSave_Click);
            // 
            // TYPE_VManage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(685, 450);
            Controls.Add(btnSave);
            Controls.Add(btnRefresh);
            Controls.Add(lblType_ID);
            Controls.Add(txtType_ID);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtDescription);
            Controls.Add(txtCategory);
            Controls.Add(lblDescription);
            Controls.Add(lblCategoryAdd);
            Controls.Add(lblCategory);
            Controls.Add(comboBoxCategory);
            Controls.Add(listViewTypeV);
            Name = "TYPE_VManage";
            Text = "Manage the TYPE_V table";
            Load += new System.EventHandler(TYPE_VManage_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewTypeV;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblCategoryAdd;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ColumnHeader headerName;
        private System.Windows.Forms.ColumnHeader headerCategory;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtType_ID;
        private System.Windows.Forms.Label lblType_ID;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSave;
    }
}