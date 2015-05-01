using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace bartenderexpressReloaded
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Path.Combine(Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData), "Lolliesoft"));
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bartenderExpressDataSet.recipes' table. You can move, or remove it, as needed.
            this.recipesTableAdapter.Fill(this.bartenderExpressDataSet.recipes);

        }

        private void nameListCount(object sender, EventArgs e)
        {
            if (listBoxControl1.SelectedItem != null)
            {
                string statusbarrecipe = listBoxControl1.SelectedValue.ToString();


                using (SQLiteConnection conn = new SQLiteConnection("Data Source = |DataDirectory|\\bartenderExpress.db"))
                {
                    conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand("SELECT directions FROM recipes WHERE name='" + (statusbarrecipe.Trim().Replace("'", "''")) + "'", conn);
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    { MessageBox.Show(reader["directions"].ToString());
                    break;
                    }
                    
                    //MessageBox.Show(reader["id"].ToString());


                    //toolStripStatusLabel1.Text = "Drink " + reader["drink_num"].ToString() + " of " + (this.listBoxControl1.Items.Count.ToString());
                }
            }
        }
    }
}
