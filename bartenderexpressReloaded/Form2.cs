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


            //if FavoritesDrinkButton.Enabled = True.... then do this, disable button in the end

            using (SQLiteConnection cs33 = new SQLiteConnection("Data Source = |DataDirectory|\\XpressShots.db"))
            {
                cs33.Open();

                //check to see if drink is already a favorite  SELECT favorite FROM drinks WHERE name = 'ABERFOYLE'

                //string  statusbarrecipe = Form1.DrinksNameBox.SelectedValue.ToString();
                SQLiteCommand cmd4 = new SQLiteCommand("SELECT favorite FROM drinks WHERE name ='" + (DrinkName.Trim().Replace("'", "''")) + "'", cs33);


                SQLiteDataReader rdr4 = cmd4.ExecuteReader();
                if (rdr4.Read())
                {
                    string FavoriteValue = rdr4[0].ToString();

                    //Convert.ToBoolean(FavoriteValue);
                    ////if the boolean result is the value of 1 from the FavoriteValue then... 

                    if (Convert.ToBoolean(FavoriteValue))
                    {
                        FavoritesDrinkButton.Enabled = false;
                    }
                }

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

            //using (SQLiteConnection cs36 = new SQLiteConnection("Data Source = |DataDirectory|\\XpressShots.db"))
            //{
            //    SQLiteCommand cmd3 = new SQLiteCommand("UPDATE " + FavoritesTable + " SET favorite = 1 WHERE name ='" + (FavoriteName.Trim().Replace("'", "''")) + "'", cs36);
            //    cs36.Open();
            //    cmd3.ExecuteNonQuery();
            //    cs36.Close();
            //}




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

    
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void calc(object sender, System.EventArgs e)
        {
            //Widmark Formula % BAC = (A x 5.14 / W x r) -.015 x H
             double A = Convert.ToDouble(valDrinks.Text);
            double W = Convert.ToDouble(valWeight.Text);
            double H = Convert.ToDouble(valHours.Text);
            double rFem = 0.66;
            double rmale = 0.73;
            double BAC;



            if (radFemale.Checked)
            {
                BAC = (A * 5.14) / (W * rFem) - .015 * H;
            }
            else
            {
                BAC = (A * 5.14) / (W * rmale) - .015 * H;
            }
            if (BAC < 0)
            {
                BAC = 0.00;
            }

            lblBAC.Text = (BAC.ToString("0.#####"));

            if (BAC >= 0.00 && BAC < 0.02)
            {
                lblAnalysis.Text = "Sober State";
                lblAnalysis2.Text = "";
                lblAnalysis3.Text = "";
            }

            if (BAC >= 0.02 && BAC < 0.05)
            {
                lblAnalysis.Text = "Loss of Judgment";
                lblAnalysis2.Text = "Trouble doing two tasks at the same time";
                lblAnalysis3.Text = "";
                lblBAC.ForeColor = Color.Black;
            }
            else if (BAC >= 0.05 && BAC < 0.08)
            {
                lblAnalysis.Text = "Reduced coordination and ability to track moving objects";
                lblAnalysis2.Text = "Difficulty steering";
                lblAnalysis3.Text = "";
                lblBAC.ForeColor = Color.Black;
            }
            else if (BAC >= 0.08 && BAC < 0.10)
            {
                lblAnalysis.Text = "Trouble controlling speed";
                lblAnalysis2.Text = "Difficulty processing information and reasoning";
                lblAnalysis3.Text = "0.08% and over is legally impaired in all states";
                lblBAC.ForeColor = Color.Red;
            }
            else if (BAC >= 0.10 && BAC < 0.15)
            {
                lblAnalysis.Text = "Markedly slowed reaction time";
                lblAnalysis2.Text = "Difficulty staying in lane and braking when needed";
                lblAnalysis3.Text = "0.08% and over is legally impaired in all states";
                lblBAC.ForeColor = Color.Red;
            }
            else if (BAC >= 0.15)
            {
                lblAnalysis.Text = "Serious difficulty controlling the car and focusing on driving";
                lblAnalysis2.Text = "0.08% and over is legally impaired in all states";
                lblAnalysis3.Text = "";
                lblBAC.ForeColor = Color.Red;
            }
        }
    }
}