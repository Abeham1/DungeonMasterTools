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
    public partial class NPCsAdd : Form
    {
        SqlConnection conn = new SqlConnection();

        public NPCsAdd()
        {
            InitializeComponent();
       conn.ConnectionString = "Data Source=(LocalDb)\\LocalDB;" + "Initial Catalog=master;" + "Integrated Security=SSPI;";
        }

        public void NPCsAdd_Load(object sender, EventArgs e)
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
                            comboBoxHomeCity.Items.Add(place);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("An error occurred in NPCsAdd_Load.");
            }

            query = "Select TYPE_ID, DESCR FROM TYPE_V WHERE CATEGORY = 'OCCUPATION' order by DESCR";
            try
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TYPE_V occupation = new TYPE_V();
                            occupation.TYPE_ID = reader.GetInt32(0);
                            occupation.DESCR = reader.GetString(1);
                            comboBoxOccupation.Items.Add(occupation);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("An error occurred in NPCsAdd_Load.");
            }
            conn.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (comboBoxOccupation.SelectedItem != null && comboBoxHomeCity.SelectedItem != null && !String.IsNullOrEmpty(txtName.Text) && !String.IsNullOrEmpty(txtDescription.Text))
            {
                conn.Open();
                string query =
                    "INSERT INTO NPCS(NAME, HOME_CITY_ID, OCCUPATION_ID, DESCR) "
                    + "VALUES('" + txtName.Text + "', " + ((PLACE)comboBoxHomeCity.SelectedItem).PLACE_ID.ToString() + " , " + ((TYPE_V)comboBoxOccupation.SelectedItem).TYPE_ID.ToString() + " , '" + txtDescription.Text + "')";
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
                    txtDescription.Clear();
                    comboBoxOccupation.SelectedItem = 0;
                    comboBoxHomeCity.SelectedItem = 0;
                    txtName.Clear();
                }
                catch
                {
                    MessageBox.Show("An error occurred in btnSubmit_Click.");
                }
                conn.Close();
            }
            else
                MessageBox.Show("Please ensure that you have entered a value for each field.");
        }
    }
}
