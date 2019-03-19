using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dungeon_Master_Tools
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void menuItemNPCs_Click(object sender, EventArgs e)
        {
            NPCs newNPCWindow = new NPCs();
            newNPCWindow.Show();
        }

        private void menuItemTYPE_VManage_Click(object sender, EventArgs e)
        {
            TYPE_VManage newTypeVManage = new TYPE_VManage();
            newTypeVManage.Show();
        }

        private void menuItemPlaces_Click(object sender, EventArgs e)
        {
            Places_Manage newPlaceManager = new Places_Manage();
            newPlaceManager.Show();
        }
    }
}
