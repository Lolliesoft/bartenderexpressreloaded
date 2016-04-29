using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bartenderexpressReloaded
{
    public partial class CabinetSearch : Form
    {
        public CabinetSearch()
        {
            InitializeComponent();
            fill_box();
        }

        void fill_box()
        {
            SQLiteConnection cs103 = new SQLiteConnection("Data Source = |DataDirectory|\\XpressShots.db");
            {
                cs103.Open();

                //Get ID
                SQLiteCommand cmd = new SQLiteCommand("SELECT IngredientName FROM allIngredients", cs103);
                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string sName = reader["IngredientName"].ToString();
                    listBox1.Items.Add(sName);
                }
            }
        }

        private void add_c(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select an Item");
            }
            else
            {
                while (listBox1.SelectedItems.Count != 0)
                {
                    listBox2.Items.Add(listBox1.SelectedItems[0]);
                    listBox1.Items.Remove(listBox1.SelectedItems[0]);        
                }

            }
            ListCount();
        }

        private void ListCount()

        { 
                String ItemCount;
                ItemCount = listBox2.Items.Count.ToString();
                MessageBox.Show(ItemCount);
        }
    }
}
