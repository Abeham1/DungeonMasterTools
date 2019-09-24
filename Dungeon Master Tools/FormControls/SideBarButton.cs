using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Dungeon_Master_Tools
{
    public partial class SideBarButton : UserControl
    {
        private Color hoverColor = Color.FromName(ConfigurationManager.AppSettings["secondaryColor"]);
        private Color backgroundColor = Color.FromName(ConfigurationManager.AppSettings["primaryColor"]);

        public SideBarButton()
        {
            InitializeComponent();
            button1.BackColor = backgroundColor;
            panel1.BackColor = backgroundColor;
            this.BackColor = backgroundColor;
        }

        private void button_MouseEnter(object sender, EventArgs e)
        {
            (sender as Button).BackColor = hoverColor;
            panel2.BackColor = hoverColor;
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).BackColor = backgroundColor;
            panel2.BackColor = backgroundColor;
        }

        public void ButtonText(string text)
        {
            button1.Text = text;
        }
    }
}
