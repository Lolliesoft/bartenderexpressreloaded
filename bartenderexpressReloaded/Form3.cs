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
            FavoritesButton.Enabled = false;
            string FavoriteName = FavoritesButton.Name;
            string FavoritesTable = FavoritesButton.Text;




            using (SQLiteConnection cs22 = new SQLiteConnection("Data Source = |DataDirectory|\\XpressShots.db"))
            {
                cs22.Open();

                if (FavoritesButton.Text == "coffeetea")
                {
                    string FavoritesTablekey = FavoritesTable + "_key";

                    SQLiteCommand cmd = new SQLiteCommand("SELECT " + FavoritesTablekey + " FROM " + FavoritesTable + " WHERE name ='" + (FavoriteName) + "'", cs22);
                    SQLiteDataReader rdr1 = cmd.ExecuteReader();

                    if (rdr1.Read())
                    {

                        //MessageBox.Show(rdr1["FavoritesTablekey"].ToString());

                        MessageBox.Show(rdr1[FavoritesTablekey].ToString());

                        SQLiteCommand cmd1 = new SQLiteCommand("SELECT name, amt1, amt2, amt3, amt4, amt5, amt6, amt7, amt8, amt9, amt10, amt11, amt12, amt13, amt14, amt15, directions," +
                                                                "ingredient1, ingredient2, ingredient3, ingredient4, ingredient5, ingredient6, ingredient7, ingredient8, ingredient9," +
                                                            "ingredient10, ingredient11, ingredient12, ingredient13, ingredient14, ingredient15 FROM " + FavoritesTable + " WHERE " + FavoritesTablekey + "=" + (rdr1[FavoritesTablekey]) + "", cs22);
                        SQLiteDataReader rdring = cmd1.ExecuteReader();

                        using (SQLiteConnection cs23 = new SQLiteConnection("Data Source = |DataDirectory|\\Custom.db"))
                            if (rdring.Read())
                            {
                                MessageBox.Show(rdring[0].ToString());
                                SQLiteCommand cmd2 = new SQLiteCommand();
                                cmd2.CommandText = @"INSERT into Favorites (name, amt1, amt2, amt3, amt4, amt5, amt6, amt7, amt8, amt9, amt10, amt11, amt12, amt13, amt14, amt15, directions,
                                                            ingredient1, ingredient2, ingredient3, ingredient4, ingredient5, ingredient6, ingredient7, ingredient8, ingredient9,
                                                            ingredient10, ingredient11, ingredient12, ingredient13, ingredient14, ingredient15) 
                                     Values (@DrinkName,@Amt1,@Amt2,@Amt3,@Amt4,@Amt5,@Amt6,@Amt7,@Amt8,@Amt9,@Amt10,@Amt11,@Amt12,@Amt13,@Amt14,@Amt15,@Directions,
                                                            @Ing1,@Ing2,@Ing3,@Ing4,@Ing5,@Ing6,@Ing7,@Ing8,@Ing9,@Ing10,@Ing11,@Ing12,@Ing13,@Ing14,@Ing15)";

                                cmd2.Connection = cs23;
                                //string DrinkName = rdring[0].ToString();
                                cmd2.Parameters.Add(new SQLiteParameter("@DrinkName", rdring[0]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Amt1", rdring[1]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Amt2", rdring[2]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Amt3", rdring[3]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Amt4", rdring[4]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Amt5", rdring[5]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Amt6", rdring[6]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Amt7", rdring[7]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Amt8", rdring[8]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Amt9", rdring[9]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Amt10", rdring[10]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Amt11", rdring[11]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Amt12", rdring[12]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Amt13", rdring[13]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Amt14", rdring[14]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Amt15", rdring[15]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Directions", rdring[16]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Ing1", rdring[17]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Ing2", rdring[18]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Ing3", rdring[19]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Ing4", rdring[20]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Ing5", rdring[21]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Ing6", rdring[22]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Ing7", rdring[23]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Ing8", rdring[24]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Ing9", rdring[25]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Ing10", rdring[26]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Ing11", rdring[27]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Ing12", rdring[28]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Ing13", rdring[29]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Ing14", rdring[30]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Ing15", rdring[31]));

                                cs23.Open();
                                cmd2.ExecuteNonQuery();
                                cs23.Close();
                            }
                    }
                }

                if (FavoritesButton.Text == "liqueurs")
                {
                    //string FavoritesTablekey = FavoritesTable + "_key";
                    string FavoritesTablekey = FavoritesTable.TrimEnd('s') + "_key";

                    SQLiteCommand cmd3 = new SQLiteCommand("SELECT " + FavoritesTablekey + " FROM " + FavoritesTable + " WHERE name ='" + (FavoriteName) + "'", cs22);
                    SQLiteDataReader rdr1 = cmd3.ExecuteReader();

                    if (rdr1.Read())
                    {
                        // MessageBox.Show(rdr2[FavoritesTablekey].ToString());

                        SQLiteCommand cmd1 = new SQLiteCommand("SELECT name, amt1, amt2, amt3, amt4, amt5, amt6, amt7, amt8, amt9, amt10, amt11, amt12, amt13, amt14, amt15, directions," +
                                                                "ingredient1, ingredient2, ingredient3, ingredient4, ingredient5, ingredient6, ingredient7, ingredient8, ingredient9," +
                                                            "ingredient10, ingredient11, ingredient12, ingredient13, ingredient14, ingredient15 FROM " + FavoritesTable + " WHERE " + FavoritesTablekey + "=" + (rdr1[FavoritesTablekey]) + "", cs22);
                        SQLiteDataReader rdring = cmd1.ExecuteReader();



                        using (SQLiteConnection cs23 = new SQLiteConnection("Data Source = |DataDirectory|\\Custom.db"))

                            if (rdring.Read())
                            {
                                MessageBox.Show(rdring[0].ToString());
                                SQLiteCommand cmd2 = new SQLiteCommand();
                                cmd2.CommandText = @"INSERT into Favorites (name, amt1, amt2, amt3, amt4, amt5, amt6, amt7, amt8, amt9, amt10, amt11, amt12, amt13, amt14, amt15, directions,
                                                            ingredient1, ingredient2, ingredient3, ingredient4, ingredient5, ingredient6, ingredient7, ingredient8, ingredient9,
                                                            ingredient10, ingredient11, ingredient12, ingredient13, ingredient14, ingredient15) 
                                     Values (@DrinkName,@Amt1,@Amt2,@Amt3,@Amt4,@Amt5,@Amt6,@Amt7,@Amt8,@Amt9,@Amt10,@Amt11,@Amt12,@Amt13,@Amt14,@Amt15,@Directions,
                                                            @Ing1,@Ing2,@Ing3,@Ing4,@Ing5,@Ing6,@Ing7,@Ing8,@Ing9,@Ing10,@Ing11,@Ing12,@Ing13,@Ing14,@Ing15)";

                                cmd2.Connection = cs23;
                                //string DrinkName = rdring[0].ToString();
                                cmd2.Parameters.Add(new SQLiteParameter("@DrinkName", rdring[0]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Amt1", rdring[1]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Amt2", rdring[2]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Amt3", rdring[3]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Amt4", rdring[4]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Amt5", rdring[5]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Amt6", rdring[6]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Amt7", rdring[7]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Amt8", rdring[8]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Amt9", rdring[9]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Amt10", rdring[10]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Amt11", rdring[11]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Amt12", rdring[12]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Amt13", rdring[13]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Amt14", rdring[14]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Amt15", rdring[15]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Directions", rdring[16]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Ing1", rdring[17]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Ing2", rdring[18]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Ing3", rdring[19]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Ing4", rdring[20]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Ing5", rdring[21]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Ing6", rdring[22]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Ing7", rdring[23]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Ing8", rdring[24]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Ing9", rdring[25]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Ing10", rdring[26]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Ing11", rdring[27]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Ing12", rdring[28]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Ing13", rdring[29]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Ing14", rdring[30]));
                                cmd2.Parameters.Add(new SQLiteParameter("@Ing15", rdring[31]));

                                cs23.Open();
                                cmd2.ExecuteNonQuery();
                                cs23.Close();
                            }
                    }
                }
            }
        }
    }
}

