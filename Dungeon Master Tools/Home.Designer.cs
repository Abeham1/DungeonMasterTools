namespace Dungeon_Master_Tools
{
    partial class Home
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
            this.homePanel = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.playersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.combatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.explorationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPlaces = new System.Windows.Forms.ToolStripMenuItem();
            this.socialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNPCs = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemTYPE_VManage = new System.Windows.Forms.ToolStripMenuItem();
            this.homePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // homePanel
            // 
            this.homePanel.BackgroundImage = global::Dungeon_Master_Tools.Properties.Resources.dragon1;
            this.homePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homePanel.Controls.Add(this.pictureBox1);
            this.homePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homePanel.Location = new System.Drawing.Point(0, 42);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(800, 408);
            this.homePanel.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::Dungeon_Master_Tools.Properties.Resources.close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(759, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 42);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Dungeon_Master_Tools.Properties.Resources.dungeonsAndDragonsLogo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(678, 349);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 46);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::Dungeon_Master_Tools.Properties.Resources.buttonGradient;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.playersToolStripMenuItem,
            this.combatToolStripMenuItem,
            this.explorationToolStripMenuItem,
            this.socialToolStripMenuItem,
            this.databaseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MinimumSize = new System.Drawing.Size(800, 42);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(59, 38);
            this.toolStripMenuItem1.Text = "Tools";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(107, 26);
            this.toolStripMenuItem2.Text = "Exit";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // playersToolStripMenuItem
            // 
            this.playersToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.playersToolStripMenuItem.Name = "playersToolStripMenuItem";
            this.playersToolStripMenuItem.Size = new System.Drawing.Size(74, 38);
            this.playersToolStripMenuItem.Text = "Players";
            // 
            // combatToolStripMenuItem
            // 
            this.combatToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.combatToolStripMenuItem.Name = "combatToolStripMenuItem";
            this.combatToolStripMenuItem.Size = new System.Drawing.Size(89, 38);
            this.combatToolStripMenuItem.Text = "Combat";
            // 
            // explorationToolStripMenuItem
            // 
            this.explorationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemPlaces});
            this.explorationToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.explorationToolStripMenuItem.Name = "explorationToolStripMenuItem";
            this.explorationToolStripMenuItem.Size = new System.Drawing.Size(109, 38);
            this.explorationToolStripMenuItem.Text = "Exploration";
            // 
            // menuItemPlaces
            // 
            this.menuItemPlaces.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuItemPlaces.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuItemPlaces.Name = "menuItemPlaces";
            this.menuItemPlaces.Size = new System.Drawing.Size(284, 26);
            this.menuItemPlaces.Text = "Manage Places Database";
            this.menuItemPlaces.Click += new System.EventHandler(this.menuItemPlaces_Click);
            // 
            // socialToolStripMenuItem
            // 
            this.socialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNPCs});
            this.socialToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.socialToolStripMenuItem.Name = "socialToolStripMenuItem";
            this.socialToolStripMenuItem.Size = new System.Drawing.Size(67, 38);
            this.socialToolStripMenuItem.Text = "Social";
            // 
            // menuItemNPCs
            // 
            this.menuItemNPCs.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuItemNPCs.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuItemNPCs.Name = "menuItemNPCs";
            this.menuItemNPCs.Size = new System.Drawing.Size(120, 26);
            this.menuItemNPCs.Text = "NPCs";
            this.menuItemNPCs.Click += new System.EventHandler(this.menuItemNPCs_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemTYPE_VManage});
            this.databaseToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(101, 38);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // menuItemTYPE_VManage
            // 
            this.menuItemTYPE_VManage.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuItemTYPE_VManage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuItemTYPE_VManage.Name = "menuItemTYPE_VManage";
            this.menuItemTYPE_VManage.Size = new System.Drawing.Size(254, 26);
            this.menuItemTYPE_VManage.Text = "Manage TYPE_V table";
            this.menuItemTYPE_VManage.Click += new System.EventHandler(this.menuItemTYPE_VManage_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.homePanel);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Dungeon Master Tools";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.homePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem playersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem combatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem explorationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem socialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemNPCs;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemTYPE_VManage;
        private System.Windows.Forms.ToolStripMenuItem menuItemPlaces;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.Button btnClose;
    }
}

