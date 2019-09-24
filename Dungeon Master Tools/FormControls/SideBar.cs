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
using System.Data.SqlClient;

namespace Dungeon_Master_Tools
{
    public partial class SideBar : UserControl
    {
        private bool minimized = false;
        private Color hoverColor = Color.FromName(ConfigurationManager.AppSettings["secondaryColor"]);
        private Color backgroundColor = Color.FromName(ConfigurationManager.AppSettings["primaryColor"]);
        List<SIDEBAR_BUTTON> ListButtons = new List<SIDEBAR_BUTTON>();

        public SideBar()
        {
            InitializeComponent();
            BackColor = backgroundColor;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.AppSettings["connectionString"];


            conn.Open();
            string query = "SELECT sb.SIDEBAR_BUTTON_ID, sb.BUTTON_TEXT, sb.PARENT_BUTTON_ID from SIDEBAR_BUTTONS sb";
            try
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            SIDEBAR_BUTTON button = new SIDEBAR_BUTTON();
                            button.SIDEBAR_BUTTON_ID = reader.GetInt32(0);
                            button.BUTTON_TEXT = reader.GetString(1);
                            if (!reader.IsDBNull(2))
                                button.PARENT_BUTTON = reader.GetInt32(2);
                            button.displayed = false;
                            ListButtons.Add(button);
                        }
                    }
                }
                foreach (var button in ListButtons)
                {
                    if (button.PARENT_BUTTON == 0)
                    {
                        SideBarButton newButton = new SideBarButton();
                        newButton.button1.Tag = button.SIDEBAR_BUTTON_ID;
                        newButton.ButtonText(button.BUTTON_TEXT);
                        newButton.button1.Click += new EventHandler(Button_Click);
                        flowLayoutPanel1.Controls.Add(newButton);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Could not load sidebar buttons.");
            }
        }

        public SideBar(List<SIDEBAR_BUTTON> listB)
        {
            InitializeComponent();
            button1.Visible = false;
            BackColor = backgroundColor;
            foreach(SIDEBAR_BUTTON button in listB)
            {
                SideBarButton newButton = new SideBarButton();
                newButton.button1.Tag = (button).SIDEBAR_BUTTON_ID;
                newButton.ButtonText((button).BUTTON_TEXT);
                newButton.Click += new EventHandler(Button_Click);
                flowLayoutPanel1.Controls.Add(newButton);
            }
        }

        public void Button_Click(object sender, EventArgs e)
        {
            bool makeNewSideBar = ListButtons.Exists(x => x.PARENT_BUTTON == (int)(sender as Button).Tag);
            SIDEBAR_BUTTON button = ListButtons.Find(x => x.SIDEBAR_BUTTON_ID == (int)(sender as Button).Tag);
            if (makeNewSideBar)
            {
                if (!button.displayed) {
                    
                    List<SIDEBAR_BUTTON> list = ListButtons.FindAll(x => x.PARENT_BUTTON == button.SIDEBAR_BUTTON_ID);
                    SideBar sideBar = new SideBar(list);
                    sideBar.Tag = "CHILD_SIDEBAR_BUTTON_" + button.SIDEBAR_BUTTON_ID.ToString();
                    sideBar.Parent = this.Parent;
                    sideBar.Location = (sender as Button).FindForm().PointToClient((sender as Button).Parent.PointToScreen(new Point((sender as Button).Bounds.Right, (sender as Button).Bounds.Top)));
                    ListButtons.Find(x => x.SIDEBAR_BUTTON_ID == (int)(sender as Button).Tag).displayed = true;
                }
                else
                {
                    foreach (Control control in Parent.Controls)
                    {
                        if (control.Tag != null)
                        {
                            if (control.Tag.ToString() == "CHILD_SIDEBAR_BUTTON_" + button.SIDEBAR_BUTTON_ID.ToString())
                            {
                                control.Dispose();
                            }
                        }
                    }
                    ListButtons.Find(x => x.SIDEBAR_BUTTON_ID == (int)(sender as Button).Tag).displayed = false;
                }
            }
            else
            {
                switch((sender as Button).Text)
                {
                    default:
                        break;
                }
            }
        }
    }
}