using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Windows.Forms;


namespace bartenderexpressReloaded
{
    class Connection
    {
        public void RandomConnection()
        {
            using (SQLiteConnection cs100 = new SQLiteConnection("Data Source = |DataDirectory|\\XpressShots.db"))
            {
                cs100.Open();
                SQLiteCommand cmd = new SQLiteCommand("SELECT name FROM recipes ORDER BY RANDOM() LIMIT 1", cs100);
                SQLiteDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show(reader["name"].ToString());
                }
            }                 
        }
    }
}