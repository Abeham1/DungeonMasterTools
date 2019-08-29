using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


//TODO: Global change. Add Save button to each Database manager window. Save_click() should save any edits to the selected item.
//TODO: Global change. Add Order by NAME to each Database manager window. The default will order all items by Alphabetical order.
namespace Dungeon_Master_Tools
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            //Paint += new PaintEventHandler(color_Background);
            menuStrip1.Renderer = new MenuStripRenderer();
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
        }

        private void menuItemNPCs_Click(object sender, EventArgs e)
        {
            NPCs newNPCWindow = new NPCs();
            newNPCWindow.MdiParent = this;
            newNPCWindow.Show();
        }

        private void menuItemTYPE_VManage_Click(object sender, EventArgs e)
        {
            TYPE_VManage newTypeVManage = new TYPE_VManage();
            newTypeVManage.MdiParent = this;
            newTypeVManage.Show();
        }

        private void menuItemPlaces_Click(object sender, EventArgs e)
        {
            Places_Manage newPlaceManager = new Places_Manage();
            newPlaceManager.MdiParent = this;
            newPlaceManager.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        //private void color_Background(object sender, PaintEventArgs e)
        //{
        //    Graphics graphics = e.Graphics;

        //    //the rectangle, the same size as our Form
        //    Rectangle gradient_rectangle = new Rectangle(Location.X, Location.Y, Width, Height);

        //    //define gradient's properties
        //    Brush b = new LinearGradientBrush(gradient_rectangle, Color.Black, Color.DarkGray, 60f);

        //    //apply gradient         
        //    graphics.FillRectangle(b, gradient_rectangle);
        //}

        private void minimizeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void maximizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void fullScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FormBorderStyle == FormBorderStyle.Sizable)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }
    }
}
