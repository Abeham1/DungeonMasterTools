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
    public partial class TYPE_VManage : Form
    {
        private ColumnHeader SortingColumn = null;
        private List<TYPE_V> AllItems;
        private SqlConnection conn = new SqlConnection();
        List<TYPE_V> ListV = new List<TYPE_V>();

        public TYPE_VManage()
        {
            InitializeComponent();
            AllItems = new List<TYPE_V>();
            conn.ConnectionString =
                "Data Source=(LocalDb)\\LocalDB;" +
                "Initial Catalog=master;" +
                "Integrated Security=SSPI;";
        }

        private void TYPE_VManage_Load(object sender, EventArgs e)
        {
            conn.Open();
            string query = "SELECT * FROM TYPE_V";
            try
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TYPE_V type_v = new TYPE_V();
                            type_v.TYPE_ID = reader.GetInt32(0);
                            type_v.CATEGORY = reader.GetString(1);
                            type_v.DESCR = reader.GetString(2);
                            ListV.Add(type_v);
                        }
                    }
                }
                foreach (var item in ListV)
                {
                    ListViewItem row = new ListViewItem(item.DESCR);
                    row.SubItems.Add(new ListViewItem.ListViewSubItem(row, item.CATEGORY));
                    row.SubItems.Add(new ListViewItem.ListViewSubItem(row, item.TYPE_ID.ToString()));
                    listViewTypeV.Items.Add(row);
                }
                AllItems = ListV;
            }
            catch
            {
                MessageBox.Show("An error occurred in TYPEVManage_Load.");
            }
            populateFilter();
            conn.Close();
        }

        // Sort on this column.
        private void listViewTypeV_ColumnClick(object sender,
            ColumnClickEventArgs e)
        {
            // Get the new sorting column.
            ColumnHeader new_sorting_column = listViewTypeV.Columns[e.Column];

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
            listViewTypeV.ListViewItemSorter =
                new ListViewComparer(e.Column, sort_order);

            // Sort.
            listViewTypeV.Sort();
        }

        public void populateFilter()
        {
            List<string> categories = new List<string>();
            categories = AllItems.Select(x => x.CATEGORY).Distinct().ToList();

            foreach(var category in categories)
            {
                comboBoxCategory.Items.Add(category);
            }
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            AllItems.Clear();
            ListV.Clear();

            listViewTypeV.Items.Clear();
            conn.Open();
            string query = "SELECT * FROM TYPE_V WHERE CATEGORY = " + "'" + comboBoxCategory.SelectedItem + "'";
            try
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TYPE_V type_v = new TYPE_V();
                            type_v.TYPE_ID = reader.GetInt32(0);
                            type_v.CATEGORY = reader.GetString(1);
                            type_v.DESCR = reader.GetString(2);
                            ListV.Add(type_v);
                        }
                    }
                }
                foreach (var item in ListV)
                {
                    ListViewItem row = new ListViewItem(item.DESCR);
                    row.SubItems.Add(new ListViewItem.ListViewSubItem(row, item.CATEGORY));
                    row.SubItems.Add(new ListViewItem.ListViewSubItem(row, item.TYPE_ID.ToString()));
                    listViewTypeV.Items.Add(row);
                }
                AllItems = ListV;
            }
            catch
            {
                MessageBox.Show("An error occurred in comboBoxCategory_SelectedIndexChanged.");
            }
            conn.Close();
        }

        private void listViewTypeV_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listViewTypeV.SelectedItems.Count > 0)
            {
                txtDescription.Text = listViewTypeV.SelectedItems[0].Text;
                txtCategory.Text = ((ListViewItem)listViewTypeV.SelectedItems[0]).SubItems[1].Text;
                txtType_ID.Text = ((ListViewItem)listViewTypeV.SelectedItems[0]).SubItems[2].Text;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listViewTypeV.SelectedItems.Count == 1)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete " + txtDescription.Text + "?", "Confirmation", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    AllItems.Clear();
                    ListV.Clear();

                    listViewTypeV.Items.Clear();
                    conn.Open();
                    string query = "DELETE FROM TYPE_V WHERE TYPE_ID = " + txtType_ID.Text;
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
            TypeVAdd newTypeV = new TypeVAdd();
            newTypeV.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            doRefresh();
        }

        private void doRefresh()
        {
            AllItems.Clear();
            ListV.Clear();

            listViewTypeV.Items.Clear();
            conn.Open();
            string query = "SELECT * FROM TYPE_V";
            try
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TYPE_V type_v = new TYPE_V();
                            type_v.TYPE_ID = reader.GetInt32(0);
                            type_v.CATEGORY = reader.GetString(1);
                            type_v.DESCR = reader.GetString(2);
                            ListV.Add(type_v);
                        }
                    }
                }
                foreach (var item in ListV)
                {
                    ListViewItem row = new ListViewItem(item.DESCR);
                    row.SubItems.Add(new ListViewItem.ListViewSubItem(row, item.CATEGORY));
                    row.SubItems.Add(new ListViewItem.ListViewSubItem(row, item.TYPE_ID.ToString()));
                    listViewTypeV.Items.Add(row);
                }
                AllItems = ListV;
            }
            catch
            {
                MessageBox.Show("An error occurred in doRefresh().");
            }
            conn.Close();
        }
    }
}
