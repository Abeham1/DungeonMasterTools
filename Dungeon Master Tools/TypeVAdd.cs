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
    public partial class TypeVAdd : Form
    {
        public TypeVAdd()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(LocalDb)\\LocalDB;" + "Initial Catalog=master;" + "Integrated Security=SSPI;";

            conn.Open();
            string query = "INSERT INTO TYPE_V(CATEGORY, DESCR)" + 
                            "VALUES('" + txtCategory.Text + "', '" + txtDescription.Text + "')";
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
            conn.Close();
        }
                     
            
    }
}
