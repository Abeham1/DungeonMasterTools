using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//TODO: Global change. Add Save button to each Database manager window. Save_click() should save any edits to the selected item.
//TODO: Global change. Add Order by NAME to each Database manager window. The default will order all items by Alphabetical order.
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
