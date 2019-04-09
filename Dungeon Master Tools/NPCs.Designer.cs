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
            this.listViewNPCs = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderHomeCity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderOccupation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxPrimaryFilter = new System.Windows.Forms.ComboBox();
            this.comboBoxSecondaryFilter = new System.Windows.Forms.ComboBox();
            this.lblPrimaryFilter = new System.Windows.Forms.Label();
            this.lblSecondaryFilter = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblHomeCity = new System.Windows.Forms.Label();
            this.lblOccupation = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnOpenOrganization = new System.Windows.Forms.Button();
            this.txtHomeCity = new System.Windows.Forms.TextBox();
            this.txtOccupation = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtNpcID = new System.Windows.Forms.TextBox();
            this.lblNpcID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewNPCs
            // 
            this.listViewNPCs.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listViewNPCs.AutoArrange = false;
            this.listViewNPCs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderHomeCity,
            this.columnHeaderOccupation});
            this.listViewNPCs.FullRowSelect = true;
            this.listViewNPCs.GridLines = true;
            this.listViewNPCs.Location = new System.Drawing.Point(12, 12);
            this.listViewNPCs.Name = "listViewNPCs";
            this.listViewNPCs.Size = new System.Drawing.Size(486, 385);
            this.listViewNPCs.TabIndex = 0;
            this.listViewNPCs.UseCompatibleStateImageBehavior = false;
            this.listViewNPCs.View = System.Windows.Forms.View.Details;
            this.listViewNPCs.SelectedIndexChanged += new System.EventHandler(this.listViewNPCs_SelectedIndexChanged);
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 162;
            // 
            // columnHeaderHomeCity
            // 
            this.columnHeaderHomeCity.Text = "HomeCity";
            this.columnHeaderHomeCity.Width = 162;
            // 
            // columnHeaderOccupation
            // 
            this.columnHeaderOccupation.Text = "Occupation";
            this.columnHeaderOccupation.Width = 162;
            // 
            // comboBoxPrimaryFilter
            // 
            this.comboBoxPrimaryFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxPrimaryFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxPrimaryFilter.FormattingEnabled = true;
            this.comboBoxPrimaryFilter.Location = new System.Drawing.Point(12, 417);
            this.comboBoxPrimaryFilter.Name = "comboBoxPrimaryFilter";
            this.comboBoxPrimaryFilter.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPrimaryFilter.TabIndex = 1;
            this.comboBoxPrimaryFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxPrimaryFilter_SelectedIndexChanged);
            // 
            // comboBoxSecondaryFilter
            // 
            this.comboBoxSecondaryFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxSecondaryFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxSecondaryFilter.FormattingEnabled = true;
            this.comboBoxSecondaryFilter.Location = new System.Drawing.Point(139, 417);
            this.comboBoxSecondaryFilter.Name = "comboBoxSecondaryFilter";
            this.comboBoxSecondaryFilter.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSecondaryFilter.TabIndex = 2;
            this.comboBoxSecondaryFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxSecondaryFilter_SelectedIndexChanged);
            // 
            // lblPrimaryFilter
            // 
            this.lblPrimaryFilter.AutoSize = true;
            this.lblPrimaryFilter.Location = new System.Drawing.Point(12, 401);
            this.lblPrimaryFilter.Name = "lblPrimaryFilter";
            this.lblPrimaryFilter.Size = new System.Drawing.Size(66, 13);
            this.lblPrimaryFilter.TabIndex = 3;
            this.lblPrimaryFilter.Text = "Primary Filter";
            // 
            // lblSecondaryFilter
            // 
            this.lblSecondaryFilter.AutoSize = true;
            this.lblSecondaryFilter.Location = new System.Drawing.Point(139, 400);
            this.lblSecondaryFilter.Name = "lblSecondaryFilter";
            this.lblSecondaryFilter.Size = new System.Drawing.Size(83, 13);
            this.lblSecondaryFilter.TabIndex = 4;
            this.lblSecondaryFilter.Text = "Secondary Filter";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(507, 41);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name";
            // 
            // lblHomeCity
            // 
            this.lblHomeCity.AutoSize = true;
            this.lblHomeCity.Location = new System.Drawing.Point(507, 67);
            this.lblHomeCity.Name = "lblHomeCity";
            this.lblHomeCity.Size = new System.Drawing.Size(55, 13);
            this.lblHomeCity.TabIndex = 6;
            this.lblHomeCity.Text = "Home City";
            // 
            // lblOccupation
            // 
            this.lblOccupation.AutoSize = true;
            this.lblOccupation.Location = new System.Drawing.Point(507, 93);
            this.lblOccupation.Name = "lblOccupation";
            this.lblOccupation.Size = new System.Drawing.Size(62, 13);
            this.lblOccupation.TabIndex = 7;
            this.lblOccupation.Text = "Occupation";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(507, 119);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "Description";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(576, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(190, 20);
            this.txtName.TabIndex = 9;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(576, 116);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(190, 127);
            this.txtDescription.TabIndex = 10;
            // 
            // btnOpenOrganization
            // 
            this.btnOpenOrganization.Location = new System.Drawing.Point(498, 415);
            this.btnOpenOrganization.Name = "btnOpenOrganization";
            this.btnOpenOrganization.Size = new System.Drawing.Size(106, 23);
            this.btnOpenOrganization.TabIndex = 13;
            this.btnOpenOrganization.Text = "Open Organization";
            this.btnOpenOrganization.UseVisualStyleBackColor = true;
            this.btnOpenOrganization.Click += new System.EventHandler(this.btnOpenOrganization_Click);
            // 
            // txtHomeCity
            // 
            this.txtHomeCity.Location = new System.Drawing.Point(576, 64);
            this.txtHomeCity.Name = "txtHomeCity";
            this.txtHomeCity.Size = new System.Drawing.Size(190, 20);
            this.txtHomeCity.TabIndex = 14;
            // 
            // txtOccupation
            // 
            this.txtOccupation.Location = new System.Drawing.Point(576, 90);
            this.txtOccupation.Name = "txtOccupation";
            this.txtOccupation.Size = new System.Drawing.Size(190, 20);
            this.txtOccupation.TabIndex = 15;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(691, 417);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(269, 415);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(610, 415);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtNpcID
            // 
            this.txtNpcID.Location = new System.Drawing.Point(576, 12);
            this.txtNpcID.Name = "txtNpcID";
            this.txtNpcID.Size = new System.Drawing.Size(190, 20);
            this.txtNpcID.TabIndex = 19;
            // 
            // lblNpcID
            // 
            this.lblNpcID.AutoSize = true;
            this.lblNpcID.Location = new System.Drawing.Point(507, 15);
            this.lblNpcID.Name = "lblNpcID";
            this.lblNpcID.Size = new System.Drawing.Size(43, 13);
            this.lblNpcID.TabIndex = 20;
            this.lblNpcID.Text = "NPC ID";
            // 
            // NPCs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 450);
            this.Controls.Add(this.lblNpcID);
            this.Controls.Add(this.txtNpcID);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtOccupation);
            this.Controls.Add(this.txtHomeCity);
            this.Controls.Add(this.btnOpenOrganization);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblOccupation);
            this.Controls.Add(this.lblHomeCity);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblSecondaryFilter);
            this.Controls.Add(this.lblPrimaryFilter);
            this.Controls.Add(this.comboBoxSecondaryFilter);
            this.Controls.Add(this.comboBoxPrimaryFilter);
            this.Controls.Add(this.listViewNPCs);
            this.Name = "NPCs";
            this.Text = "NPCs";
            this.Load += new System.EventHandler(this.NPCs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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