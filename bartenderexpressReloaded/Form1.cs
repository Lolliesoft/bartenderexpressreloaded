﻿using System;
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
using AutoUpdaterDotNET;
using DevExpress.XtraEditors;



//using DevExpress.XtraBars.Docking;

namespace bartenderexpressReloaded
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Path.Combine(Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData), "Lolliesoft"));
            InitializeComponent();
            //Find the MdiClient and hold it by a variable
            client = Controls.OfType<MdiClient>().First();
            //This will check whenever client gets focused and there aren't any
            //child forms opened, Send the client to back so that the other controls can be shown back.
            client.GotFocus += (s, e) =>
            {
                if (!MdiChildren.Any(x => x.Visible)) client.SendToBack();


                //DrinksNameBox.Show();
                //ShotsNameBox.Hide();
                //LiqueursNameBox.Hide();
                //PunchesNameBox.Hide();
                //CocktailsNameBox.Hide();
                //BeerAleNameBox.Hide();
                //NonAlcoholicNameBox.Hide();
                //CoffeeTeaNameBox.Hide();
            };
        }
        MdiClient client;


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myRecipes.myRecipes' table. You can move, or remove it, as needed.
            this.myRecipesTableAdapter.Fill(this.myRecipes.myRecipes);
            // TODO: This line of code loads data into the 'xpressShotsDataSet.recipes' table. You can move, or remove it, as needed.
            this.recipesTableAdapter1.Fill(this.xpressShotsDataSet.recipes);
            // TODO: This line of code loads data into the 'xpressShotsDataSet.coffeetea' table. You can move, or remove it, as needed.
            this.coffeeteaTableAdapter.Fill(this.xpressShotsDataSet.coffeetea);
            // TODO: This line of code loads data into the 'xpressShotsDataSet.nonalcoholic' table. You can move, or remove it, as needed.
            this.nonalcoholicTableAdapter.Fill(this.xpressShotsDataSet.nonalcoholic);
            // TODO: This line of code loads data into the 'xpressShotsDataSet.beers' table. You can move, or remove it, as needed.
            this.beersTableAdapter.Fill(this.xpressShotsDataSet.beers);
            // TODO: This line of code loads data into the 'xpressShotsDataSet.cocktails' table. You can move, or remove it, as needed.
            this.cocktailsTableAdapter.Fill(this.xpressShotsDataSet.cocktails);
            // TODO: This line of code loads data into the 'xpressShotsDataSet.punches' table. You can move, or remove it, as needed.
            this.punchesTableAdapter.Fill(this.xpressShotsDataSet.punches);
            // TODO: This line of code loads data into the 'xpressShotsDataSet.liqueurs' table. You can move, or remove it, as needed.
            this.liqueursTableAdapter.Fill(this.xpressShotsDataSet.liqueurs);
            // TODO: This line of code loads data into the 'xpressShotsDataSet.shots' table. You can move, or remove it, as needed.
            this.shotsTableAdapter.Fill(this.xpressShotsDataSet.shots);
            // TODO: This line of code loads data into the 'bartenderExpressDataSet.recipes' table. You can move, or remove it, as needed.
            this.recipesTableAdapter.Fill(this.bartenderExpressDataSet.recipes);
            CueProvider CreateaCue = new CueProvider();
            CreateaCue.SetCue(DrinkSearch, "Search Drinks");
            CreateaCue.SetCue(ShotSearch, "Search Shots");
            CreateaCue.SetCue(LiqueurSearch, "Search Liqueurs");
            CreateaCue.SetCue(PunchSearch, "Search Punches");
            CreateaCue.SetCue(BeerSearch, "Search Beer and Ales");
            CreateaCue.SetCue(CoffeeTeaSearch, "Search Coffee and Teas");
            CreateaCue.SetCue(NonAlcoholicSearch, "Search Non-Alcoholic Drinks");
            CreateaCue.SetCue(CocktailSearch, "Search Cocktails");
            CreateaCue.SetCue(CustomSearch, "Search Your Recipes");
        }

        private void nameListCount(object sender, EventArgs e)
        {
            if (DrinksNameBox.SelectedItem != null)
            {
                string statusbarrecipe = DrinksNameBox.SelectedValue.ToString();


                using (SQLiteConnection conn = new SQLiteConnection("Data Source = |DataDirectory|\\XpressShots.db"))
                {
                    conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand("SELECT drink_num FROM recipes WHERE name='" + (statusbarrecipe.Trim().Replace("'", "''")) + "'", conn);
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        //MessageBox.Show(this.DrinksNameBox.ItemCount.ToString());
                        toolStripStatusLabel1.Text = "Drink " + reader["drink_num"].ToString() + " of " + (this.DrinksNameBox.ItemCount.ToString());

                    }
                }
            }


        }

        private void ShotListCount(object sender, EventArgs e)
        {
            if (ShotsNameBox.SelectedItem != null)
            {
                string statusbarrecipe = ShotsNameBox.SelectedValue.ToString();


                using (SQLiteConnection conn = new SQLiteConnection("Data Source = |DataDirectory|\\XpressShots.db"))
                {
                    conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand("SELECT shots_key FROM shots WHERE name='" + (statusbarrecipe.Trim().Replace("'", "''")) + "'", conn);
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        //MessageBox.Show(this.DrinksNameBox.ItemCount.ToString());
                        toolStripStatusLabel1.Text = "Shot " + reader["shots_key"].ToString() + " of " + (this.ShotsNameBox.ItemCount.ToString());

                    }
                }
            }

        }

        private void LiqueursListCount(object sender, EventArgs e)
        {
            //MessageBox.Show("hello");
            if (LiqueursNameBox.SelectedItem != null)
            {
                string statusbarrecipe = LiqueursNameBox.SelectedValue.ToString();


                using (SQLiteConnection conn = new SQLiteConnection("Data Source = |DataDirectory|\\XpressShots.db"))
                {
                    conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand("SELECT liqueur_key FROM liqueurs WHERE name ='" + statusbarrecipe + "'", conn);
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        toolStripStatusLabel1.Text = "Liqueurs " + reader["liqueur_key"].ToString() + " of " + (this.LiqueursNameBox.ItemCount.ToString());
                    }
                }
            }
        }

        private void PunchesListCount(object sender, EventArgs e)
        {
            if (PunchesNameBox.SelectedItem != null)
            {
                string statusbarrecipe = PunchesNameBox.SelectedValue.ToString();


                using (SQLiteConnection conn = new SQLiteConnection("Data Source = |DataDirectory|\\XpressShots.db"))
                {
                    conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand("SELECT punch_key FROM punches WHERE name='" + (statusbarrecipe.Trim().Replace("'", "''")) + "'", conn);
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        //MessageBox.Show(this.DrinksNameBox.ItemCount.ToString());
                        toolStripStatusLabel1.Text = "Punch " + reader["punch_key"].ToString() + " of " + (this.PunchesNameBox.ItemCount.ToString());

                    }
                }
            }
        }

        private void BeerListCount(object sender, EventArgs e)
        {
            if (BeerAleNameBox.SelectedItem != null)
            {
                string statusbarrecipe = BeerAleNameBox.SelectedValue.ToString();


                using (SQLiteConnection conn = new SQLiteConnection("Data Source = |DataDirectory|\\XpressShots.db"))
                {
                    conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand("SELECT beer_key FROM beers WHERE name ='" + (statusbarrecipe.Trim().Replace("'", "''")) + "'", conn);
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        toolStripStatusLabel1.Text = "Beer " + reader["beer_key"].ToString() + " of " + (this.BeerAleNameBox.ItemCount.ToString());
                    }

                }
            }
        }

        private void NonAlcoholicListCount(object sender, EventArgs e)
        {
            if (NonAlcoholicNameBox.SelectedItem != null)
            {
                string statusbarrecipe = NonAlcoholicNameBox.SelectedValue.ToString();


                using (SQLiteConnection conn7 = new SQLiteConnection("Data Source = |DataDirectory|\\XpressShots.db"))
                {
                    conn7.Open();
                    SQLiteCommand cmd = new SQLiteCommand("SELECT nonalcoholic_key FROM nonalcoholic WHERE name ='" + (statusbarrecipe.Trim().Replace("'", "''")) + "'", conn7);
                    SQLiteDataReader reader = cmd.ExecuteReader();



                    while (reader.Read())
                    {
                        toolStripStatusLabel1.Text = "Non Alcoholic Recipe " + reader["nonalcoholic_key"].ToString() + " of " + (this.NonAlcoholicNameBox.ItemCount.ToString());
                    }
                }

            }
        }

        private void CoffeeTeaListCount(object sender, EventArgs e)
        {
            if (CoffeeTeaNameBox.SelectedItem != null)
            {
                string statusbarrecipe = CoffeeTeaNameBox.SelectedValue.ToString();


                using (SQLiteConnection conn6 = new SQLiteConnection("Data Source = |DataDirectory|\\XpressShots.db"))
                {
                    conn6.Open();
                    SQLiteCommand cmd = new SQLiteCommand("SELECT coffeetea_key FROM coffeetea WHERE name ='" + statusbarrecipe + "'", conn6);
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        toolStripStatusLabel1.Text = "Coffee/Tea Recipe " + reader["coffeetea_key"].ToString() + " of " + (this.CoffeeTeaNameBox.ItemCount.ToString());
                    }
                }
            }
        }

        private void CustomListCount(object sender, EventArgs e)
        {
            if (CustomNameBox.SelectedItem != null)
            {
                string statusbarrecipe = CustomNameBox.SelectedValue.ToString();


                using (SQLiteConnection conn6 = new SQLiteConnection("Data Source = |DataDirectory|\\XpressShots.db"))
                {
                    conn6.Open();
                    SQLiteCommand cmd = new SQLiteCommand("SELECT myrecipes_key FROM myRecipes WHERE name ='" + statusbarrecipe + "'", conn6);
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        toolStripStatusLabel1.Text = "Custom Recipe " + reader["myrecipes_key"].ToString() + " of " + (this.CustomNameBox.ItemCount.ToString());
                    }
                }
            }
        }

        private void DrinksNameBox_DoubleClick(object sender, EventArgs e)
        {

            if (DrinksNameBox.SelectedItem != null)
            {
                string statusbarrecipe = DrinksNameBox.SelectedValue.ToString();
                toolStripStatusLabel1.Text = statusbarrecipe;

                //toolStripStatusLabel2.Text = (this.nameListBox.Items.Count.ToString());

                using (SQLiteConnection cs = new SQLiteConnection("Data Source = |DataDirectory|\\bartenderExpress.db"))
                {
                    cs.Open();

                    //Get ID
                    SQLiteCommand cmd = new SQLiteCommand("SELECT id FROM recipes WHERE name='" + (statusbarrecipe.Trim().Replace("'", "''")) + "'", cs);
                    //SQLiteCommand cmd = new SQLiteCommand("SELECT id FROM recipes WHERE name ='" + statusbarrecipe + "'", cs);
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    //MessageBox.Show(reader["id"].ToString());

                    Form2 child = new Form2();
                    child.Text = DrinksNameBox.SelectedValue.ToString();
                    //child.toolStripStatusLabel1.Text = statusbarrecipe;

                    child.MdiParent = this;
                    client.BringToFront();//This will make your child form shown on top.
                    child.Show();


                    while (reader.Read())
                    {
                        // Get Ingredients
                        SQLiteCommand cmding = new SQLiteCommand("SELECT name FROM ingredients INNER JOIN recipeingredients ON ingredients.id=recipeingredients.ingid WHERE recipeid=" + (reader["id"]) + "", cs);
                        SQLiteDataReader rdring = cmding.ExecuteReader();

                        while (rdring.Read())
                        {
                            ListViewItem ingredients = new ListViewItem();
                            ingredients.SubItems[0].Text = rdring[0].ToString();
                            child.listView2.Items.Add(ingredients);

                        }
                        //Get Amounts
                        SQLiteCommand cmdamt = new SQLiteCommand("SELECT amount FROM recipeingredients INNER JOIN ingredients ON ingredients.id=recipeingredients.ingid WHERE recipeid=" + (reader["id"]) + "", cs);
                        SQLiteDataReader rdramt = cmdamt.ExecuteReader();

                        while (rdramt.Read())
                        {
                            ListViewItem amount = new ListViewItem();
                            amount.SubItems[0].Text = rdramt[0].ToString();
                            child.listView1.Items.Add(amount);
                        }

                        //Get Directions
                        SQLiteCommand cmddir = new SQLiteCommand("SELECT directions FROM recipes WHERE id = " + (reader["id"]) + "", cs);
                        SQLiteDataReader rdr = cmddir.ExecuteReader();

                        while (rdr.Read())
                        {
                            child.richTextBox1.Text = rdr[0].ToString();
                        }


                    }
                }

            }
        }


        private void ShotsNameBox_DoubleClick(object sender, EventArgs e)
        {
            if (ShotsNameBox.SelectedItem != null)
            {

                string statusbarrecipe2 = ShotsNameBox.SelectedValue.ToString();
                toolStripStatusLabel1.Text = statusbarrecipe2;


                using (SQLiteConnection cs2 = new SQLiteConnection("Data Source = |DataDirectory|\\XpressShots.db"))
                {
                    cs2.Open();


                    //Get ID
                    //string selectedvalue

                    SQLiteCommand cmd = new SQLiteCommand("SELECT shots_key FROM shots WHERE name ='" + (statusbarrecipe2.Trim().Replace("'", "''")) + "'", cs2);
                    //SQLiteCommand cmd = new SQLiteCommand("SELECT id FROM recipes WHERE name ='" + statusbarrecipe + "'", cs);
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    //MessageBox.Show(reader["id"].ToString());

                    Form2 child = new Form2();
                    child.Text = ShotsNameBox.SelectedValue.ToString();
                    //child.toolStripStatusLabel1.Text = statusbarrecipe;

                    child.MdiParent = this;
                    client.BringToFront();//This will make your child form shown on top.
                    child.Show();

                    while (reader.Read())
                    {
                        // Get Ingredients
                        SQLiteCommand cmding = new SQLiteCommand("SELECT ingredient1, ingredient2, ingredient3, ingredient4, ingredient5, ingredient6, ingredient7, ingredient8, ingredient9, ingredient10, ingredient11 FROM shots WHERE shots_key=" + (reader["shots_key"]) + "", cs2);
                        SQLiteDataReader rdring = cmding.ExecuteReader();

                        while (rdring.Read())
                        {
                            ListViewItem ingredient1 = new ListViewItem();
                            ingredient1.SubItems[0].Text = rdring[0].ToString();
                            child.listView2.Items.Add(ingredient1);

                            ListViewItem ingredient2 = new ListViewItem();
                            ingredient2.SubItems[0].Text = rdring[1].ToString();
                            child.listView2.Items.Add(ingredient2);

                            ListViewItem ingredient3 = new ListViewItem();
                            ingredient3.SubItems[0].Text = rdring[2].ToString();
                            child.listView2.Items.Add(ingredient3);

                            ListViewItem ingredient4 = new ListViewItem();
                            ingredient4.SubItems[0].Text = rdring[3].ToString();
                            child.listView2.Items.Add(ingredient4);

                            ListViewItem ingredient5 = new ListViewItem();
                            ingredient5.SubItems[0].Text = rdring[4].ToString();
                            child.listView2.Items.Add(ingredient5);

                            ListViewItem ingredient6 = new ListViewItem();
                            ingredient6.SubItems[0].Text = rdring[5].ToString();
                            child.listView2.Items.Add(ingredient6);

                            ListViewItem ingredient7 = new ListViewItem();
                            ingredient7.SubItems[0].Text = rdring[6].ToString();
                            child.listView2.Items.Add(ingredient7);

                            ListViewItem ingredient8 = new ListViewItem();
                            ingredient8.SubItems[0].Text = rdring[7].ToString();
                            child.listView2.Items.Add(ingredient8);

                            ListViewItem ingredient9 = new ListViewItem();
                            ingredient9.SubItems[0].Text = rdring[8].ToString();
                            child.listView2.Items.Add(ingredient9);

                            ListViewItem ingredient10 = new ListViewItem();
                            ingredient10.SubItems[0].Text = rdring[9].ToString();
                            child.listView2.Items.Add(ingredient10);

                            ListViewItem ingredient11 = new ListViewItem();
                            ingredient11.SubItems[0].Text = rdring[10].ToString();
                            child.listView2.Items.Add(ingredient11);
                        }
                        //Get Amounts
                        SQLiteCommand cmdamt = new SQLiteCommand("SELECT amt1, amt2, amt3, amt4, amt5, amt6, amt7, amt8, amt9, amt10, amt11 FROM shots WHERE shots_key=" + (reader["shots_key"]) + "", cs2);
                        SQLiteDataReader rdramt = cmdamt.ExecuteReader();

                        while (rdramt.Read())
                        {
                            ListViewItem amt1 = new ListViewItem();
                            amt1.SubItems[0].Text = rdramt[0].ToString();
                            //amount.SubItems.Add(rdramt[0].ToString());
                            child.listView1.Items.Add(amt1);

                            ListViewItem amt2 = new ListViewItem();
                            amt2.SubItems[0].Text = rdramt[1].ToString();
                            child.listView1.Items.Add(amt2);

                            ListViewItem amt3 = new ListViewItem();
                            amt3.SubItems[0].Text = rdramt[2].ToString();
                            child.listView1.Items.Add(amt3);

                            ListViewItem amt4 = new ListViewItem();
                            amt4.SubItems[0].Text = rdramt[3].ToString();
                            child.listView1.Items.Add(amt4);

                            ListViewItem amt5 = new ListViewItem();
                            amt5.SubItems[0].Text = rdramt[4].ToString();
                            child.listView1.Items.Add(amt5);

                            ListViewItem amt6 = new ListViewItem();
                            amt6.SubItems[0].Text = rdramt[5].ToString();
                            child.listView1.Items.Add(amt6);

                            ListViewItem amt7 = new ListViewItem();
                            amt7.SubItems[0].Text = rdramt[6].ToString();
                            child.listView1.Items.Add(amt7);

                            ListViewItem amt8 = new ListViewItem();
                            amt8.SubItems[0].Text = rdramt[7].ToString();
                            child.listView1.Items.Add(amt8);

                            ListViewItem amt9 = new ListViewItem();
                            amt9.SubItems[0].Text = rdramt[8].ToString();
                            child.listView1.Items.Add(amt9);

                            ListViewItem amt10 = new ListViewItem();
                            amt10.SubItems[0].Text = rdramt[9].ToString();
                            child.listView1.Items.Add(amt10);

                            ListViewItem amt11 = new ListViewItem();
                            amt11.SubItems[0].Text = rdramt[10].ToString();
                            child.listView1.Items.Add(amt11);

                        }

                        //Get Directions
                        SQLiteCommand cmddir = new SQLiteCommand("SELECT directions FROM shots WHERE shots_key = " + (reader["shots_key"]) + "", cs2);
                        SQLiteDataReader rdr = cmddir.ExecuteReader();

                        while (rdr.Read())
                        {
                            child.richTextBox1.Text = rdr[0].ToString();
                        }

                    }

                    //MessageBox.Show(reader["id"].ToString());


                    //toolStripStatusLabel1.Text = "Drink " + reader["drink_num"].ToString() + " of " + (this.listBoxControl1.Items.Count.ToString());
                }
            }
        }

        private void LiqueursNameBox_DoubleClick(object sender, EventArgs e)
        {
            if (LiqueursNameBox.SelectedItem != null)
            {
                string statusbarrecipe3 = LiqueursNameBox.SelectedValue.ToString();


                using (SQLiteConnection cs3 = new SQLiteConnection("Data Source = |DataDirectory|\\XpressShots.db"))
                {
                    cs3.Open();


                    //Get ID
                    //string selectedvalue

                    SQLiteCommand cmd = new SQLiteCommand("SELECT liqueur_key FROM liqueurs WHERE name ='" + statusbarrecipe3 + "'", cs3);
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    //MessageBox.Show(reader["id"].ToString());

                    Form2 child = new Form2();
                    child.Text = LiqueursNameBox.SelectedValue.ToString();
                    //child.toolStripStatusLabel1.Text = statusbarrecipe;

                    child.MdiParent = this;
                    client.BringToFront();//This will make your child form shown on top.
                    child.Show();

                    while (reader.Read())
                    {
                        // Get Ingredients
                        SQLiteCommand cmding = new SQLiteCommand("SELECT ingredient1, ingredient2, ingredient3, ingredient4, ingredient5, ingredient6, ingredient7, ingredient8, ingredient9, ingredient10, ingredient11, ingredient12 FROM liqueurs WHERE liqueur_key=" + (reader["liqueur_key"]) + "", cs3);
                        SQLiteDataReader rdring = cmding.ExecuteReader();

                        while (rdring.Read())
                        {
                            ListViewItem ingredient1 = new ListViewItem();
                            ingredient1.SubItems[0].Text = rdring[0].ToString();
                            child.listView2.Items.Add(ingredient1);

                            ListViewItem ingredient2 = new ListViewItem();
                            ingredient2.SubItems[0].Text = rdring[1].ToString();
                            child.listView2.Items.Add(ingredient2);

                            ListViewItem ingredient3 = new ListViewItem();
                            ingredient3.SubItems[0].Text = rdring[2].ToString();
                            child.listView2.Items.Add(ingredient3);

                            ListViewItem ingredient4 = new ListViewItem();
                            ingredient4.SubItems[0].Text = rdring[3].ToString();
                            child.listView2.Items.Add(ingredient4);

                            ListViewItem ingredient5 = new ListViewItem();
                            ingredient5.SubItems[0].Text = rdring[4].ToString();
                            child.listView2.Items.Add(ingredient5);

                            ListViewItem ingredient6 = new ListViewItem();
                            ingredient6.SubItems[0].Text = rdring[5].ToString();
                            child.listView2.Items.Add(ingredient6);

                            ListViewItem ingredient7 = new ListViewItem();
                            ingredient7.SubItems[0].Text = rdring[6].ToString();
                            child.listView2.Items.Add(ingredient7);

                            ListViewItem ingredient8 = new ListViewItem();
                            ingredient8.SubItems[0].Text = rdring[7].ToString();
                            child.listView2.Items.Add(ingredient8);

                            ListViewItem ingredient9 = new ListViewItem();
                            ingredient9.SubItems[0].Text = rdring[8].ToString();
                            child.listView2.Items.Add(ingredient9);

                            ListViewItem ingredient10 = new ListViewItem();
                            ingredient10.SubItems[0].Text = rdring[9].ToString();
                            child.listView2.Items.Add(ingredient10);

                            ListViewItem ingredient11 = new ListViewItem();
                            ingredient11.SubItems[0].Text = rdring[10].ToString();
                            child.listView2.Items.Add(ingredient11);

                            ListViewItem ingredient12 = new ListViewItem();
                            ingredient12.SubItems[0].Text = rdring[11].ToString();
                            child.listView2.Items.Add(ingredient12);

                        }
                        //Get Amounts
                        SQLiteCommand cmdamt = new SQLiteCommand("SELECT amt1, amt2, amt3, amt4, amt5, amt6, amt7, amt8, amt9, amt10, amt11, amt12 FROM liqueurs WHERE liqueur_key=" + (reader["liqueur_key"]) + "", cs3);
                        SQLiteDataReader rdramt = cmdamt.ExecuteReader();

                        while (rdramt.Read())
                        {
                            ListViewItem amt1 = new ListViewItem();
                            amt1.SubItems[0].Text = rdramt[0].ToString();
                            //amount.SubItems.Add(rdramt[0].ToString());
                            child.listView1.Items.Add(amt1);

                            ListViewItem amt2 = new ListViewItem();
                            amt2.SubItems[0].Text = rdramt[1].ToString();
                            child.listView1.Items.Add(amt2);

                            ListViewItem amt3 = new ListViewItem();
                            amt3.SubItems[0].Text = rdramt[2].ToString();
                            child.listView1.Items.Add(amt3);

                            ListViewItem amt4 = new ListViewItem();
                            amt4.SubItems[0].Text = rdramt[3].ToString();
                            child.listView1.Items.Add(amt4);

                            ListViewItem amt5 = new ListViewItem();
                            amt5.SubItems[0].Text = rdramt[4].ToString();
                            child.listView1.Items.Add(amt5);

                            ListViewItem amt6 = new ListViewItem();
                            amt6.SubItems[0].Text = rdramt[5].ToString();
                            child.listView1.Items.Add(amt6);

                            ListViewItem amt7 = new ListViewItem();
                            amt7.SubItems[0].Text = rdramt[6].ToString();
                            child.listView1.Items.Add(amt7);

                            ListViewItem amt8 = new ListViewItem();
                            amt8.SubItems[0].Text = rdramt[7].ToString();
                            child.listView1.Items.Add(amt8);

                            ListViewItem amt9 = new ListViewItem();
                            amt9.SubItems[0].Text = rdramt[8].ToString();
                            child.listView1.Items.Add(amt9);

                            ListViewItem amt10 = new ListViewItem();
                            amt10.SubItems[0].Text = rdramt[9].ToString();
                            child.listView1.Items.Add(amt10);

                            ListViewItem amt11 = new ListViewItem();
                            amt11.SubItems[0].Text = rdramt[10].ToString();
                            child.listView1.Items.Add(amt11);

                            ListViewItem amt12 = new ListViewItem();
                            amt12.SubItems[0].Text = rdramt[11].ToString();
                            child.listView1.Items.Add(amt12);
                        }

                        //Get Directions
                        SQLiteCommand cmddir = new SQLiteCommand("SELECT directions FROM liqueurs WHERE liqueur_key= " + (reader["liqueur_key"]) + "", cs3);
                        SQLiteDataReader rdr = cmddir.ExecuteReader();

                        while (rdr.Read())
                        {
                            child.richTextBox1.Text = rdr[0].ToString();
                        }

                    }
                }
            }
        }

        private void PunchesNameBox_DoubleClick(object sender, EventArgs e)
        {
            if (PunchesNameBox.SelectedItem != null)
            {
                {
                    string statusbarrecipe2 = PunchesNameBox.SelectedValue.ToString();
                    toolStripStatusLabel1.Text = statusbarrecipe2;

                    //MessageBox.Show(statusbarrecipe2);



                    using (SQLiteConnection cs4 = new SQLiteConnection("Data Source = |DataDirectory|\\XpressShots.db"))
                    {
                        cs4.Open();

                        //Get ID
                        //string selectedvalue

                        SQLiteCommand cmd = new SQLiteCommand("SELECT punch_key FROM punches WHERE name ='" + (statusbarrecipe2.Trim().Replace("'", "''")) + "'", cs4);
                        SQLiteDataReader reader = cmd.ExecuteReader();

                        //MessageBox.Show(reader["id"].ToString());

                        Form2 child = new Form2();
                        child.Text = PunchesNameBox.SelectedValue.ToString();
                        //child.toolStripStatusLabel1.Text = statusbarrecipe;

                        child.MdiParent = this;
                        client.BringToFront();//This will make your child form shown on top.
                        child.Show();

                        while (reader.Read())
                        {
                            // Get Ingredients
                            SQLiteCommand cmding = new SQLiteCommand("SELECT ingredient1, ingredient2, ingredient3, ingredient4, ingredient5, ingredient6, ingredient7, ingredient8, ingredient9, ingredient10, ingredient11, ingredient12, ingredient13, ingredient14 FROM punches WHERE punch_key=" + (reader["punch_key"]) + "", cs4);
                            SQLiteDataReader rdring = cmding.ExecuteReader();

                            while (rdring.Read())
                            {
                                ListViewItem ingredient1 = new ListViewItem();
                                ingredient1.SubItems[0].Text = rdring[0].ToString();
                                child.listView2.Items.Add(ingredient1);

                                ListViewItem ingredient2 = new ListViewItem();
                                ingredient2.SubItems[0].Text = rdring[1].ToString();
                                child.listView2.Items.Add(ingredient2);

                                ListViewItem ingredient3 = new ListViewItem();
                                ingredient3.SubItems[0].Text = rdring[2].ToString();
                                child.listView2.Items.Add(ingredient3);

                                ListViewItem ingredient4 = new ListViewItem();
                                ingredient4.SubItems[0].Text = rdring[3].ToString();
                                child.listView2.Items.Add(ingredient4);

                                ListViewItem ingredient5 = new ListViewItem();
                                ingredient5.SubItems[0].Text = rdring[4].ToString();
                                child.listView2.Items.Add(ingredient5);

                                ListViewItem ingredient6 = new ListViewItem();
                                ingredient6.SubItems[0].Text = rdring[5].ToString();
                                child.listView2.Items.Add(ingredient6);

                                ListViewItem ingredient7 = new ListViewItem();
                                ingredient7.SubItems[0].Text = rdring[6].ToString();
                                child.listView2.Items.Add(ingredient7);

                                ListViewItem ingredient8 = new ListViewItem();
                                ingredient8.SubItems[0].Text = rdring[7].ToString();
                                child.listView2.Items.Add(ingredient8);

                                ListViewItem ingredient9 = new ListViewItem();
                                ingredient9.SubItems[0].Text = rdring[8].ToString();
                                child.listView2.Items.Add(ingredient9);

                                ListViewItem ingredient10 = new ListViewItem();
                                ingredient10.SubItems[0].Text = rdring[9].ToString();
                                child.listView2.Items.Add(ingredient10);

                                ListViewItem ingredient11 = new ListViewItem();
                                ingredient11.SubItems[0].Text = rdring[10].ToString();
                                child.listView2.Items.Add(ingredient11);

                                ListViewItem ingredient12 = new ListViewItem();
                                ingredient12.SubItems[0].Text = rdring[11].ToString();
                                child.listView2.Items.Add(ingredient12);

                                ListViewItem ingredient13 = new ListViewItem();
                                ingredient13.SubItems[0].Text = rdring[12].ToString();
                                child.listView2.Items.Add(ingredient13);

                                ListViewItem ingredient14 = new ListViewItem();
                                ingredient14.SubItems[0].Text = rdring[13].ToString();
                                child.listView2.Items.Add(ingredient14);
                            }
                            //Get Amounts
                            SQLiteCommand cmdamt = new SQLiteCommand("SELECT amt1, amt2, amt3, amt4, amt5, amt6, amt7, amt8, amt9, amt10, amt11, amt12, amt13, amt14 FROM punches WHERE punch_key=" + (reader["punch_key"]) + "", cs4);
                            SQLiteDataReader rdramt = cmdamt.ExecuteReader();

                            while (rdramt.Read())
                            {
                                ListViewItem amt1 = new ListViewItem();
                                amt1.SubItems[0].Text = rdramt[0].ToString();
                                //amount.SubItems.Add(rdramt[0].ToString());
                                child.listView1.Items.Add(amt1);

                                ListViewItem amt2 = new ListViewItem();
                                amt2.SubItems[0].Text = rdramt[1].ToString();
                                child.listView1.Items.Add(amt2);

                                ListViewItem amt3 = new ListViewItem();
                                amt3.SubItems[0].Text = rdramt[2].ToString();
                                child.listView1.Items.Add(amt3);

                                ListViewItem amt4 = new ListViewItem();
                                amt4.SubItems[0].Text = rdramt[3].ToString();
                                child.listView1.Items.Add(amt4);

                                ListViewItem amt5 = new ListViewItem();
                                amt5.SubItems[0].Text = rdramt[4].ToString();
                                child.listView1.Items.Add(amt5);

                                ListViewItem amt6 = new ListViewItem();
                                amt6.SubItems[0].Text = rdramt[5].ToString();
                                child.listView1.Items.Add(amt6);

                                ListViewItem amt7 = new ListViewItem();
                                amt7.SubItems[0].Text = rdramt[6].ToString();
                                child.listView1.Items.Add(amt7);

                                ListViewItem amt8 = new ListViewItem();
                                amt8.SubItems[0].Text = rdramt[7].ToString();
                                child.listView1.Items.Add(amt8);

                                ListViewItem amt9 = new ListViewItem();
                                amt9.SubItems[0].Text = rdramt[8].ToString();
                                child.listView1.Items.Add(amt9);

                                ListViewItem amt10 = new ListViewItem();
                                amt10.SubItems[0].Text = rdramt[9].ToString();
                                child.listView1.Items.Add(amt10);

                                ListViewItem amt11 = new ListViewItem();
                                amt11.SubItems[0].Text = rdramt[10].ToString();
                                child.listView1.Items.Add(amt11);

                                ListViewItem amt12 = new ListViewItem();
                                amt12.SubItems[0].Text = rdramt[11].ToString();
                                child.listView1.Items.Add(amt12);

                                ListViewItem amt13 = new ListViewItem();
                                amt13.SubItems[0].Text = rdramt[12].ToString();
                                child.listView1.Items.Add(amt13);

                                ListViewItem amt14 = new ListViewItem();
                                amt14.SubItems[0].Text = rdramt[13].ToString();
                                child.listView1.Items.Add(amt14);
                            }

                            //Get Directions
                            SQLiteCommand cmddir = new SQLiteCommand("SELECT directions FROM punches WHERE punch_key= " + (reader["punch_key"]) + "", cs4);
                            SQLiteDataReader rdr = cmddir.ExecuteReader();

                            while (rdr.Read())
                            {
                                child.richTextBox1.Text = rdr[0].ToString();
                            }

                        }
                    }
                }
            }
        }

        private void CocktailsNameBox_DoubleClick(object sender, EventArgs e)
        {
            if (CocktailsNameBox.SelectedItem != null)
            {
                {
                    string statusbarrecipe2 = CocktailsNameBox.SelectedValue.ToString();
                    toolStripStatusLabel1.Text = statusbarrecipe2;

                    //MessageBox.Show(statusbarrecipe2);



                    using (SQLiteConnection cs5 = new SQLiteConnection("Data Source = |DataDirectory|\\XpressShots.db"))
                    {
                        cs5.Open();

                        //Get ID
                        //string selectedvalue

                        SQLiteCommand cmd = new SQLiteCommand("SELECT cocktail_key FROM cocktails WHERE name ='" + (statusbarrecipe2.Trim().Replace("'", "''")) + "'", cs5);
                        SQLiteDataReader reader = cmd.ExecuteReader();

                        //MessageBox.Show(reader["id"].ToString());

                        Form2 child = new Form2();
                        child.Text = CocktailsNameBox.SelectedValue.ToString();
                        //child.toolStripStatusLabel1.Text = statusbarrecipe;

                        child.MdiParent = this;
                        client.BringToFront();//This will make your child form shown on top.
                        child.Show();

                        while (reader.Read())
                        {
                            // Get Ingredients
                            SQLiteCommand cmding = new SQLiteCommand("SELECT ingredient1, ingredient2, ingredient3, ingredient4, ingredient5, ingredient6, ingredient7, ingredient8, ingredient9, ingredient10, ingredient11, ingredient12, ingredient13 FROM cocktails WHERE cocktail_key=" + (reader["cocktail_key"]) + "", cs5);
                            SQLiteDataReader rdring = cmding.ExecuteReader();

                            while (rdring.Read())
                            {
                                ListViewItem ingredient1 = new ListViewItem();
                                ingredient1.SubItems[0].Text = rdring[0].ToString();
                                child.listView2.Items.Add(ingredient1);

                                ListViewItem ingredient2 = new ListViewItem();
                                ingredient2.SubItems[0].Text = rdring[1].ToString();
                                child.listView2.Items.Add(ingredient2);

                                ListViewItem ingredient3 = new ListViewItem();
                                ingredient3.SubItems[0].Text = rdring[2].ToString();
                                child.listView2.Items.Add(ingredient3);

                                ListViewItem ingredient4 = new ListViewItem();
                                ingredient4.SubItems[0].Text = rdring[3].ToString();
                                child.listView2.Items.Add(ingredient4);

                                ListViewItem ingredient5 = new ListViewItem();
                                ingredient5.SubItems[0].Text = rdring[4].ToString();
                                child.listView2.Items.Add(ingredient5);

                                ListViewItem ingredient6 = new ListViewItem();
                                ingredient6.SubItems[0].Text = rdring[5].ToString();
                                child.listView2.Items.Add(ingredient6);

                                ListViewItem ingredient7 = new ListViewItem();
                                ingredient7.SubItems[0].Text = rdring[6].ToString();
                                child.listView2.Items.Add(ingredient7);

                                ListViewItem ingredient8 = new ListViewItem();
                                ingredient8.SubItems[0].Text = rdring[7].ToString();
                                child.listView2.Items.Add(ingredient8);

                                ListViewItem ingredient9 = new ListViewItem();
                                ingredient9.SubItems[0].Text = rdring[8].ToString();
                                child.listView2.Items.Add(ingredient9);

                                ListViewItem ingredient10 = new ListViewItem();
                                ingredient10.SubItems[0].Text = rdring[9].ToString();
                                child.listView2.Items.Add(ingredient10);

                                ListViewItem ingredient11 = new ListViewItem();
                                ingredient11.SubItems[0].Text = rdring[10].ToString();
                                child.listView2.Items.Add(ingredient11);

                                ListViewItem ingredient12 = new ListViewItem();
                                ingredient12.SubItems[0].Text = rdring[11].ToString();
                                child.listView2.Items.Add(ingredient12);

                                ListViewItem ingredient13 = new ListViewItem();
                                ingredient13.SubItems[0].Text = rdring[12].ToString();
                                child.listView2.Items.Add(ingredient13);
                            }
                            //Get Amounts
                            SQLiteCommand cmdamt = new SQLiteCommand("SELECT amt1, amt2, amt3, amt4, amt5, amt6, amt7, amt8, amt9, amt10, amt11, amt12, amt13 FROM cocktails WHERE cocktail_key=" + (reader["cocktail_key"]) + "", cs5);
                            SQLiteDataReader rdramt = cmdamt.ExecuteReader();

                            while (rdramt.Read())
                            {
                                ListViewItem amt1 = new ListViewItem();
                                amt1.SubItems[0].Text = rdramt[0].ToString();
                                //amount.SubItems.Add(rdramt[0].ToString());
                                child.listView1.Items.Add(amt1);

                                ListViewItem amt2 = new ListViewItem();
                                amt2.SubItems[0].Text = rdramt[1].ToString();
                                child.listView1.Items.Add(amt2);

                                ListViewItem amt3 = new ListViewItem();
                                amt3.SubItems[0].Text = rdramt[2].ToString();
                                child.listView1.Items.Add(amt3);

                                ListViewItem amt4 = new ListViewItem();
                                amt4.SubItems[0].Text = rdramt[3].ToString();
                                child.listView1.Items.Add(amt4);

                                ListViewItem amt5 = new ListViewItem();
                                amt5.SubItems[0].Text = rdramt[4].ToString();
                                child.listView1.Items.Add(amt5);

                                ListViewItem amt6 = new ListViewItem();
                                amt6.SubItems[0].Text = rdramt[5].ToString();
                                child.listView1.Items.Add(amt6);

                                ListViewItem amt7 = new ListViewItem();
                                amt7.SubItems[0].Text = rdramt[6].ToString();
                                child.listView1.Items.Add(amt7);

                                ListViewItem amt8 = new ListViewItem();
                                amt8.SubItems[0].Text = rdramt[7].ToString();
                                child.listView1.Items.Add(amt8);

                                ListViewItem amt9 = new ListViewItem();
                                amt9.SubItems[0].Text = rdramt[8].ToString();
                                child.listView1.Items.Add(amt9);

                                ListViewItem amt10 = new ListViewItem();
                                amt10.SubItems[0].Text = rdramt[9].ToString();
                                child.listView1.Items.Add(amt10);

                                ListViewItem amt11 = new ListViewItem();
                                amt11.SubItems[0].Text = rdramt[10].ToString();
                                child.listView1.Items.Add(amt11);

                                ListViewItem amt12 = new ListViewItem();
                                amt12.SubItems[0].Text = rdramt[11].ToString();
                                child.listView1.Items.Add(amt12);

                                ListViewItem amt13 = new ListViewItem();
                                amt13.SubItems[0].Text = rdramt[12].ToString();
                                child.listView1.Items.Add(amt13);

                            }

                            //Get Directions
                            SQLiteCommand cmddir = new SQLiteCommand("SELECT directions FROM cocktails WHERE cocktail_key = " + (reader["cocktail_key"]) + "", cs5);
                            SQLiteDataReader rdr = cmddir.ExecuteReader();

                            while (rdr.Read())
                            {
                                child.richTextBox1.Text = rdr[0].ToString();
                            }

                        }
                    }

                }
            }
        }

        private void BeerAleNameBox_DoubleClick(object sender, EventArgs e)
        {
            if (BeerAleNameBox.SelectedItem != null)
            {
                string statusbarrecipe2 = BeerAleNameBox.SelectedValue.ToString();
                toolStripStatusLabel1.Text = statusbarrecipe2;

                //MessageBox.Show(statusbarrecipe2);



                using (SQLiteConnection cs6 = new SQLiteConnection("Data Source = |DataDirectory|\\XpressShots.db"))
                {
                    cs6.Open();

                    //Get ID
                    //string selectedvalue

                    SQLiteCommand cmd = new SQLiteCommand("SELECT beer_key FROM beers WHERE name ='" + (statusbarrecipe2.Trim().Replace("'", "''")) + "'", cs6);
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    //MessageBox.Show(reader["id"].ToString());

                    Form2 child = new Form2();
                    child.Text = BeerAleNameBox.SelectedValue.ToString();
                    //child.toolStripStatusLabel1.Text = statusbarrecipe;

                    child.MdiParent = this;
                    client.BringToFront();//This will make your child form shown on top.
                    child.Show();

                    while (reader.Read())
                    {
                        // Get Ingredients
                        SQLiteCommand cmding = new SQLiteCommand("SELECT ingredient1, ingredient2, ingredient3, ingredient4, ingredient5, ingredient6, ingredient7, ingredient8, ingredient9 FROM beers WHERE beer_key=" + (reader["beer_key"]) + "", cs6);
                        SQLiteDataReader rdring = cmding.ExecuteReader();

                        while (rdring.Read())
                        {
                            ListViewItem ingredient1 = new ListViewItem();
                            ingredient1.SubItems[0].Text = rdring[0].ToString();
                            child.listView2.Items.Add(ingredient1);

                            ListViewItem ingredient2 = new ListViewItem();
                            ingredient2.SubItems[0].Text = rdring[1].ToString();
                            child.listView2.Items.Add(ingredient2);

                            ListViewItem ingredient3 = new ListViewItem();
                            ingredient3.SubItems[0].Text = rdring[2].ToString();
                            child.listView2.Items.Add(ingredient3);

                            ListViewItem ingredient4 = new ListViewItem();
                            ingredient4.SubItems[0].Text = rdring[3].ToString();
                            child.listView2.Items.Add(ingredient4);

                            ListViewItem ingredient5 = new ListViewItem();
                            ingredient5.SubItems[0].Text = rdring[4].ToString();
                            child.listView2.Items.Add(ingredient5);

                            ListViewItem ingredient6 = new ListViewItem();
                            ingredient6.SubItems[0].Text = rdring[5].ToString();
                            child.listView2.Items.Add(ingredient6);

                            ListViewItem ingredient7 = new ListViewItem();
                            ingredient7.SubItems[0].Text = rdring[6].ToString();
                            child.listView2.Items.Add(ingredient7);

                            ListViewItem ingredient8 = new ListViewItem();
                            ingredient8.SubItems[0].Text = rdring[7].ToString();
                            child.listView2.Items.Add(ingredient8);

                            ListViewItem ingredient9 = new ListViewItem();
                            ingredient9.SubItems[0].Text = rdring[8].ToString();
                            child.listView2.Items.Add(ingredient9);
                        }
                        //Get Amounts
                        SQLiteCommand cmdamt = new SQLiteCommand("SELECT amt1, amt2, amt3, amt4, amt5, amt6, amt7, amt8, amt9 FROM beers WHERE beer_key=" + (reader["beer_key"]) + "", cs6);
                        SQLiteDataReader rdramt = cmdamt.ExecuteReader();

                        while (rdramt.Read())
                        {
                            ListViewItem amt1 = new ListViewItem();
                            amt1.SubItems[0].Text = rdramt[0].ToString();
                            //amount.SubItems.Add(rdramt[0].ToString());
                            child.listView1.Items.Add(amt1);

                            ListViewItem amt2 = new ListViewItem();
                            amt2.SubItems[0].Text = rdramt[1].ToString();
                            child.listView1.Items.Add(amt2);

                            ListViewItem amt3 = new ListViewItem();
                            amt3.SubItems[0].Text = rdramt[2].ToString();
                            child.listView1.Items.Add(amt3);

                            ListViewItem amt4 = new ListViewItem();
                            amt4.SubItems[0].Text = rdramt[3].ToString();
                            child.listView1.Items.Add(amt4);

                            ListViewItem amt5 = new ListViewItem();
                            amt5.SubItems[0].Text = rdramt[4].ToString();
                            child.listView1.Items.Add(amt5);

                            ListViewItem amt6 = new ListViewItem();
                            amt6.SubItems[0].Text = rdramt[5].ToString();
                            child.listView1.Items.Add(amt6);

                            ListViewItem amt7 = new ListViewItem();
                            amt7.SubItems[0].Text = rdramt[6].ToString();
                            child.listView1.Items.Add(amt7);

                            ListViewItem amt8 = new ListViewItem();
                            amt8.SubItems[0].Text = rdramt[7].ToString();
                            child.listView1.Items.Add(amt8);

                            ListViewItem amt9 = new ListViewItem();
                            amt9.SubItems[0].Text = rdramt[8].ToString();
                            child.listView1.Items.Add(amt9);
                        }

                        //Get Directions
                        SQLiteCommand cmddir = new SQLiteCommand("SELECT directions FROM beers WHERE beer_key= " + (reader["beer_key"]) + "", cs6);
                        SQLiteDataReader rdr = cmddir.ExecuteReader();

                        while (rdr.Read())
                        {
                            child.richTextBox1.Text = rdr[0].ToString();
                        }

                    }
                }

            }
        }

        private void NonAlcoholicNameBox_DoubleClick(object sender, EventArgs e)
        {
            if (NonAlcoholicNameBox.SelectedItem != null)
            {
                string statusbarrecipe2 = NonAlcoholicNameBox.SelectedValue.ToString();
                toolStripStatusLabel1.Text = statusbarrecipe2;

                //MessageBox.Show(statusbarrecipe2);



                using (SQLiteConnection cs7 = new SQLiteConnection("Data Source = |DataDirectory|\\XpressShots.db"))
                {
                    cs7.Open();

                    //Get ID
                    //string selectedvalue

                    SQLiteCommand cmd = new SQLiteCommand("SELECT nonalcoholic_key FROM nonalcoholic WHERE name ='" + (statusbarrecipe2.Trim().Replace("'", "''")) + "'", cs7);
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    //MessageBox.Show(reader["id"].ToString());

                    Form2 child = new Form2();
                    child.Text = NonAlcoholicNameBox.SelectedValue.ToString();
                    //child.toolStripStatusLabel1.Text = statusbarrecipe;

                    child.MdiParent = this;
                    client.BringToFront();//This will make your child form shown on top.
                    child.Show();


                    while (reader.Read())
                    {
                        // Get Ingredients
                        SQLiteCommand cmding = new SQLiteCommand("SELECT ingredient1, ingredient2, ingredient3, ingredient4, ingredient5, ingredient6, ingredient7, ingredient8, ingredient9, ingredient10, ingredient11, ingredient12 FROM nonalcoholic WHERE nonalcoholic_key=" + (reader["nonalcoholic_key"]) + "", cs7);
                        SQLiteDataReader rdring = cmding.ExecuteReader();

                        while (rdring.Read())
                        {
                            ListViewItem ingredient1 = new ListViewItem();
                            ingredient1.SubItems[0].Text = rdring[0].ToString();
                            child.listView2.Items.Add(ingredient1);

                            ListViewItem ingredient2 = new ListViewItem();
                            ingredient2.SubItems[0].Text = rdring[1].ToString();
                            child.listView2.Items.Add(ingredient2);

                            ListViewItem ingredient3 = new ListViewItem();
                            ingredient3.SubItems[0].Text = rdring[2].ToString();
                            child.listView2.Items.Add(ingredient3);

                            ListViewItem ingredient4 = new ListViewItem();
                            ingredient4.SubItems[0].Text = rdring[3].ToString();
                            child.listView2.Items.Add(ingredient4);

                            ListViewItem ingredient5 = new ListViewItem();
                            ingredient5.SubItems[0].Text = rdring[4].ToString();
                            child.listView2.Items.Add(ingredient5);

                            ListViewItem ingredient6 = new ListViewItem();
                            ingredient6.SubItems[0].Text = rdring[5].ToString();
                            child.listView2.Items.Add(ingredient6);

                            ListViewItem ingredient7 = new ListViewItem();
                            ingredient7.SubItems[0].Text = rdring[6].ToString();
                            child.listView2.Items.Add(ingredient7);

                            ListViewItem ingredient8 = new ListViewItem();
                            ingredient8.SubItems[0].Text = rdring[7].ToString();
                            child.listView2.Items.Add(ingredient8);

                            ListViewItem ingredient9 = new ListViewItem();
                            ingredient9.SubItems[0].Text = rdring[8].ToString();
                            child.listView2.Items.Add(ingredient9);

                            ListViewItem ingredient10 = new ListViewItem();
                            ingredient10.SubItems[0].Text = rdring[9].ToString();
                            child.listView2.Items.Add(ingredient10);

                            ListViewItem ingredient11 = new ListViewItem();
                            ingredient11.SubItems[0].Text = rdring[10].ToString();
                            child.listView2.Items.Add(ingredient11);

                            ListViewItem ingredient12 = new ListViewItem();
                            ingredient12.SubItems[0].Text = rdring[11].ToString();
                            child.listView2.Items.Add(ingredient12);

                        }
                        //Get Amounts
                        SQLiteCommand cmdamt = new SQLiteCommand("SELECT amt1, amt2, amt3, amt4, amt5, amt6, amt7, amt8, amt9, amt10, amt11, amt12 FROM nonalcoholic WHERE nonalcoholic_key=" + (reader["nonalcoholic_key"]) + "", cs7);
                        SQLiteDataReader rdramt = cmdamt.ExecuteReader();

                        while (rdramt.Read())
                        {
                            ListViewItem amt1 = new ListViewItem();
                            amt1.SubItems[0].Text = rdramt[0].ToString();
                            //amount.SubItems.Add(rdramt[0].ToString());
                            child.listView1.Items.Add(amt1);

                            ListViewItem amt2 = new ListViewItem();
                            amt2.SubItems[0].Text = rdramt[1].ToString();
                            child.listView1.Items.Add(amt2);

                            ListViewItem amt3 = new ListViewItem();
                            amt3.SubItems[0].Text = rdramt[2].ToString();
                            child.listView1.Items.Add(amt3);

                            ListViewItem amt4 = new ListViewItem();
                            amt4.SubItems[0].Text = rdramt[3].ToString();
                            child.listView1.Items.Add(amt4);

                            ListViewItem amt5 = new ListViewItem();
                            amt5.SubItems[0].Text = rdramt[4].ToString();
                            child.listView1.Items.Add(amt5);

                            ListViewItem amt6 = new ListViewItem();
                            amt6.SubItems[0].Text = rdramt[5].ToString();
                            child.listView1.Items.Add(amt6);

                            ListViewItem amt7 = new ListViewItem();
                            amt7.SubItems[0].Text = rdramt[6].ToString();
                            child.listView1.Items.Add(amt7);

                            ListViewItem amt8 = new ListViewItem();
                            amt8.SubItems[0].Text = rdramt[7].ToString();
                            child.listView1.Items.Add(amt8);

                            ListViewItem amt9 = new ListViewItem();
                            amt9.SubItems[0].Text = rdramt[8].ToString();
                            child.listView1.Items.Add(amt9);

                            ListViewItem amt10 = new ListViewItem();
                            amt10.SubItems[0].Text = rdramt[9].ToString();
                            child.listView1.Items.Add(amt10);

                            ListViewItem amt11 = new ListViewItem();
                            amt11.SubItems[0].Text = rdramt[10].ToString();
                            child.listView1.Items.Add(amt11);

                            ListViewItem amt12 = new ListViewItem();
                            amt12.SubItems[0].Text = rdramt[11].ToString();
                            child.listView1.Items.Add(amt12);

                        }

                        //Get Directions
                        SQLiteCommand cmddir = new SQLiteCommand("SELECT directions FROM nonalcoholic WHERE nonalcoholic_key= " + (reader["nonalcoholic_key"]) + "", cs7);
                        SQLiteDataReader rdr = cmddir.ExecuteReader();

                        while (rdr.Read())
                        {
                            child.richTextBox1.Text = rdr[0].ToString();
                        }

                    }
                }

            }
        }

        private void CoffeeTeaNameBox_DoubleClick(object sender, EventArgs e)
        {
            if (CoffeeTeaNameBox.SelectedItem != null)
            {
                string statusbarrecipe2 = CoffeeTeaNameBox.SelectedValue.ToString();
                toolStripStatusLabel1.Text = statusbarrecipe2;



                using (SQLiteConnection conn6 = new SQLiteConnection("Data Source = |DataDirectory|\\XpressShots.db"))
                {
                    conn6.Open();

                    //Get ID
                    //string selectedvalue

                    SQLiteCommand cmd = new SQLiteCommand("SELECT coffeetea_key FROM coffeetea WHERE name ='" + (statusbarrecipe2.Trim().Replace("'", "''")) + " '", conn6);
                    SQLiteDataReader reader = cmd.ExecuteReader();


                    Form2 child = new Form2();
                    child.Text = CoffeeTeaNameBox.SelectedValue.ToString();
                    //child.toolStripStatusLabel1.Text = statusbarrecipe;

                    child.MdiParent = this;
                    client.BringToFront();//This will make your child form shown on top.
                    child.Show();




                    while (reader.Read())
                    {
                        // Get Ingredients
                        SQLiteCommand cmding = new SQLiteCommand("SELECT ingredient1, ingredient2, ingredient3, ingredient4, ingredient5, ingredient6, ingredient7, ingredient8, ingredient9 FROM coffeetea WHERE coffeetea_key=" + (reader["coffeetea_key"]) + "", conn6);
                        SQLiteDataReader rdring = cmding.ExecuteReader();

                        while (rdring.Read())
                        {
                            ListViewItem ingredient1 = new ListViewItem();
                            ingredient1.SubItems[0].Text = rdring[0].ToString();
                            child.listView2.Items.Add(ingredient1);

                            ListViewItem ingredient2 = new ListViewItem();
                            ingredient2.SubItems[0].Text = rdring[1].ToString();
                            child.listView2.Items.Add(ingredient2);

                            ListViewItem ingredient3 = new ListViewItem();
                            ingredient3.SubItems[0].Text = rdring[2].ToString();
                            child.listView2.Items.Add(ingredient3);

                            ListViewItem ingredient4 = new ListViewItem();
                            ingredient4.SubItems[0].Text = rdring[3].ToString();
                            child.listView2.Items.Add(ingredient4);

                            ListViewItem ingredient5 = new ListViewItem();
                            ingredient5.SubItems[0].Text = rdring[4].ToString();
                            child.listView2.Items.Add(ingredient5);

                            ListViewItem ingredient6 = new ListViewItem();
                            ingredient6.SubItems[0].Text = rdring[5].ToString();
                            child.listView2.Items.Add(ingredient6);

                            ListViewItem ingredient7 = new ListViewItem();
                            ingredient7.SubItems[0].Text = rdring[6].ToString();
                            child.listView2.Items.Add(ingredient7);

                            ListViewItem ingredient8 = new ListViewItem();
                            ingredient8.SubItems[0].Text = rdring[7].ToString();
                            child.listView2.Items.Add(ingredient8);

                            ListViewItem ingredient9 = new ListViewItem();
                            ingredient9.SubItems[0].Text = rdring[8].ToString();
                            child.listView2.Items.Add(ingredient9);

                        }
                        //Get Amounts
                        SQLiteCommand cmdamt = new SQLiteCommand("SELECT amt1, amt2, amt3, amt4, amt5, amt6, amt7, amt8, amt9 FROM coffeetea WHERE coffeetea_key=" + (reader["coffeetea_key"]) + "", conn6);
                        SQLiteDataReader rdramt = cmdamt.ExecuteReader();

                        while (rdramt.Read())
                        {
                            ListViewItem amt1 = new ListViewItem();
                            amt1.SubItems[0].Text = rdramt[0].ToString();
                            //amount.SubItems.Add(rdramt[0].ToString());
                            child.listView1.Items.Add(amt1);

                            ListViewItem amt2 = new ListViewItem();
                            amt2.SubItems[0].Text = rdramt[1].ToString();
                            child.listView1.Items.Add(amt2);

                            ListViewItem amt3 = new ListViewItem();
                            amt3.SubItems[0].Text = rdramt[2].ToString();
                            child.listView1.Items.Add(amt3);

                            ListViewItem amt4 = new ListViewItem();
                            amt4.SubItems[0].Text = rdramt[3].ToString();
                            child.listView1.Items.Add(amt4);

                            ListViewItem amt5 = new ListViewItem();
                            amt5.SubItems[0].Text = rdramt[4].ToString();
                            child.listView1.Items.Add(amt5);

                            ListViewItem amt6 = new ListViewItem();
                            amt6.SubItems[0].Text = rdramt[5].ToString();
                            child.listView1.Items.Add(amt6);

                            ListViewItem amt7 = new ListViewItem();
                            amt7.SubItems[0].Text = rdramt[6].ToString();
                            child.listView1.Items.Add(amt7);

                            ListViewItem amt8 = new ListViewItem();
                            amt8.SubItems[0].Text = rdramt[7].ToString();
                            child.listView1.Items.Add(amt8);

                            ListViewItem amt9 = new ListViewItem();
                            amt9.SubItems[0].Text = rdramt[8].ToString();
                            child.listView1.Items.Add(amt9);

                        }

                        //Get Directions
                        SQLiteCommand cmddir = new SQLiteCommand("SELECT directions FROM coffeetea WHERE coffeetea_key= " + (reader["coffeetea_key"]) + "", conn6);
                        SQLiteDataReader rdr = cmddir.ExecuteReader();

                        while (rdr.Read())
                        {
                            child.richTextBox1.Text = rdr[0].ToString();
                        }

                    }
                }

            }
        }

        private void CustomNameBox_DoubleClick(object sender, EventArgs e)
        {
            if (CustomNameBox.SelectedItem != null)
            {
                string statusbarrecipe2 = CustomNameBox.SelectedValue.ToString();
                toolStripStatusLabel1.Text = statusbarrecipe2;


                using (SQLiteConnection conn21 = new SQLiteConnection("Data Source = |DataDirectory|\\XpressShots.db"))
                {
                    conn21.Open();
                    SQLiteCommand cmd = new SQLiteCommand("SELECT myrecipes_key FROM MyRecipes WHERE name ='" + statusbarrecipe2 + "'", conn21);
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        //MessageBox.Show(reader["myrecipes_key"].ToString());
                        Form2 child = new Form2();
                        child.Text = CustomNameBox.SelectedValue.ToString();
                        //child.toolStripStatusLabel1.Text = statusbarrecipe;
                        child.MdiParent = this;
                        client.BringToFront();//This will make your child form shown on top.
                        child.Show();


                        //if (reader.Read())
                        {
                            // Get Ingredients
                            SQLiteCommand cmding = new SQLiteCommand("SELECT ingredient1, ingredient2, ingredient3, ingredient4, ingredient5, ingredient6, ingredient7, ingredient8, ingredient9 FROM myRecipes WHERE myrecipes_key =" + (reader["myrecipes_key"]) + "", conn21);
                            SQLiteDataReader rdring = cmding.ExecuteReader();

                            if (rdring.Read())
                            {
                                ListViewItem ingredient1 = new ListViewItem();
                                ingredient1.SubItems[0].Text = rdring[0].ToString();
                                child.listView2.Items.Add(ingredient1);

                                ListViewItem ingredient2 = new ListViewItem();
                                ingredient2.SubItems[0].Text = rdring[1].ToString();
                                child.listView2.Items.Add(ingredient2);

                                ListViewItem ingredient3 = new ListViewItem();
                                ingredient3.SubItems[0].Text = rdring[2].ToString();
                                child.listView2.Items.Add(ingredient3);

                                ListViewItem ingredient4 = new ListViewItem();
                                ingredient4.SubItems[0].Text = rdring[3].ToString();
                                child.listView2.Items.Add(ingredient4);

                                ListViewItem ingredient5 = new ListViewItem();
                                ingredient5.SubItems[0].Text = rdring[4].ToString();
                                child.listView2.Items.Add(ingredient5);

                                ListViewItem ingredient6 = new ListViewItem();
                                ingredient6.SubItems[0].Text = rdring[5].ToString();
                                child.listView2.Items.Add(ingredient6);

                                ListViewItem ingredient7 = new ListViewItem();
                                ingredient7.SubItems[0].Text = rdring[6].ToString();
                                child.listView2.Items.Add(ingredient7);

                                ListViewItem ingredient8 = new ListViewItem();
                                ingredient8.SubItems[0].Text = rdring[7].ToString();
                                child.listView2.Items.Add(ingredient8);

                                ListViewItem ingredient9 = new ListViewItem();
                                ingredient9.SubItems[0].Text = rdring[8].ToString();
                                child.listView2.Items.Add(ingredient9);

                            }

                            //Get Amounts
                            SQLiteCommand cmdamt = new SQLiteCommand("SELECT amt1, amt2, amt3, amt4, amt5, amt6, amt7, amt8, amt9 FROM myRecipes WHERE myrecipes_key=" + (reader["myrecipes_key"]) + "", conn21);
                            SQLiteDataReader rdramt = cmdamt.ExecuteReader();

                            if (rdramt.Read())
                            {
                                ListViewItem amt1 = new ListViewItem();
                                amt1.SubItems[0].Text = rdramt[0].ToString();
                                //amount.SubItems.Add(rdramt[0].ToString());
                                child.listView1.Items.Add(amt1);

                                ListViewItem amt2 = new ListViewItem();
                                amt2.SubItems[0].Text = rdramt[1].ToString();
                                child.listView1.Items.Add(amt2);

                                ListViewItem amt3 = new ListViewItem();
                                amt3.SubItems[0].Text = rdramt[2].ToString();
                                child.listView1.Items.Add(amt3);

                                ListViewItem amt4 = new ListViewItem();
                                amt4.SubItems[0].Text = rdramt[3].ToString();
                                child.listView1.Items.Add(amt4);

                                ListViewItem amt5 = new ListViewItem();
                                amt5.SubItems[0].Text = rdramt[4].ToString();
                                child.listView1.Items.Add(amt5);

                                ListViewItem amt6 = new ListViewItem();
                                amt6.SubItems[0].Text = rdramt[5].ToString();
                                child.listView1.Items.Add(amt6);

                                ListViewItem amt7 = new ListViewItem();
                                amt7.SubItems[0].Text = rdramt[6].ToString();
                                child.listView1.Items.Add(amt7);

                                ListViewItem amt8 = new ListViewItem();
                                amt8.SubItems[0].Text = rdramt[7].ToString();
                                child.listView1.Items.Add(amt8);

                                ListViewItem amt9 = new ListViewItem();
                                amt9.SubItems[0].Text = rdramt[8].ToString();
                                child.listView1.Items.Add(amt9);

                            }

                            //Get Directions
                            SQLiteCommand cmddir = new SQLiteCommand("SELECT directions FROM myRecipes WHERE myrecipes_key= " + (reader["myrecipes_key"]) + "", conn21);
                            SQLiteDataReader rdr = cmddir.ExecuteReader();

                            if (rdr.Read())
                            {
                                child.richTextBox1.Text = rdr[0].ToString();
                            }

                        }
                    }

                }
            }



        }
        private void DrinksBoxItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            WizardPages.SelectedTab = DrinksTab;

            DrinksNameBox.Show();

            toolStripStatusLabel1.Text = (this.DrinksNameBox.ItemCount.ToString()) + " Drink Recipes";

        }


        private void ShotsBarItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            WizardPages.SelectedTab = ShotsTab;

            ShotsNameBox.Show();

            toolStripStatusLabel1.Text = (this.ShotsNameBox.ItemCount.ToString()) + " Shot Recipes";

        }

        private void LiqueursBarItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            WizardPages.SelectedTab = LiqueursTab;
            LiqueursNameBox.Show();
            toolStripStatusLabel1.Text = (this.LiqueursNameBox.ItemCount.ToString()) + " Liqueurs Recipes";

        }

        private void PunchesBarItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            WizardPages.SelectedTab = PunchesTab;
            PunchesNameBox.Show();
            toolStripStatusLabel1.Text = (this.PunchesNameBox.ItemCount.ToString()) + " Punch Recipes";

        }

        private void CocktailsBarItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            WizardPages.SelectedTab = CocktailsTab;
            CocktailsNameBox.Show();
            toolStripStatusLabel1.Text = (this.CocktailsNameBox.ItemCount.ToString()) + " Cocktail Recipes";

        }

        private void BeerAleBarItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            WizardPages.SelectedTab = BeerAlesTab;
            BeerAleNameBox.Show();
            toolStripStatusLabel1.Text = (this.BeerAleNameBox.ItemCount.ToString()) + " Beer and Ale Recipes";

        }

        private void NonAlcoholicBarItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            WizardPages.SelectedTab = nonAlcoholicTab;
            NonAlcoholicNameBox.Show();
            toolStripStatusLabel1.Text = (this.NonAlcoholicNameBox.ItemCount.ToString()) + " Non Alcoholic Recipes ";
        }

        private void CoffeeTeaBarItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            WizardPages.SelectedTab = CoffeeTeaTab;
            CoffeeTeaNameBox.Show();
            toolStripStatusLabel1.Text = (this.CoffeeTeaNameBox.ItemCount.ToString()) + " Coffee and Tea Recipes ";

        }

        private void CustomItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            WizardPages.SelectedTab = CustomTab;
            CustomNameBox.Show();
            toolStripStatusLabel1.Text = (this.CustomNameBox.ItemCount.ToString()) + " Custom Recipes ";
            //customRecipes child = new customRecipes();
            //child.Text = CustomNameBox.SelectedValue.ToString();
            //child.toolStripStatusLabel1.Text = statusbarrecipe;
            //child.MdiParent = this;
            //child.Show();
        }

        private void AddRecipeItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            WizardPages.SelectedTab = CustomTab;
            //CustomNameBox.Show();
            toolStripStatusLabel1.Text = (this.CustomNameBox.ItemCount.ToString()) + " Custom Recipes ";
            customRecipes child = new customRecipes();
            //child.Text = CustomNameBox.SelectedValue.ToString();
            //child.toolStripStatusLabel1.Text = statusbarrecipe;
            child.MdiParent = this;
            client.BringToFront();//This will make your child form shown on top.
            child.Show();
        }


        private void MyRecipesItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            WizardPages.SelectedTab = CustomTab;
            CustomNameBox.Show();
            CustomNameBox.Focus();
            toolStripStatusLabel1.Text = (this.CustomNameBox.ItemCount.ToString()) + " Custom Recipes ";
        }

        private void DrinkSearch_TextChanged(object sender, EventArgs e)
        {
            DrinkSearch.Font = new Font("Default", 8, FontStyle.Regular);
            int index = DrinksNameBox.FindString(DrinkSearch.Text);
            if (0 <= index)
            {
                DrinksNameBox.SelectedIndex = index;
            }
        }

        private void ShotSearch_TextChanged(object sender, EventArgs e)
        {

            ShotSearch.Font = new Font("Default", 8, FontStyle.Regular);
            int index = ShotsNameBox.FindString(ShotSearch.Text);
            if (0 <= index)
            {
                ShotsNameBox.SelectedIndex = index;
            }

        }

        private void LiqueurSearch_TextChanged(object sender, EventArgs e)
        {
            LiqueurSearch.Font = new Font("Default", 8, FontStyle.Regular);
            int index = LiqueursNameBox.FindString(LiqueurSearch.Text);
            if (0 <= index)
            {
                LiqueursNameBox.SelectedIndex = index;
            }

        }

        private void PunchSearch_TextChanged(object sender, EventArgs e)
        {
            PunchSearch.Font = new Font("Default", 8, FontStyle.Regular);
            int index = PunchesNameBox.FindString(PunchSearch.Text);
            if (0 <= index)
            {
                PunchesNameBox.SelectedIndex = index;
            }
        }

        private void CocktailSearch_TextChanged(object sender, EventArgs e)
        {
            CocktailSearch.Font = new Font("Default", 8, FontStyle.Regular);
            int index = CocktailsNameBox.FindString(CocktailSearch.Text);
            if (0 <= index)
            {
                CocktailsNameBox.SelectedIndex = index;
            }

        }

        private void BeerSearch_TextChanged(object sender, EventArgs e)
        {
            BeerSearch.Font = new Font("Default", 8, FontStyle.Regular);
            int index = BeerAleNameBox.FindString(BeerSearch.Text);
            if (0 <= index)
            {
                BeerAleNameBox.SelectedIndex = index;
            }

        }

        private void NonAlcoholicSearch_TextChanged(object sender, EventArgs e)
        {
            NonAlcoholicSearch.Font = new Font("Default", 8, FontStyle.Regular);
            int index = NonAlcoholicNameBox.FindString(NonAlcoholicSearch.Text);
            if (0 <= index)
            {
                NonAlcoholicNameBox.SelectedIndex = index;
            }
        }

        private void CoffeeTeaSearch_TextChanged(object sender, EventArgs e)
        {
            CoffeeTeaSearch.Font = new Font("Default", 8, FontStyle.Regular);
            int index = CoffeeTeaNameBox.FindString(CoffeeTeaSearch.Text);
            if (0 <= index)
            {
                CoffeeTeaNameBox.SelectedIndex = index;
            }
        }

        private void CustomSearch_TextChanged(object sender, EventArgs e)
        {
            CustomSearch.Font = new Font("Default", 8, FontStyle.Regular);
            int index = CustomNameBox.FindString(CustomSearch.Text);
            if (0 <= index)
            {
                CustomNameBox.SelectedIndex = index;
            }
        }

        private void DrinksNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.DrinksNameBox_DoubleClick(e.KeyChar, e);
                DrinksNameBox.Focus();
            }

        }

        private void ShotsNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.ShotsNameBox_DoubleClick(e.KeyChar, e);
                ShotsNameBox.Focus();
            }
        }

        private void LiqueursNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.LiqueursNameBox_DoubleClick(e.KeyChar, e);
                LiqueursNameBox.Focus();
            }
        }

        private void PunchesNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.PunchesNameBox_DoubleClick(e.KeyChar, e);
                PunchesNameBox.Focus();
            }
        }

        private void CocktailsNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.CocktailsNameBox_DoubleClick(e.KeyChar, e);
                CocktailsNameBox.Focus();
            }
        }

        private void BeerAleNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.BeerAleNameBox_DoubleClick(e.KeyChar, e);
                BeerAleNameBox.Focus();
            }
        }

        private void NonAlcoholicNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.NonAlcoholicNameBox_DoubleClick(e.KeyChar, e);
                NonAlcoholicNameBox.Focus();
            }
        }

        private void CoffeeTeaNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.CoffeeTeaNameBox_DoubleClick(e.KeyChar, e);
                CoffeeTeaNameBox.Focus();
            }
        }

        private void CustomNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.CustomNameBox_DoubleClick(e.KeyChar, e);
                CustomNameBox.Focus();
            }
        }
        private void DrinksNameBox_TabStopChanged(object sender, EventArgs e)
        {
            DrinksNameBox.TabStop = true;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DrinkSearch.Clear();
            DrinkSearch.Focus();

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AutoUpdater.Start("http://rbsoft.org/updates/right-click-enhancer.xml");
        }

        private void AddRecipeButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WizardPages.SelectedTab = CustomTab;
            toolStripStatusLabel1.Text = (this.CustomNameBox.ItemCount.ToString()) + " Custom Recipes ";
            customRecipes child = new customRecipes();
            child.MdiParent = this;
            client.BringToFront(); //This will make your child form shown on top.
            child.Show();
        }
        public void randomDrinkClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Connection shuffle = new Connection();
            shuffle.RandomConnection();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Refresh database
            CustomNameBox.DataSource = null;
            CustomNameBox.Items.Clear();
            //loads data into the 'custom_RecipesDataSet' table.
            this.myRecipesTableAdapter.Fill(this.myRecipes.myRecipes);
            CustomNameBox.DataSource = myRecipes.Tables["myRecipes"];
            CustomNameBox.DisplayMember = "name";
            CustomNameBox.ValueMember = "name";
        }
    }
  }
