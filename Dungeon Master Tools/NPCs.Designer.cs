namespace Dungeon_Master_Tools
{
    partial class NPCs
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
            listViewNPCs = new System.Windows.Forms.ListView();
            columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeaderHomeCity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeaderOccupation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            comboBoxPrimaryFilter = new System.Windows.Forms.ComboBox();
            comboBoxSecondaryFilter = new System.Windows.Forms.ComboBox();
            lblPrimaryFilter = new System.Windows.Forms.Label();
            lblSecondaryFilter = new System.Windows.Forms.Label();
            lblName = new System.Windows.Forms.Label();
            lblHomeCity = new System.Windows.Forms.Label();
            lblOccupation = new System.Windows.Forms.Label();
            lblDescription = new System.Windows.Forms.Label();
            txtName = new System.Windows.Forms.TextBox();
            txtDescription = new System.Windows.Forms.TextBox();
            btnOpenOrganization = new System.Windows.Forms.Button();
            txtHomeCity = new System.Windows.Forms.TextBox();
            txtOccupation = new System.Windows.Forms.TextBox();
            btnDelete = new System.Windows.Forms.Button();
            btnRefresh = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            txtNpcID = new System.Windows.Forms.TextBox();
            lblNpcID = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // listViewNPCs
            // 
            listViewNPCs.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            listViewNPCs.AutoArrange = false;
            listViewNPCs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeaderName,
            columnHeaderHomeCity,
            columnHeaderOccupation});
            listViewNPCs.FullRowSelect = true;
            listViewNPCs.GridLines = true;
            listViewNPCs.Location = new System.Drawing.Point(12, 12);
            listViewNPCs.Name = "listViewNPCs";
            listViewNPCs.Size = new System.Drawing.Size(486, 385);
            listViewNPCs.TabIndex = 0;
            listViewNPCs.UseCompatibleStateImageBehavior = false;
            listViewNPCs.View = System.Windows.Forms.View.Details;
            listViewNPCs.SelectedIndexChanged += new System.EventHandler(listViewNPCs_SelectedIndexChanged);
            // 
            // columnHeaderName
            // 
            columnHeaderName.Text = "Name";
            columnHeaderName.Width = 162;
            // 
            // columnHeaderHomeCity
            // 
            columnHeaderHomeCity.Text = "HomeCity";
            columnHeaderHomeCity.Width = 162;
            // 
            // columnHeaderOccupation
            // 
            columnHeaderOccupation.Text = "Occupation";
            columnHeaderOccupation.Width = 162;
            // 
            // comboBoxPrimaryFilter
            // 
            comboBoxPrimaryFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            comboBoxPrimaryFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            comboBoxPrimaryFilter.FormattingEnabled = true;
            comboBoxPrimaryFilter.Location = new System.Drawing.Point(12, 417);
            comboBoxPrimaryFilter.Name = "comboBoxPrimaryFilter";
            comboBoxPrimaryFilter.Size = new System.Drawing.Size(121, 21);
            comboBoxPrimaryFilter.TabIndex = 1;
            comboBoxPrimaryFilter.SelectedIndexChanged += new System.EventHandler(comboBoxPrimaryFilter_SelectedIndexChanged);
            // 
            // comboBoxSecondaryFilter
            // 
            comboBoxSecondaryFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            comboBoxSecondaryFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            comboBoxSecondaryFilter.FormattingEnabled = true;
            comboBoxSecondaryFilter.Location = new System.Drawing.Point(139, 417);
            comboBoxSecondaryFilter.Name = "comboBoxSecondaryFilter";
            comboBoxSecondaryFilter.Size = new System.Drawing.Size(121, 21);
            comboBoxSecondaryFilter.TabIndex = 2;
            comboBoxSecondaryFilter.SelectedIndexChanged += new System.EventHandler(comboBoxSecondaryFilter_SelectedIndexChanged);
            // 
            // lblPrimaryFilter
            // 
            lblPrimaryFilter.AutoSize = true;
            lblPrimaryFilter.Location = new System.Drawing.Point(12, 401);
            lblPrimaryFilter.Name = "lblPrimaryFilter";
            lblPrimaryFilter.Size = new System.Drawing.Size(66, 13);
            lblPrimaryFilter.TabIndex = 3;
            lblPrimaryFilter.Text = "Primary Filter";
            // 
            // lblSecondaryFilter
            // 
            lblSecondaryFilter.AutoSize = true;
            lblSecondaryFilter.Location = new System.Drawing.Point(139, 400);
            lblSecondaryFilter.Name = "lblSecondaryFilter";
            lblSecondaryFilter.Size = new System.Drawing.Size(83, 13);
            lblSecondaryFilter.TabIndex = 4;
            lblSecondaryFilter.Text = "Secondary Filter";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new System.Drawing.Point(507, 41);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(35, 13);
            lblName.TabIndex = 5;
            lblName.Text = "Name";
            // 
            // lblHomeCity
            // 
            lblHomeCity.AutoSize = true;
            lblHomeCity.Location = new System.Drawing.Point(507, 67);
            lblHomeCity.Name = "lblHomeCity";
            lblHomeCity.Size = new System.Drawing.Size(55, 13);
            lblHomeCity.TabIndex = 6;
            lblHomeCity.Text = "Home City";
            // 
            // lblOccupation
            // 
            lblOccupation.AutoSize = true;
            lblOccupation.Location = new System.Drawing.Point(507, 93);
            lblOccupation.Name = "lblOccupation";
            lblOccupation.Size = new System.Drawing.Size(62, 13);
            lblOccupation.TabIndex = 7;
            lblOccupation.Text = "Occupation";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new System.Drawing.Point(507, 119);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new System.Drawing.Size(60, 13);
            lblDescription.TabIndex = 8;
            lblDescription.Text = "Description";
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(576, 38);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(190, 20);
            txtName.TabIndex = 9;
            // 
            // txtDescription
            // 
            txtDescription.Location = new System.Drawing.Point(576, 116);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new System.Drawing.Size(190, 127);
            txtDescription.TabIndex = 10;
            // 
            // btnOpenOrganization
            // 
            btnOpenOrganization.Location = new System.Drawing.Point(498, 415);
            btnOpenOrganization.Name = "btnOpenOrganization";
            btnOpenOrganization.Size = new System.Drawing.Size(106, 23);
            btnOpenOrganization.TabIndex = 13;
            btnOpenOrganization.Text = "Open Organization";
            btnOpenOrganization.UseVisualStyleBackColor = true;
            btnOpenOrganization.Click += new System.EventHandler(btnOpenOrganization_Click);
            // 
            // txtHomeCity
            // 
            txtHomeCity.Location = new System.Drawing.Point(576, 64);
            txtHomeCity.Name = "txtHomeCity";
            txtHomeCity.Size = new System.Drawing.Size(190, 20);
            txtHomeCity.TabIndex = 14;
            // 
            // txtOccupation
            // 
            txtOccupation.Location = new System.Drawing.Point(576, 90);
            txtOccupation.Name = "txtOccupation";
            txtOccupation.Size = new System.Drawing.Size(190, 20);
            txtOccupation.TabIndex = 15;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(691, 417);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(75, 23);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += new System.EventHandler(btnDelete_Click);
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new System.Drawing.Point(269, 415);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new System.Drawing.Size(75, 23);
            btnRefresh.TabIndex = 17;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += new System.EventHandler(btnRefresh_Click);
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(610, 415);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(75, 23);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += new System.EventHandler(btnAdd_Click);
            // 
            // txtNpcID
            // 
            txtNpcID.Location = new System.Drawing.Point(576, 12);
            txtNpcID.Name = "txtNpcID";
            txtNpcID.Size = new System.Drawing.Size(190, 20);
            txtNpcID.TabIndex = 19;
            // 
            // lblNpcID
            // 
            lblNpcID.AutoSize = true;
            lblNpcID.Location = new System.Drawing.Point(507, 15);
            lblNpcID.Name = "lblNpcID";
            lblNpcID.Size = new System.Drawing.Size(43, 13);
            lblNpcID.TabIndex = 20;
            lblNpcID.Text = "NPC ID";
            // 
            // NPCs
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(778, 450);
            Controls.Add(lblNpcID);
            Controls.Add(txtNpcID);
            Controls.Add(btnAdd);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(txtOccupation);
            Controls.Add(txtHomeCity);
            Controls.Add(btnOpenOrganization);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(lblDescription);
            Controls.Add(lblOccupation);
            Controls.Add(lblHomeCity);
            Controls.Add(lblName);
            Controls.Add(lblSecondaryFilter);
            Controls.Add(lblPrimaryFilter);
            Controls.Add(comboBoxSecondaryFilter);
            Controls.Add(comboBoxPrimaryFilter);
            Controls.Add(listViewNPCs);
            Name = "NPCs";
            Text = "NPCs";
            Load += new System.EventHandler(NPCs_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewNPCs;
        private System.Windows.Forms.ComboBox comboBoxPrimaryFilter;
        private System.Windows.Forms.ComboBox comboBoxSecondaryFilter;
        private System.Windows.Forms.Label lblPrimaryFilter;
        private System.Windows.Forms.Label lblSecondaryFilter;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblHomeCity;
        private System.Windows.Forms.Label lblOccupation;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnOpenOrganization;
        private System.Windows.Forms.TextBox txtHomeCity;
        private System.Windows.Forms.TextBox txtOccupation;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtNpcID;
        private System.Windows.Forms.Label lblNpcID;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderHomeCity;
        private System.Windows.Forms.ColumnHeader columnHeaderOccupation;
    }
}