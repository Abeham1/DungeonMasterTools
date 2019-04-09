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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.playersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.combatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.explorationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPlaces = new System.Windows.Forms.ToolStripMenuItem();
            this.socialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNPCs = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemTYPE_VManage = new System.Windows.Forms.ToolStripMenuItem();
            this.lblHomeWelcome = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playersToolStripMenuItem,
            this.combatToolStripMenuItem,
            this.explorationToolStripMenuItem,
            this.socialToolStripMenuItem,
            this.databaseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // playersToolStripMenuItem
            // 
            this.playersToolStripMenuItem.Name = "playersToolStripMenuItem";
            this.playersToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.playersToolStripMenuItem.Text = "Players";
            // 
            // combatToolStripMenuItem
            // 
            this.combatToolStripMenuItem.Name = "combatToolStripMenuItem";
            this.combatToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.combatToolStripMenuItem.Text = "Combat";
            // 
            // explorationToolStripMenuItem
            // 
            this.explorationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemPlaces});
            this.explorationToolStripMenuItem.Name = "explorationToolStripMenuItem";
            this.explorationToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.explorationToolStripMenuItem.Text = "Exploration";
            // 
            // menuItemPlaces
            // 
            this.menuItemPlaces.Name = "menuItemPlaces";
            this.menuItemPlaces.Size = new System.Drawing.Size(204, 22);
            this.menuItemPlaces.Text = "Manage Places Database";
            this.menuItemPlaces.Click += new System.EventHandler(this.menuItemPlaces_Click);
            // 
            // socialToolStripMenuItem
            // 
            this.socialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNPCs});
            this.socialToolStripMenuItem.Name = "socialToolStripMenuItem";
            this.socialToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.socialToolStripMenuItem.Text = "Social";
            // 
            // menuItemNPCs
            // 
            this.menuItemNPCs.Name = "menuItemNPCs";
            this.menuItemNPCs.Size = new System.Drawing.Size(180, 22);
            this.menuItemNPCs.Text = "NPCs";
            this.menuItemNPCs.Click += new System.EventHandler(this.menuItemNPCs_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemTYPE_VManage});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // menuItemTYPE_VManage
            // 
            this.menuItemTYPE_VManage.Name = "menuItemTYPE_VManage";
            this.menuItemTYPE_VManage.Size = new System.Drawing.Size(188, 22);
            this.menuItemTYPE_VManage.Text = "Manage TYPE_V table";
            this.menuItemTYPE_VManage.Click += new System.EventHandler(this.menuItemTYPE_VManage_Click);
            // 
            // lblHomeWelcome
            // 
            this.lblHomeWelcome.AutoSize = true;
            this.lblHomeWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeWelcome.Location = new System.Drawing.Point(2, 24);
            this.lblHomeWelcome.Name = "lblHomeWelcome";
            this.lblHomeWelcome.Size = new System.Drawing.Size(606, 39);
            this.lblHomeWelcome.TabIndex = 2;
            this.lblHomeWelcome.Text = "Welcome to Dungeon Master Tools for ";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.BackgroundImage = global::Dungeon_Master_Tools.Properties.Resources.dungeonsAndDragonsLogo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHomeWelcome);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Dungeon Master Tools";
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
        private System.Windows.Forms.Label lblHomeWelcome;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemTYPE_VManage;
        private System.Windows.Forms.ToolStripMenuItem menuItemPlaces;
    }
}

