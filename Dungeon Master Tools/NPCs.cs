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
using System.Configuration;

namespace Dungeon_Master_Tools
{
    public partial class NPCs : Form
    {
        private ColumnHeader SortingColumn = null;
        private List<NPC> AllNPCs;
        private SqlConnection conn = new SqlConnection();
        List<NPC> ListNPC = new List<NPC>();

        public NPCs()
        {
            InitializeComponent();
            AllNPCs = new List<NPC>();
            UseWaitCursor = false;
            conn.ConnectionString = ConfigurationManager.AppSettings["connectionString"];
        }

        private void NPCs_Load(object sender, EventArgs e)
        {
            conn.Open();
            string query = 
                "SELECT " +
                "   n.*, " +
                "   oc.DESCR as OCCUPATION, " +
                "   p.NAME as HOME_CITY " +
                "FROM NPCS n " +
                "JOIN TYPE_V oc on n.OCCUPATION_ID = oc.TYPE_ID " +
                "JOIN PLACES p on n.HOME_CITY_ID = p.PLACE_ID";
            try
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            NPC npc = new NPC();
                            npc.NPC_ID = reader.GetInt32(0);
                            npc.NAME = reader.GetString(1);
                            npc.HOME_CITY_ID = reader.GetInt32(2);
                            npc.OCCUPATION_ID = reader.GetInt32(3);
                            npc.DESCR = reader.GetString(4);
                            npc.OCCUPATION = reader.GetString(5);
                            npc.HOME_CITY = reader.GetString(6);
                            ListNPC.Add(npc);
                        }
                    }
                }
                foreach (var item in ListNPC)
                {
                    ListViewItem row = new ListViewItem(item.NAME);
                    row.SubItems.Add(new ListViewItem.ListViewSubItem(row, item.HOME_CITY));
                    row.SubItems.Add(new ListViewItem.ListViewSubItem(row, item.OCCUPATION));
                    row.SubItems.Add(new ListViewItem.ListViewSubItem(row, item.NPC_ID.ToString()));
                    row.SubItems.Add(new ListViewItem.ListViewSubItem(row, item.DESCR));
                    listViewNPCs.Items.Add(row);
                }
                AllNPCs = ListNPC;
            }
            catch
            {
                MessageBox.Show("An error occurred in NPCs_Load.");
            }
            populateFilters();
            conn.Close();
        }

        // Sort on this column.
        private void listViewTypeV_ColumnClick(object sender,
            ColumnClickEventArgs e)
        {
            // Get the new sorting column.
            ColumnHeader new_sorting_column = listViewNPCs.Columns[e.Column];

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
            listViewNPCs.ListViewItemSorter =
                new ListViewComparer(e.Column, sort_order);

            // Sort.
            listViewNPCs.Sort();
        }

        public void populateFilters()
        {
            comboBoxPrimaryFilter.Items.Clear();
            comboBoxSecondaryFilter.Items.Clear();
            List<string> cities = new List<string>();
            cities = AllNPCs.Select(x => x.HOME_CITY).Distinct().ToList();

            foreach (var city in cities)
            {
                comboBoxPrimaryFilter.Items.Add(city);
            }

            List<string> occupations = new List<string>();
            occupations = AllNPCs.Select(x => x.OCCUPATION).Distinct().ToList();

            foreach (var occupation in occupations)
            {
                comboBoxSecondaryFilter.Items.Add(occupation);
            }
        }

        private void comboBoxPrimaryFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            AllNPCs.Clear();
            ListNPC.Clear();

            listViewNPCs.Items.Clear();

            string additionalFilter = "";
            if (comboBoxSecondaryFilter.SelectedItem != null)
                additionalFilter = " AND oc.DESCR = '" + comboBoxSecondaryFilter.SelectedItem.ToString() + "'";

            conn.Open();
            string query =
                "SELECT " +
                "   n.*," +
                "   oc.DESCR as OCCUPATION," +
                "   p.NAME as HOME_CITY " +
                "FROM NPCS n " +
                "JOIN TYPE_V oc on n.OCCUPATION_ID = oc.TYPE_ID " +
                "JOIN PLACES p on n.HOME_CITY_ID = p.PLACE_ID " +
                "WHERE p.NAME = '" + comboBoxPrimaryFilter.SelectedItem + "'" + additionalFilter;
            try
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            NPC npc = new NPC();
                            npc.NPC_ID = reader.GetInt32(0);
                            npc.NAME = reader.GetString(1);
                            npc.HOME_CITY_ID = reader.GetInt32(2);
                            npc.OCCUPATION_ID = reader.GetInt32(3);
                            npc.DESCR = reader.GetString(4);
                            npc.OCCUPATION = reader.GetString(5);
                            npc.HOME_CITY = reader.GetString(6);
                            ListNPC.Add(npc);
                        }
                    }
                }
                foreach (var item in ListNPC)
                {
                    ListViewItem row = new ListViewItem(item.NAME);
                    row.SubItems.Add(new ListViewItem.ListViewSubItem(row, item.HOME_CITY));
                    row.SubItems.Add(new ListViewItem.ListViewSubItem(row, item.OCCUPATION));
                    row.SubItems.Add(new ListViewItem.ListViewSubItem(row, item.NPC_ID.ToString()));
                    row.SubItems.Add(new ListViewItem.ListViewSubItem(row, item.DESCR));
                    listViewNPCs.Items.Add(row);
                }
                AllNPCs = ListNPC;
            }
            catch
            {
                MessageBox.Show("An error occurred in comboBoxPrimaryFilter_SelectedIndexChanged.");
            }
            conn.Close();
        }

        private void comboBoxSecondaryFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            AllNPCs.Clear();
            ListNPC.Clear();

            listViewNPCs.Items.Clear();

            string additionalFilter = "";
            if (comboBoxPrimaryFilter.SelectedItem != null)
                additionalFilter = " AND p.NAME = '" + comboBoxPrimaryFilter.SelectedItem.ToString() + "'";

            conn.Open();
            string query =
                "SELECT " +
                "   n.*," +
                "   oc.DESCR as OCCUPATION," +
                "   p.NAME as HOME_CITY " +
                "FROM NPCS n " +
                "JOIN TYPE_V oc on n.OCCUPATION_ID = oc.TYPE_ID " +
                "JOIN PLACES p on n.HOME_CITY_ID = p.PLACE_ID " +
                "WHERE oc.DESCR = '" + comboBoxSecondaryFilter.SelectedItem + "'" + additionalFilter;

            try
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            NPC npc = new NPC();
                            npc.NPC_ID = reader.GetInt32(0);
                            npc.NAME = reader.GetString(1);
                            npc.HOME_CITY_ID = reader.GetInt32(2);
                            npc.OCCUPATION_ID = reader.GetInt32(3);
                            npc.DESCR = reader.GetString(4);
                            npc.OCCUPATION = reader.GetString(5);
                            npc.HOME_CITY = reader.GetString(6);
                            ListNPC.Add(npc);
                        }
                    }
                }
                foreach (var item in ListNPC)
                {
                    ListViewItem row = new ListViewItem(item.NAME);
                    row.SubItems.Add(new ListViewItem.ListViewSubItem(row, item.HOME_CITY));
                    row.SubItems.Add(new ListViewItem.ListViewSubItem(row, item.OCCUPATION));
                    row.SubItems.Add(new ListViewItem.ListViewSubItem(row, item.NPC_ID.ToString()));
                    row.SubItems.Add(new ListViewItem.ListViewSubItem(row, item.DESCR));
                    listViewNPCs.Items.Add(row);
                }
                AllNPCs = ListNPC;
            }
            catch
            {
                MessageBox.Show("An error occurred in comboBoxSecondaryFilter_SelectedIndexChanged.");
            }
            conn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listViewNPCs.SelectedItems.Count == 1)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete " + txtName.Text + "?", "Confirmation", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    AllNPCs.Clear();
                    ListNPC.Clear();

                    listViewNPCs.Items.Clear();
                    conn.Open();
                    string query = "DELETE FROM NPCS WHERE NPC_ID = " + txtNpcID.Text;
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
            NPCsAdd newNPC = new NPCsAdd();
            newNPC.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            doRefresh();
        }

        private void doRefresh()
        {
            AllNPCs.Clear();
            ListNPC.Clear();

            listViewNPCs.Items.Clear();
            conn.Open();
            string query =
                "SELECT " +
                "   n.*, " +
                "   oc.DESCR as OCCUPATION, " +
                "   p.NAME as HOME_CITY " +
                "FROM NPCS n " +
                "JOIN TYPE_V oc on n.OCCUPATION_ID = oc.TYPE_ID " +
                "JOIN PLACES p on n.HOME_CITY_ID = p.PLACE_ID";
            try
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            NPC npc = new NPC();
                            npc.NPC_ID = reader.GetInt32(0);
                            npc.NAME = reader.GetString(1);
                            npc.HOME_CITY_ID = reader.GetInt32(2);
                            npc.OCCUPATION_ID = reader.GetInt32(3);
                            npc.DESCR = reader.GetString(4);
                            npc.OCCUPATION = reader.GetString(5);
                            npc.HOME_CITY = reader.GetString(6);
                            ListNPC.Add(npc);
                        }
                    }
                }
                foreach (var item in ListNPC)
                {
                    ListViewItem row = new ListViewItem(item.NAME);
                    row.SubItems.Add(new ListViewItem.ListViewSubItem(row, item.HOME_CITY));
                    row.SubItems.Add(new ListViewItem.ListViewSubItem(row, item.OCCUPATION));
                    row.SubItems.Add(new ListViewItem.ListViewSubItem(row, item.NPC_ID.ToString()));
                    row.SubItems.Add(new ListViewItem.ListViewSubItem(row, item.DESCR));
                    listViewNPCs.Items.Add(row);
                }
                AllNPCs = ListNPC;
            }
            catch
            {
                MessageBox.Show("An error occurred in doRefresh.");
            }
            populateFilters();
            conn.Close();
        }

        private void btnOpenOrganization_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented yet!");
        }

        private void listViewNPCs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewNPCs.SelectedItems.Count > 0)
            {
                txtName.Text = listViewNPCs.SelectedItems[0].Text;
                txtHomeCity.Text = ((ListViewItem)listViewNPCs.SelectedItems[0]).SubItems[1].Text;
                txtOccupation.Text = ((ListViewItem)listViewNPCs.SelectedItems[0]).SubItems[2].Text;
                txtNpcID.Text = ((ListViewItem)listViewNPCs.SelectedItems[0]).SubItems[3].Text;
                txtDescription.Text = ((ListViewItem)listViewNPCs.SelectedItems[0]).SubItems[4].Text;
            }
        }
    }
}
