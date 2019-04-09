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
    public partial class Places_Manage : Form
    {
        private ColumnHeader SortingColumn = null;
        private List<PLACE> AllPlaces;
        private SqlConnection conn = new SqlConnection();
        List<PLACE> ListPlace = new List<PLACE>();

        public Places_Manage()
        {
            InitializeComponent();
            AllPlaces = new List<PLACE>();
            conn.ConnectionString =
                "Data Source=(LocalDb)\\LocalDB;" +
                "Initial Catalog=master;" +
                "Integrated Security=SSPI;";
        }

        private void Places_Manage_Load(object sender, EventArgs e)
        {
            conn.Open();
            string query = "select p.PLACE_ID, p.NAME, ISNULL(p.PARENT_LOCATION, 0), p.DESCR, ISNULL(q.PLACE_ID, 0), ISNULL(q.NAME, '') from PLACES p left join PLACES q on p.PARENT_LOCATION = q.PLACE_ID";
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
                            place.PARENT_LOCATION = reader.GetInt32(2);
                            place.DESCR = reader.GetString(3);
                            place.PARENT_LOCATION_NAME = reader.GetString(5);
                            ListPlace.Add(place);
                        }
                    }
                }
                foreach (var item in ListPlace)
                {
                    ListViewItem row = new ListViewItem(item.NAME);
                    row.SubItems.Add(new ListViewItem.ListViewSubItem(row, item.PARENT_LOCATION_NAME));
                    row.SubItems.Add(new ListViewItem.ListViewSubItem(row, item.PLACE_ID.ToString()));
                    row.SubItems.Add(new ListViewItem.ListViewSubItem(row, item.DESCR));
                    listViewPlaces.Items.Add(row);
                }
                AllPlaces = ListPlace;
            }
            catch
            {
                MessageBox.Show("An error occurred in Places_Manage_Load.");
            }
            populateFilter();
            conn.Close();
        }

        // Sort on this column.
        private void listViewPlaces_ColumnClick(object sender,
            ColumnClickEventArgs e)
        {
            // Get the new sorting column.
            ColumnHeader new_sorting_column = listViewPlaces.Columns[e.Column];

            // Figure out the new sorting order.
            System.Windows.Forms.SortOrder sort_order;
            if (SortingColumn == null)
            {
                // New column. Sort ascending.
                sort_order = System.Windows.Forms.SortOrder.Ascending;
            }
            else
            {
                // See if this is the same column.
                if (new_sorting_column == SortingColumn)
                {
                    // Same column. Switch the sort order.
                    if (SortingColumn.Text.StartsWith("> "))
                    {
                        sort_order = System.Windows.Forms.SortOrder.Descending;
                    }
                    else
                    {
                        sort_order = System.Windows.Forms.SortOrder.Ascending;
                    }
                }
                else
                {
                    // New column. Sort ascending.
                    sort_order = System.Windows.Forms.SortOrder.Ascending;
                }

                // Remove the old sort indicator.
                SortingColumn.Text = SortingColumn.Text.Substring(2);
            }

            // Display the new sort order.
            SortingColumn = new_sorting_column;
            if (sort_order == System.Windows.Forms.SortOrder.Ascending)
            {
                SortingColumn.Text = "> " + SortingColumn.Text;
            }
            else
            {
                SortingColumn.Text = "< " + SortingColumn.Text;
            }

            // Create a comparer.
            listViewPlaces.ListViewItemSorter =
                new ListViewComparer(e.Column, sort_order);

            // Sort.
            listViewPlaces.Sort();
        }

        public void populateFilter()
        {
            List<string> parents = new List<string>();
            parents = AllPlaces.Select(x => x.PARENT_LOCATION_NAME).Distinct().ToList();

            foreach (var parent in parents)
            {
                comboBoxFilterParent.Items.Add(parent);
            }
        }

        private void comboBoxFilterParent_SelectedIndexChanged(object sender, EventArgs e)
        {
            AllPlaces.Clear();
            ListPlace.Clear();

            listViewPlaces.Items.Clear();
            conn.Open();
            string query = "select p.PLACE_ID, p.NAME, ISNULL(p.PARENT_LOCATION, 0), p.DESCR, ISNULL(q.PLACE_ID, 0), ISNULL(q.NAME, '') from PLACES p left join PLACES q on p.PARENT_LOCATION = q.PLACE_ID WHERE q.NAME = '" + comboBoxFilterParent.SelectedItem + "'";
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
                            place.PARENT_LOCATION = reader.GetInt32(2);
                            place.DESCR = reader.GetString(3);
                            place.PARENT_LOCATION_NAME = reader.GetString(5);
                            ListPlace.Add(place);
                        }
                    }
                }
                foreach (var item in ListPlace)
                {
                    ListViewItem row = new ListViewItem(item.NAME);
                    row.SubItems.Add(new ListViewItem.ListViewSubItem(row, item.PARENT_LOCATION_NAME));
                    row.SubItems.Add(new ListViewItem.ListViewSubItem(row, item.PLACE_ID.ToString()));
                    row.SubItems.Add(new ListViewItem.ListViewSubItem(row, item.DESCR));
                    listViewPlaces.Items.Add(row);
                }
                AllPlaces = ListPlace;
            }
            catch
            {
                MessageBox.Show("An error occurred in comboBoxFilterParent_SelectedIndexChanged.");
            }
            conn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listViewPlaces.SelectedItems.Count == 1)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete " + txtDescription.Text + "?", "Confirmation", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    AllPlaces.Clear();
                    ListPlace.Clear();

                    listViewPlaces.Items.Clear();
                    conn.Open();
                    string query = "DELETE FROM PLACES WHERE PLACE_ID = " + txtPlace_id.Text;
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
                    }
                    catch
                    {
                        MessageBox.Show("An error occurred in btnDelete_Click.");
                    }
                    conn.Close();
                }
                doRefresh();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddLocation addLocation = new AddLocation();
            addLocation.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            doRefresh();
        }

        private void doRefresh()
        {
            AllPlaces.Clear();
            ListPlace.Clear();

            listViewPlaces.Items.Clear();
            conn.Open();
            string query = "select p.PLACE_ID, p.NAME, ISNULL(p.PARENT_LOCATION, 0), p.DESCR, ISNULL(q.PLACE_ID, 0), ISNULL(q.NAME, '') from PLACES p left join PLACES q on p.PARENT_LOCATION = q.PLACE_ID";
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
                            place.PARENT_LOCATION = reader.GetInt32(2);
                            place.DESCR = reader.GetString(3);
                            place.PARENT_LOCATION_NAME = reader.GetString(5);
                            ListPlace.Add(place);
                        }
                    }
                }
                foreach (var item in ListPlace)
                {
                    ListViewItem row = new ListViewItem(item.NAME);
                    row.SubItems.Add(new ListViewItem.ListViewSubItem(row, item.PARENT_LOCATION_NAME));
                    row.SubItems.Add(new ListViewItem.ListViewSubItem(row, item.PLACE_ID.ToString()));
                    row.SubItems.Add(new ListViewItem.ListViewSubItem(row, item.DESCR));
                    listViewPlaces.Items.Add(row);
                }
                AllPlaces = ListPlace;
            }
            catch
            {
                MessageBox.Show("An error occurred in doRefresh().");
            }
            conn.Close();
        }

        private void listViewPlaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPlaces.SelectedItems.Count > 0)
            {
                txtName.Text = listViewPlaces.SelectedItems[0].Text;
                txtParentLocation.Text = ((ListViewItem)listViewPlaces.SelectedItems[0]).SubItems[1].Text;
                txtPlace_id.Text = ((ListViewItem)listViewPlaces.SelectedItems[0]).SubItems[2].Text;
                txtDescription.Text = ((ListViewItem)listViewPlaces.SelectedItems[0]).SubItems[3].Text;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "UPDATE PLACES SET DESCR = '" + txtDescription.Text + "', NAME = '" + txtName.Text + "' WHERE PLACE_ID = " + txtPlace_id.Text;
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
                MessageBox.Show("Saved!");
            }
            catch
            {
                MessageBox.Show("An error occurred in btnSave_Click.");
            }
            conn.Close();
        }
    }
}
