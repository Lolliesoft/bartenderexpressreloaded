using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Windows.Forms;


namespace bartenderexpressReloaded
{
    class favoritesRefresher
    {
        public void RefreshFavs()
        {
            using (SQLiteConnection cs101 = new SQLiteConnection("Data Source = |DataDirectory|\\Custom.db"))
            {

                SQLiteCommand cmd101 = new SQLiteCommand("SELECT * FROM Favorites", cs101);
                SQLiteDataReader reader = cmd101.ExecuteReader();
                if (reader.Read())
                {
                    using (SQLiteConnection cs102 = new SQLiteConnection("Data Source = |DataDirectory|\\XpressShots.db"))
                    {
                        // need to loop through array
                        SQLiteCommand cmd102 = new SQLiteCommand("UPDATE drinks  SET favorite = 1 WHERE name ='" + " rdring[*].ToString()", cs102);
                        cs102.Open();
                        cmd102.ExecuteNonQuery();
                        cs102.Close();
                    }

                }
            }
        }
    }
}