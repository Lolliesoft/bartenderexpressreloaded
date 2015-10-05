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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                (sender as Form).Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string FavoriteName = FavoritesButton.Name;
            string FavoritesTable = FavoritesButton.Text;

            using (SQLiteConnection cs22 = new SQLiteConnection("Data Source = |DataDirectory|\\XpressShots.db"))
            {
                cs22.Open();

                //Get ID
                //string selectedvalue

                //SQLiteCommand cmd = new SQLiteCommand("SELECT name, amt1, amt2, amt3, amt4, amt5, amt6, amt7, amt8, amt9, amt10, amt11, amt12, amt13, amt14, amt15, directions," +
                //                                  "ingredient1, ingredient2, ingredient3, ingredient4, ingredient5, ingredient6, ingredient7, ingredient8, ingredient9," +
                //                                        "ingredient10, ingredient11, ingredient12, ingredient13, ingredient14, ingredient15  FROM " + FavoritesTable + " WHERE name ='" + (FavoriteName.Trim().Replace("'", "''")) + "'", cs22);

                SQLiteCommand cmd = new SQLiteCommand("SELECT name, amt1, amt2, amt3, amt4, amt5, amt6, amt7, amt8, amt9, amt10, amt11, directions," +
                                                  "ingredient1, ingredient2, ingredient3, ingredient4, ingredient5, ingredient6, ingredient7, ingredient8, ingredient9," +
                                                        "ingredient10, ingredient11 FROM " + FavoritesTable + " WHERE name ='" + (FavoriteName.Trim().Replace("'", "''")) + "'", cs22);



                SQLiteDataReader reader = cmd.ExecuteReader();
                MessageBox.Show(reader["name"].ToString());
            }
        }
    }
}