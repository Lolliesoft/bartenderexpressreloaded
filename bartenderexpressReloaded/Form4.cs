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
    public partial class Form4 : Form
    {
        public Form4()
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
                SQLiteCommand cmd = new SQLiteCommand("SELECT name FROM liqueurs", cs103);
                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string sName = reader["name"].ToString();
                    listBox1.Items.Add(sName);
                }
            }
        }
    }
}
