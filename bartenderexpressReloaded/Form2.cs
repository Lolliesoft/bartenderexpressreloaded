﻿using System;
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

    public partial class Form2 : Form
    {

        public Form2(string DrinkName, string tablename)
        {
            InitializeComponent();
            this.Refresh();
            FavoritesDrinkButton.Name = DrinkName;
            string FavoriteName = DrinkName;
            string FavoritesTable = tablename;
        }

       

        public string FavoriteName { get;  set; }
    
        

        public void DrinkfavoriteCheckForm1()
        {

            string FavoriteName = FavoritesDrinkButton.Name;
            FavoriteName = FavoriteName.Replace("'", "''");
           
            string FavoritesTable = FavoritesDrinkButton.Text;
            //check db to see if drinkname is a favorite
            using (SQLiteConnection cs230 = new SQLiteConnection("Data Source = |DataDirectory|\\Custom.db"))
            {
                cs230.Open();

                SQLiteCommand cmd = cs230.CreateCommand();

                cmd.Parameters.Add(new SQLiteParameter("@FavoriteName", FavoriteName));
                cmd.CommandText = "SELECT Name FROM Favorites WHERE name ='" + @FavoriteName + "'";

                SQLiteDataReader rdr230 = cmd.ExecuteReader();
                

                while (rdr230.Read())
                {

                    //MessageBox.Show(rdr230[0].ToString());
                    string firstValue = rdr230[0].ToString();

                    if (string.IsNullOrEmpty(firstValue) == false)

                    {
                        FavoritesDrinkButton.Enabled = false;
                    }
                    else
                    {
                        FavoritesDrinkButton.Enabled = true;
                    }
                }
                cs230.Close();
            }
        }

 

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                (sender as Form).Close();
        }

        private void FavoritesDrinkButton_Click(object sender, EventArgs e)
        {
            //check to see if button should be disabled, check if it has a favorite value of true

            
            FavoritesDrinkButton.Enabled = false;
            string FavoriteName = FavoritesDrinkButton.Name;
            string FavoritesTable = FavoritesDrinkButton.Text;

                using (SQLiteConnection cs31 = new SQLiteConnection("Data Source = |DataDirectory|\\XpressShots.db"))

               
                {if (FavoritesDrinkButton.Text == "drinks")
                 {
                    
                    string FavoritesTablekey = FavoritesTable.TrimEnd('s') + "_key";

                    SQLiteCommand cmd = new SQLiteCommand("SELECT " + FavoritesTablekey + " FROM " + FavoritesTable + " WHERE name ='" + (FavoriteName.Trim().Replace("'", "''")) + "'", cs31);
                    //Set Favorite to true
                

                    cs31.Open();
                    SQLiteDataReader rdr1 = cmd.ExecuteReader();

                    if (rdr1.Read())
                    {
                        
                        //MessageBox.Show(rdr1["FavoritesTablekey"].ToString());

                        //MessageBox.Show(rdr1[FavoritesTablekey].ToString());

                        SQLiteCommand cmd1 = new SQLiteCommand("SELECT name, amt1, amt2, amt3, amt4, amt5, amt6, amt7, amt8, amt9, amt10, amt11, amt12, amt13, amt14, amt15, directions," +
                                                                "ingredient1, ingredient2, ingredient3, ingredient4, ingredient5, ingredient6, ingredient7, ingredient8, ingredient9," +
                                                            "ingredient10, ingredient11, ingredient12, ingredient13, ingredient14, ingredient15 FROM " + FavoritesTable + " WHERE " + FavoritesTablekey + "=" + (rdr1[FavoritesTablekey]) + "", cs31);
                        SQLiteDataReader rdring = cmd1.ExecuteReader();
                    

                        using (SQLiteConnection cs32 = new SQLiteConnection("Data Source = |DataDirectory|\\Custom.db"))
                          
                            if (rdring.Read())
                            {
                                cs32.Close();
                                //cs32.Open();
                                //MessageBox.Show(rdring[0].ToString());
                                SQLiteCommand cmd2 = new SQLiteCommand();
                                cmd2.CommandText = @"INSERT into Favorites (name, amt1, amt2, amt3, amt4, amt5, amt6, amt7, amt8, amt9, amt10, amt11, amt12, amt13, amt14, amt15, directions,
                                                            ingredient1, ingredient2, ingredient3, ingredient4, ingredient5, ingredient6, ingredient7, ingredient8, ingredient9,
                                                            ingredient10, ingredient11, ingredient12, ingredient13, ingredient14, ingredient15) 
                                     Values (@DrinkName,@Amt1,@Amt2,@Amt3,@Amt4,@Amt5,@Amt6,@Amt7,@Amt8,@Amt9,@Amt10,@Amt11,@Amt12,@Amt13,@Amt14,@Amt15,@Directions,
                                                            @Ing1,@Ing2,@Ing3,@Ing4,@Ing5,@Ing6,@Ing7,@Ing8,@Ing9,@Ing10,@Ing11,@Ing12,@Ing13,@Ing14,@Ing15)";

                                cmd2.Connection = cs32;
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

                                cs32.Open();
                                cmd2.ExecuteNonQuery();
                                cs32.Close();
                                cs31.Close();
                            }
                    }
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bartenderExpressDataSet.recipes' table. You can move, or remove it, as needed.
            this.recipesTableAdapter.Fill(this.bartenderExpressDataSet.recipes);
        }

        private void tileItem1_ItemClick_2(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.lolliesoft.com");
        }

        public class emailDrink : Form1 
        {
            private void button1_Click(object sender, EventArgs e)
            {
              
            }


        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(Text);
            

            
            
        }
    }
}