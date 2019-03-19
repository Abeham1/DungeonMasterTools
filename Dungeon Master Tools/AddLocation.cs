using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dungeon_Master_Tools
{
    public partial class AddLocation : Form
    {
        SqlConnection conn = new SqlConnection();

        public AddLocation()
        {
            InitializeComponent();
            conn.ConnectionString = "Data Source=(LocalDb)\\LocalDB;" + "Initial Catalog=master;" + "Integrated Security=SSPI;";
        }

        public void AddLocation_Load(object sender, EventArgs e)
        {
            conn.Open();
            string query = "Select PLACE_ID, NAME FROM PLACES order by NAME";
            try
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PLACE place = new PLACE();
                            place.PLACE_ID = reader.GetInt32(0);
                            place.NAME = reader.GetString(1);
                            comboBoxParent.Items.Add(place);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("An error occurred in btnSubmit_Click.");
            }
            conn.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "";
            if (comboBoxParent.SelectedItem != null)
            {
                query = "INSERT INTO PLACES(NAME, PARENT_LOCATION, DESCR)" +
                                "VALUES('" + txtName.Text + "', NULLIF(" + ((PLACE)comboBoxParent.SelectedItem).PLACE_ID + ", ''), '" + txtDescription.Text + "')";
            }
            else
            {
                query = "INSERT INTO PLACES(NAME, PARENT_LOCATION, DESCR)" +
                                "VALUES('" + txtName.Text + "', NULL, '" + txtDescription.Text + "')";
            }
            try
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                        }
                    }
                }
                MessageBox.Show("Success!");
            }
            catch
            {
                MessageBox.Show("An error occurred in btnSubmit_Click.");
            }
            txtDescription.Clear();
            comboBoxParent.SelectedItem = 0;
            txtName.Clear();
        }
    }
}
