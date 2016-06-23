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

        private string _favoritesName;

        public string FavoritesName
        {
            get 
            { return this._favoritesName; }

            set 
            { this._favoritesName = value; }
        }
        
        //check to see if drink is already a favorite
        //create method to check if already a favorite

        public void DrinkfavoriteCheck()
        {
           
            string FavoriteName = FavoritesButton.Name;
            FavoriteName = FavoriteName.Replace("'", "''");

            string FavoritesTable = FavoritesButton.Text;
            //check db to see if drinkname is a favorite
            using (SQLiteConnection cs240 = new SQLiteConnection("Data Source = |DataDirectory|\\Custom.db"))
            {
                cs240.Open();

                SQLiteCommand cmd = cs240.CreateCommand();

                cmd.Parameters.Add(new SQLiteParameter("@FavoriteName", FavoriteName));
                cmd.CommandText = "SELECT Name FROM Favorites WHERE name ='" + @FavoriteName + "'";

                SQLiteDataReader rdr240 = cmd.ExecuteReader();


                while (rdr240.Read())
                {

                    //MessageBox.Show(rdr230[0].ToString());
                    string firstValue = rdr240[0].ToString();
                    
                    if (string.IsNullOrEmpty(firstValue)  == false)

                        {
                            FavoritesButton.Enabled = false;
                        }
                    else
                        {
                            FavoritesButton.Enabled = true;
                        }
                }
                cs240.Close();
            }         
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DrinkfavoriteCheck();
            FavoritesButton.Enabled = false;
            string FavoriteName = FavoritesButton.Name;
            FavoriteName = FavoriteName.Replace("'", "''");
            string FavoritesTable = FavoritesButton.Text;

            if (FavoritesButton.Text == "myRecipes")
            {
                using (SQLiteConnection cs228 = new SQLiteConnection("Data Source = |DataDirectory|\\XpressShots.db"))
                {
                    cs228.Open();

                    if (FavoritesButton.Text == "myRecipes")
                    {
                        string FavoritesTablekey = FavoritesTable + "_key";

                        SQLiteCommand cmd = new SQLiteCommand("SELECT " + FavoritesTablekey + " FROM " + FavoritesTable + " WHERE name ='" + (FavoriteName) + "'", cs228);
                        SQLiteDataReader rdr1 = cmd.ExecuteReader();

                        if (rdr1.Read())
                        {

                            //MessageBox.Show(rdr1["FavoritesTablekey"].ToString());


                            SQLiteCommand cmd1 = new SQLiteCommand("SELECT name, amt1, amt2, amt3, amt4, amt5, amt6, amt7, amt8, amt9, amt10, amt11, amt12, amt13, amt14, amt15, directions," +
                                                                    "ingredient1, ingredient2, ingredient3, ingredient4, ingredient5, ingredient6, ingredient7, ingredient8, ingredient9," +
                                                                "ingredient10, ingredient11, ingredient12, ingredient13, ingredient14, ingredient15 FROM " + FavoritesTable + " WHERE " + FavoritesTablekey + "=" + (rdr1[FavoritesTablekey]) + "", cs228);
                            SQLiteDataReader rdring = cmd1.ExecuteReader();

                            using (SQLiteConnection cs240 = new SQLiteConnection("Data Source = |DataDirectory|\\Custom.db"))
                                if (rdring.Read())
                                {
                                    //MessageBox.Show(rdring[0].ToString());
                                    SQLiteCommand cmd2 = new SQLiteCommand();
                                    cmd2.CommandText = @"INSERT into Favorites (name, amt1, amt2, amt3, amt4, amt5, amt6, amt7, amt8, amt9, amt10, amt11, amt12, amt13, amt14, amt15, directions,
                                                            ingredient1, ingredient2, ingredient3, ingredient4, ingredient5, ingredient6, ingredient7, ingredient8, ingredient9,
                                                            ingredient10, ingredient11, ingredient12, ingredient13, ingredient14, ingredient15) 
                                     Values (@DrinkName,@Amt1,@Amt2,@Amt3,@Amt4,@Amt5,@Amt6,@Amt7,@Amt8,@Amt9,@Amt10,@Amt11,@Amt12,@Amt13,@Amt14,@Amt15,@Directions,
                                                            @Ing1,@Ing2,@Ing3,@Ing4,@Ing5,@Ing6,@Ing7,@Ing8,@Ing9,@Ing10,@Ing11,@Ing12,@Ing13,@Ing14,@Ing15)";

                                    cmd2.Connection = cs240;
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

                                    GC.Collect();
                                    GC.WaitForPendingFinalizers();
                                    cs240.Open();
                                    cmd2.ExecuteNonQuery();
                                    cs240.Close();
                                    cs228.Close();
                                    GC.Collect();
                                    GC.WaitForPendingFinalizers();
                                }
                        }
                    }
                }
            }

            else
            {
                using (SQLiteConnection cs221 = new SQLiteConnection("Data Source = |DataDirectory|\\XpressShots.db"))
                {
                    cs221.Open();

                    if (FavoritesButton.Text == "coffeetea")
                    {
                        string FavoritesTablekey = FavoritesTable + "_key";

                        SQLiteCommand cmd = new SQLiteCommand("SELECT " + FavoritesTablekey + " FROM " + FavoritesTable + " WHERE name ='" + (FavoriteName) + "'", cs221);
                        SQLiteDataReader rdr1 = cmd.ExecuteReader();

                        if (rdr1.Read())
                        {

                            //MessageBox.Show(rdr1["FavoritesTablekey"].ToString());

                            //MessageBox.Show(rdr1[FavoritesTablekey].ToString());

                            SQLiteCommand cmd1 = new SQLiteCommand("SELECT name, amt1, amt2, amt3, amt4, amt5, amt6, amt7, amt8, amt9, amt10, amt11, amt12, amt13, amt14, amt15, directions," +
                                                                    "ingredient1, ingredient2, ingredient3, ingredient4, ingredient5, ingredient6, ingredient7, ingredient8, ingredient9," +
                                                                "ingredient10, ingredient11, ingredient12, ingredient13, ingredient14, ingredient15 FROM " + FavoritesTable + " WHERE " + FavoritesTablekey + "=" + (rdr1[FavoritesTablekey]) + "", cs221);
                            SQLiteDataReader rdring = cmd1.ExecuteReader();

                            using (SQLiteConnection cs231 = new SQLiteConnection("Data Source = |DataDirectory|\\Custom.db"))
                                if (rdring.Read())
                                {
                                    //MessageBox.Show(rdring[0].ToString());
                                    SQLiteCommand cmd2 = new SQLiteCommand();
                                    cmd2.CommandText = @"INSERT into Favorites (name, amt1, amt2, amt3, amt4, amt5, amt6, amt7, amt8, amt9, amt10, amt11, amt12, amt13, amt14, amt15, directions,
                                                            ingredient1, ingredient2, ingredient3, ingredient4, ingredient5, ingredient6, ingredient7, ingredient8, ingredient9,
                                                            ingredient10, ingredient11, ingredient12, ingredient13, ingredient14, ingredient15) 
                                     Values (@DrinkName,@Amt1,@Amt2,@Amt3,@Amt4,@Amt5,@Amt6,@Amt7,@Amt8,@Amt9,@Amt10,@Amt11,@Amt12,@Amt13,@Amt14,@Amt15,@Directions,
                                                            @Ing1,@Ing2,@Ing3,@Ing4,@Ing5,@Ing6,@Ing7,@Ing8,@Ing9,@Ing10,@Ing11,@Ing12,@Ing13,@Ing14,@Ing15)";

                                    cmd2.Connection = cs231;
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

                                    GC.Collect();
                                    GC.WaitForPendingFinalizers();
                                    cs231.Open();
                                    cmd2.ExecuteNonQuery();
                                    cs231.Close();
                                    GC.Collect();
                                    GC.WaitForPendingFinalizers();
                                }
                        }
                    }

                    if (FavoritesButton.Text == "shots")
                    {
                        string FavoritesTablekey = FavoritesTable + "_key";

                        SQLiteCommand cmd = new SQLiteCommand("SELECT " + FavoritesTablekey + " FROM " + FavoritesTable + " WHERE name ='" + (@FavoriteName) + "'", cs221);
                        SQLiteDataReader rdr1 = cmd.ExecuteReader();

                        if (rdr1.Read())
                        {

                            //MessageBox.Show(rdr1["FavoritesTablekey"].ToString());


                            SQLiteCommand cmd1 = new SQLiteCommand("SELECT name, amt1, amt2, amt3, amt4, amt5, amt6, amt7, amt8, amt9, amt10, amt11, amt12, amt13, amt14, amt15, directions," +
                                                                    "ingredient1, ingredient2, ingredient3, ingredient4, ingredient5, ingredient6, ingredient7, ingredient8, ingredient9," +
                                                                "ingredient10, ingredient11, ingredient12, ingredient13, ingredient14, ingredient15 FROM " + FavoritesTable + " WHERE " + FavoritesTablekey + "=" + (rdr1[FavoritesTablekey]) + "", cs221);
                            SQLiteDataReader rdring = cmd1.ExecuteReader();

                            using (SQLiteConnection cs232 = new SQLiteConnection("Data Source = |DataDirectory|\\Custom.db"))
                                if (rdring.Read())
                                {
                                    //MessageBox.Show(rdring[0].ToString());
                                    SQLiteCommand cmd2 = new SQLiteCommand();
                                    cmd2.CommandText = @"INSERT into Favorites (name, amt1, amt2, amt3, amt4, amt5, amt6, amt7, amt8, amt9, amt10, amt11, amt12, amt13, amt14, amt15, directions,
                                                            ingredient1, ingredient2, ingredient3, ingredient4, ingredient5, ingredient6, ingredient7, ingredient8, ingredient9,
                                                            ingredient10, ingredient11, ingredient12, ingredient13, ingredient14, ingredient15) 
                                     Values (@DrinkName,@Amt1,@Amt2,@Amt3,@Amt4,@Amt5,@Amt6,@Amt7,@Amt8,@Amt9,@Amt10,@Amt11,@Amt12,@Amt13,@Amt14,@Amt15,@Directions,
                                                            @Ing1,@Ing2,@Ing3,@Ing4,@Ing5,@Ing6,@Ing7,@Ing8,@Ing9,@Ing10,@Ing11,@Ing12,@Ing13,@Ing14,@Ing15)";

                                    cmd2.Connection = cs232;
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

                                    GC.Collect();
                                    GC.WaitForPendingFinalizers();
                                    cs232.Open();
                                    cmd2.ExecuteNonQuery();
                                    cs232.Close();
                                    GC.Collect();
                                    GC.WaitForPendingFinalizers();
                                }
                        }
                    }

                    if (FavoritesButton.Text == "liqueurs")
                    {
                        //string FavoritesTablekey = FavoritesTable + "_key";
                        string FavoritesTablekey = FavoritesTable.TrimEnd('s') + "_key";

                        SQLiteCommand cmd3 = new SQLiteCommand("SELECT " + FavoritesTablekey + " FROM " + FavoritesTable + " WHERE name ='" + (FavoriteName) + "'", cs221);
                        SQLiteDataReader rdr1 = cmd3.ExecuteReader();

                        if (rdr1.Read())
                        {
                            // MessageBox.Show(rdr2[FavoritesTablekey].ToString());

                            SQLiteCommand cmd1 = new SQLiteCommand("SELECT name, amt1, amt2, amt3, amt4, amt5, amt6, amt7, amt8, amt9, amt10, amt11, amt12, amt13, amt14, amt15, directions," +
                                                                    "ingredient1, ingredient2, ingredient3, ingredient4, ingredient5, ingredient6, ingredient7, ingredient8, ingredient9," +
                                                                "ingredient10, ingredient11, ingredient12, ingredient13, ingredient14, ingredient15 FROM " + FavoritesTable + " WHERE " + FavoritesTablekey + "=" + (rdr1[FavoritesTablekey]) + "", cs221);
                            SQLiteDataReader rdring = cmd1.ExecuteReader();



                            using (SQLiteConnection cs233 = new SQLiteConnection("Data Source = |DataDirectory|\\Custom.db"))

                                if (rdring.Read())
                                {
                                    //MessageBox.Show(rdring[0].ToString());
                                    SQLiteCommand cmd2 = new SQLiteCommand();
                                    cmd2.CommandText = @"INSERT into Favorites (name, amt1, amt2, amt3, amt4, amt5, amt6, amt7, amt8, amt9, amt10, amt11, amt12, amt13, amt14, amt15, directions,
                                                            ingredient1, ingredient2, ingredient3, ingredient4, ingredient5, ingredient6, ingredient7, ingredient8, ingredient9,
                                                            ingredient10, ingredient11, ingredient12, ingredient13, ingredient14, ingredient15) 
                                     Values (@DrinkName,@Amt1,@Amt2,@Amt3,@Amt4,@Amt5,@Amt6,@Amt7,@Amt8,@Amt9,@Amt10,@Amt11,@Amt12,@Amt13,@Amt14,@Amt15,@Directions,
                                                            @Ing1,@Ing2,@Ing3,@Ing4,@Ing5,@Ing6,@Ing7,@Ing8,@Ing9,@Ing10,@Ing11,@Ing12,@Ing13,@Ing14,@Ing15)";

                                    cmd2.Connection = cs233;
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

                                    GC.Collect();
                                    GC.WaitForPendingFinalizers();
                                    cs233.Open();
                                    cmd2.ExecuteNonQuery();
                                    cs233.Close();
                                    GC.Collect();
                                    GC.WaitForPendingFinalizers();
                                }
                        }
                    }


                    else if (FavoritesButton.Text == "beers")
                    {
                        //string FavoritesTablekey = FavoritesTable + "_key";
                        string FavoritesTablekey = FavoritesTable.TrimEnd('s') + "_key";

                        SQLiteCommand cmd3 = new SQLiteCommand("SELECT " + FavoritesTablekey + " FROM " + FavoritesTable + " WHERE name ='" + (FavoriteName) + "'", cs221);
                        SQLiteDataReader rdr1 = cmd3.ExecuteReader();

                        if (rdr1.Read())
                        {
                            // MessageBox.Show(rdr2[FavoritesTablekey].ToString());

                            SQLiteCommand cmd1 = new SQLiteCommand("SELECT name, amt1, amt2, amt3, amt4, amt5, amt6, amt7, amt8, amt9, amt10, amt11, amt12, amt13, amt14, amt15, directions," +
                                                                    "ingredient1, ingredient2, ingredient3, ingredient4, ingredient5, ingredient6, ingredient7, ingredient8, ingredient9," +
                                                                "ingredient10, ingredient11, ingredient12, ingredient13, ingredient14, ingredient15 FROM " + FavoritesTable + " WHERE " + FavoritesTablekey + "=" + (rdr1[FavoritesTablekey]) + "", cs221);
                            SQLiteDataReader rdring = cmd1.ExecuteReader();



                            using (SQLiteConnection cs234 = new SQLiteConnection("Data Source = |DataDirectory|\\Custom.db"))

                                if (rdring.Read())
                                {
                                    //MessageBox.Show(rdring[0].ToString());
                                    SQLiteCommand cmd2 = new SQLiteCommand();
                                    cmd2.CommandText = @"INSERT into Favorites (name, amt1, amt2, amt3, amt4, amt5, amt6, amt7, amt8, amt9, amt10, amt11, amt12, amt13, amt14, amt15, directions,
                                                            ingredient1, ingredient2, ingredient3, ingredient4, ingredient5, ingredient6, ingredient7, ingredient8, ingredient9,
                                                            ingredient10, ingredient11, ingredient12, ingredient13, ingredient14, ingredient15) 
                                     Values (@DrinkName,@Amt1,@Amt2,@Amt3,@Amt4,@Amt5,@Amt6,@Amt7,@Amt8,@Amt9,@Amt10,@Amt11,@Amt12,@Amt13,@Amt14,@Amt15,@Directions,
                                                            @Ing1,@Ing2,@Ing3,@Ing4,@Ing5,@Ing6,@Ing7,@Ing8,@Ing9,@Ing10,@Ing11,@Ing12,@Ing13,@Ing14,@Ing15)";

                                    cmd2.Connection = cs234;
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

                                    GC.Collect();
                                    GC.WaitForPendingFinalizers();
                                    cs234.Open();
                                    cmd2.ExecuteNonQuery();
                                    cs234.Close();
                                    GC.Collect();
                                    GC.WaitForPendingFinalizers();
                                }
                        }
                    }

                    else if (FavoritesButton.Text == "cocktails")
                    {
                        //string FavoritesTablekey = FavoritesTable + "_key";
                        string FavoritesTablekey = FavoritesTable.TrimEnd('s') + "_key";

                        SQLiteCommand cmd3 = new SQLiteCommand("SELECT " + FavoritesTablekey + " FROM " + FavoritesTable + " WHERE name ='" + (FavoriteName) + "'", cs221);
                        SQLiteDataReader rdr1 = cmd3.ExecuteReader();

                        if (rdr1.Read())
                        {
                            // MessageBox.Show(rdr2[FavoritesTablekey].ToString());

                            SQLiteCommand cmd1 = new SQLiteCommand("SELECT name, amt1, amt2, amt3, amt4, amt5, amt6, amt7, amt8, amt9, amt10, amt11, amt12, amt13, amt14, amt15, directions," +
                                                                    "ingredient1, ingredient2, ingredient3, ingredient4, ingredient5, ingredient6, ingredient7, ingredient8, ingredient9," +
                                                                "ingredient10, ingredient11, ingredient12, ingredient13, ingredient14, ingredient15 FROM " + FavoritesTable + " WHERE " + FavoritesTablekey + "=" + (rdr1[FavoritesTablekey]) + "", cs221);
                            SQLiteDataReader rdring = cmd1.ExecuteReader();



                            using (SQLiteConnection cs235 = new SQLiteConnection("Data Source = |DataDirectory|\\Custom.db"))

                                if (rdring.Read())
                                {
                                    //MessageBox.Show(rdring[0].ToString());
                                    SQLiteCommand cmd2 = new SQLiteCommand();
                                    cmd2.CommandText = @"INSERT into Favorites (name, amt1, amt2, amt3, amt4, amt5, amt6, amt7, amt8, amt9, amt10, amt11, amt12, amt13, amt14, amt15, directions,
                                                            ingredient1, ingredient2, ingredient3, ingredient4, ingredient5, ingredient6, ingredient7, ingredient8, ingredient9,
                                                            ingredient10, ingredient11, ingredient12, ingredient13, ingredient14, ingredient15) 
                                     Values (@DrinkName,@Amt1,@Amt2,@Amt3,@Amt4,@Amt5,@Amt6,@Amt7,@Amt8,@Amt9,@Amt10,@Amt11,@Amt12,@Amt13,@Amt14,@Amt15,@Directions,
                                                            @Ing1,@Ing2,@Ing3,@Ing4,@Ing5,@Ing6,@Ing7,@Ing8,@Ing9,@Ing10,@Ing11,@Ing12,@Ing13,@Ing14,@Ing15)";

                                    cmd2.Connection = cs235;
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

                                    GC.Collect();
                                    GC.WaitForPendingFinalizers();
                                    cs235.Open();
                                    cmd2.ExecuteNonQuery();
                                    cs235.Close();
                                    GC.Collect();
                                    GC.WaitForPendingFinalizers();
                                }
                        }
                    }

                    else if (FavoritesButton.Text == "nonalcoholic")
                    {
                        string FavoritesTablekey = FavoritesTable + "_key";

                        SQLiteCommand cmd = new SQLiteCommand("SELECT " + FavoritesTablekey + " FROM " + FavoritesTable + " WHERE name ='" + (FavoriteName) + "'", cs221);
                        SQLiteDataReader rdr1 = cmd.ExecuteReader();

                        if (rdr1.Read())
                        {

                            //MessageBox.Show(rdr1["FavoritesTablekey"].ToString());

                            //MessageBox.Show(rdr1[FavoritesTablekey].ToString());

                            SQLiteCommand cmd1 = new SQLiteCommand("SELECT name, amt1, amt2, amt3, amt4, amt5, amt6, amt7, amt8, amt9, amt10, amt11, amt12, amt13, amt14, amt15, directions," +
                                                                    "ingredient1, ingredient2, ingredient3, ingredient4, ingredient5, ingredient6, ingredient7, ingredient8, ingredient9," +
                                                                "ingredient10, ingredient11, ingredient12, ingredient13, ingredient14, ingredient15 FROM " + FavoritesTable + " WHERE " + FavoritesTablekey + "=" + (rdr1[FavoritesTablekey]) + "", cs221);
                            SQLiteDataReader rdring = cmd1.ExecuteReader();

                            using (SQLiteConnection cs236 = new SQLiteConnection("Data Source = |DataDirectory|\\Custom.db"))
                                if (rdring.Read())
                                {
                                    //MessageBox.Show(rdring[0].ToString());
                                    SQLiteCommand cmd2 = new SQLiteCommand();
                                    cmd2.CommandText = @"INSERT into Favorites (name, amt1, amt2, amt3, amt4, amt5, amt6, amt7, amt8, amt9, amt10, amt11, amt12, amt13, amt14, amt15, directions,
                                                            ingredient1, ingredient2, ingredient3, ingredient4, ingredient5, ingredient6, ingredient7, ingredient8, ingredient9,
                                                            ingredient10, ingredient11, ingredient12, ingredient13, ingredient14, ingredient15) 
                                     Values (@DrinkName,@Amt1,@Amt2,@Amt3,@Amt4,@Amt5,@Amt6,@Amt7,@Amt8,@Amt9,@Amt10,@Amt11,@Amt12,@Amt13,@Amt14,@Amt15,@Directions,
                                                            @Ing1,@Ing2,@Ing3,@Ing4,@Ing5,@Ing6,@Ing7,@Ing8,@Ing9,@Ing10,@Ing11,@Ing12,@Ing13,@Ing14,@Ing15)";

                                    cmd2.Connection = cs236;
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

                                    GC.Collect();
                                    GC.WaitForPendingFinalizers();
                                    cs236.Open();
                                    cmd2.ExecuteNonQuery();
                                    cs236.Close();
                                    GC.Collect();
                                    GC.WaitForPendingFinalizers();
                                }
                        }
                    }

                    else if (FavoritesButton.Text == "punches")
                    {
                        //string FavoritesTablekey = FavoritesTable + "_key";
                        //string FavoritesTablekey = FavoritesTable.TrimEnd('e') + "_key";
                        string FavoritesTablekey = FavoritesTable.Remove(FavoritesTable.Length - 2) + "_key";

                        SQLiteCommand cmd3 = new SQLiteCommand("SELECT " + FavoritesTablekey + " FROM " + FavoritesTable + " WHERE name ='" + (FavoriteName) + "'", cs221);
                        SQLiteDataReader rdr1 = cmd3.ExecuteReader();

                        if (rdr1.Read())
                        {
                            // MessageBox.Show(rdr2[FavoritesTablekey].ToString());

                            SQLiteCommand cmd1 = new SQLiteCommand("SELECT name, amt1, amt2, amt3, amt4, amt5, amt6, amt7, amt8, amt9, amt10, amt11, amt12, amt13, amt14, amt15, directions," +
                                                                    "ingredient1, ingredient2, ingredient3, ingredient4, ingredient5, ingredient6, ingredient7, ingredient8, ingredient9," +
                                                                "ingredient10, ingredient11, ingredient12, ingredient13, ingredient14, ingredient15 FROM " + FavoritesTable + " WHERE " + FavoritesTablekey + "=" + (rdr1[FavoritesTablekey]) + "", cs221);
                            SQLiteDataReader rdring = cmd1.ExecuteReader();



                            using (SQLiteConnection cs237 = new SQLiteConnection("Data Source = |DataDirectory|\\Custom.db"))

                                if (rdring.Read())
                                {
                                    //MessageBox.Show(rdring[0].ToString());
                                    SQLiteCommand cmd2 = new SQLiteCommand();
                                    cmd2.CommandText = @"INSERT into Favorites (name, amt1, amt2, amt3, amt4, amt5, amt6, amt7, amt8, amt9, amt10, amt11, amt12, amt13, amt14, amt15, directions,
                                                            ingredient1, ingredient2, ingredient3, ingredient4, ingredient5, ingredient6, ingredient7, ingredient8, ingredient9,
                                                            ingredient10, ingredient11, ingredient12, ingredient13, ingredient14, ingredient15) 
                                     Values (@DrinkName,@Amt1,@Amt2,@Amt3,@Amt4,@Amt5,@Amt6,@Amt7,@Amt8,@Amt9,@Amt10,@Amt11,@Amt12,@Amt13,@Amt14,@Amt15,@Directions,
                                                            @Ing1,@Ing2,@Ing3,@Ing4,@Ing5,@Ing6,@Ing7,@Ing8,@Ing9,@Ing10,@Ing11,@Ing12,@Ing13,@Ing14,@Ing15)";

                                    cmd2.Connection = cs237;
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

                                    GC.Collect();
                                    GC.WaitForPendingFinalizers();
                                    cs237.Open();
                                    cmd2.ExecuteNonQuery();
                                    cs237.Close();
                                    GC.Collect();
                                    GC.WaitForPendingFinalizers();
                                }
                        }
                    }
                }
            }
                }
            
        private void tileItem1_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.lolliesoft.com");
        }

    }
}

