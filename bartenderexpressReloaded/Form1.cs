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
using AutoUpdaterDotNET;
using DevExpress.XtraEditors;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers;
using System.Threading;
using System.Collections;
using System.Diagnostics;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.Gallery;
using DevExpress.Utils.Drawing;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using DevExpress.XtraBars.FluentDesignSystem;
using SecureApp;
using Devart.Data.SQLite;

namespace bartenderexpressReloaded
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static ListBoxControl f1ListBox;


        public Form1()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Path.Combine(Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData), "Lolliesoft"));
            InitializeComponent();
            InitSkinGallery();
            HideSkins(skinsToHide);
            // listBoxControl2 in CabinetSearch
            f1ListBox = IngredientsNameBox;
            RemoveBuyNow();
            NotifyNag();
            //Find the MdiClient and hold it by a variable
            client = Controls.OfType<MdiClient>().First();
            //This will check whenever client gets focused and there aren't any
            //child forms opened, Send the client to back so that the other controls can be shown back.
            client.GotFocus += (s, e) =>
            {
                if (!MdiChildren.Any(x => x.Visible)) client.SendToBack();

            };
        }
        MdiClient client;


        void InitSkinGallery()
        {
            //SkinHelper.InitSkinGallery(skinRibbonGalleryBarItem1, true);
            SkinHelper.InitSkinGallery(skinRibbonGalleryBarItem1);
        }


        string[] skinsToHide = { "DevExpress Style", "DevExpress Dark Style", "Seven Classic", "Seven" }; // populate with names of unnecessary skins

        public string statusbarrecipe { get; internal set; }

        private void HideSkins(string[] skinsToHide)
        {
            for (var i = 0; i < skinRibbonGalleryBarItem1.Gallery.Groups.Count; i++)
            {
                var group = skinRibbonGalleryBarItem1.Gallery.Groups[i];
                if (group == null)
                {
                    continue;
                }
                for (var j = 0; j < group.Items.Count; j++)
                {
                    var item = group.Items[j];
                    if (item == null)
                    {
                        continue;
                    }
                    foreach (var skin in skinsToHide)
                    {
                        if (String.Equals(item.Caption, skin))
                        {
                            item.Visible = false;
                        }
                    }
                }
            }
        }

        private void ribbonGalleryBarItem1_GalleryItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
            //MessageBox.Show(e.Item.Caption+" is being clicked!");
            switch (e.Item.Caption)
            {
                case "Facebook":
                    System.Diagnostics.Process.Start("https://www.facebook.com/lolliesoft");
                    break;
                case "Twitter":
                    System.Diagnostics.Process.Start("https://twitter.com/lolliesoft");
                    break;
                case "Lolliesoft":
                    System.Diagnostics.Process.Start("http://www.lolliesoft.com");
                    break;
                case "Vimeo":
                    MessageBox.Show("Coming soon");
                    //System.Diagnostics.Process.Start("http://www.lolliesoft.com");
                    break;
                case "YouTube":
                    MessageBox.Show("Coming soon");
                    //System.Diagnostics.Process.Start("http://www.lolliesoft.com");
                    break;
                case "Pinterest":
                    System.Diagnostics.Process.Start("https://www.pinterest.com/lolliesoft");
                    break;
                    //default:
                    //    MessageBox.Show("Not valid");
                    //    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 50; i++)
            {
                Thread.Sleep(50);
            }
            // TODO: This line of code loads data into the 'favoritesDataSet.Favorites' table. You can move, or remove it, as needed.
            this.favoritesTableAdapter.Fill(this.favoritesDataSet.Favorites);
            // TODO: This line of code loads data into the 'customDataSet.myRecipes' table. You can move, or remove it, as needed.
            this.myRecipesTableAdapter1.Fill(this.customDataSet.myRecipes);
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
                        string shotsCount = reader["shots_key"].ToString();
                        shotsCount = shotsCount.Remove(shotsCount.IndexOf('.'));
                        toolStripStatusLabel1.Text = "Shot " + shotsCount + " of " + (this.ShotsNameBox.ItemCount.ToString());

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
                statusbarrecipe = statusbarrecipe.Replace("'", "''");

                using (SQLiteConnection conn = new SQLiteConnection("Data Source = |DataDirectory|\\XpressShots.db"))
                {
                    conn.Open();

                    SQLiteCommand cmd = conn.CreateCommand();

                    cmd.Parameters.Add(new SQLiteParameter("@statusbarrecipe", statusbarrecipe));
                    cmd.CommandText = "SELECT liqueur_key FROM liqueurs WHERE name ='" + @statusbarrecipe + "'";

                    SQLiteDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        toolStripStatusLabel1.Text = "Liqueurs " + reader["liqueur_key"].ToString() + " of " + (this.LiqueursNameBox.ItemCount.ToString());
                    }
                }
            }
        }

        private void CocktailsListCount(object sender, EventArgs e)
        {
            if (CocktailsNameBox.SelectedItem != null)
            {
                string statusbarrecipe = CocktailsNameBox.SelectedValue.ToString();


                using (SQLiteConnection conn31 = new SQLiteConnection("Data Source = |DataDirectory|\\XpressShots.db"))
                {
                    conn31.Open();
                    SQLiteCommand cmd = new SQLiteCommand("SELECT cocktail_key FROM cocktails WHERE name='" + (statusbarrecipe.Trim().Replace("'", "''")) + "'", conn31);
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        //MessageBox.Show(this.DrinksNameBox.ItemCount.ToString());
                        toolStripStatusLabel1.Text = "Cocktail " + reader["cocktail_key"].ToString() + " of " + (this.CocktailsNameBox.ItemCount.ToString());

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
                        toolStripStatusLabel1.Text = "Punch " + (reader["punch_key"]).ToString() + " of " + (this.PunchesNameBox.ItemCount.ToString());

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
                statusbarrecipe = statusbarrecipe.Replace("'", "''");


                using (SQLiteConnection conn6 = new SQLiteConnection("Data Source = |DataDirectory|\\XpressShots.db"))
                {
                    conn6.Open();
                    SQLiteCommand cmd = conn6.CreateCommand();

                    cmd.Parameters.Add(new SQLiteParameter("@statusbarrecipe", statusbarrecipe));
                    cmd.CommandText = "SELECT coffeetea_key FROM coffeetea WHERE name ='" + @statusbarrecipe + "'";

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
                statusbarrecipe = statusbarrecipe.Replace("'", "''");

                using (SQLiteConnection conn6 = new SQLiteConnection("Data Source = |DataDirectory|\\Custom.db"))
                {
                    conn6.Open();

                    SQLiteCommand cmd = conn6.CreateCommand();

                    cmd.Parameters.Add(new SQLiteParameter("@statusbarrecipe", statusbarrecipe));
                    cmd.CommandText = "SELECT myrecipes_key FROM myRecipes WHERE name ='" + @statusbarrecipe + "'";

                    SQLiteDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        toolStripStatusLabel1.Text = "Custom Recipe " + reader["myrecipes_key"].ToString() + " of " + (this.CustomNameBox.ItemCount.ToString());
                    }
                }
            }
        }


        public Image byteArrayToImage(byte[] imagepic)
        {
            MemoryStream ms = new MemoryStream(imagepic);
            Image returnImage = Image.FromStream(ms);
            return returnImage;

        }


        public string recipeName { get; set; }
        public string tableIdent { get; set; }
        public void DrinksNameBox_DoubleClick(object sender, EventArgs e)
        {

            //string _statusbarrecipe2 = DrinksNameBox.SelectedValue.ToString();


            if (DrinksNameBox.SelectedItem != null)
            {

                string statusbarrecipe = DrinksNameBox.SelectedValue.ToString();
                string tablename = "drinks";
                tableIdent = tablename;
                toolStripStatusLabel1.Text = statusbarrecipe;
                recipeName = statusbarrecipe;
                //MessageBox.Show(recipeName);



                //toolStripStatusLabel2.Text = (this.nameListBox.Items.Count.ToString());

                using (SQLiteConnection cs = new SQLiteConnection("Data Source = |DataDirectory|\\bartenderExpress.db"))
                {
                    cs.Open();

                    //Get ID
                    SQLiteCommand cmd = new SQLiteCommand("SELECT id FROM recipes WHERE name='" + (statusbarrecipe.Trim().Replace("'", "''")) + "'", cs);
                    //SQLiteCommand cmd = new SQLiteCommand("SELECT id FROM recipes WHERE name ='" + statusbarrecipe + "'", cs);
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    //MessageBox.Show(reader["id"].ToString());

                    Form2 child = new Form2(statusbarrecipe, tablename);
                    child.toolStripStatusLabel.Text = statusbarrecipe;
                    child.Text = DrinksNameBox.SelectedValue.ToString();
                    child.FavoritesDrinkButton.Name = child.Text;
                    child.FavoritesDrinkButton.Text = "drinks";
                    //child.toolStripStatusLabel1.Text = statusbarrecipe;

                    child.MdiParent = this;
                    client.BringToFront();//This will make your child form shown on top.
                    child.Show();
                    child.DrinkfavoriteCheckForm1();
                    //Adds an icon to mdi child window
                    string path = Directory.GetCurrentDirectory() + "\\Resources\\Drinks.png";
                    Image myImg = Image.FromFile(path);
                    xtraTabbedMdiManager1.SelectedPage.Image = myImg;

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

                            List<string> ingredientslist = child.listView2.Items.Cast<ListViewItem>()
                                 .Select(x => x.Text).ToList();

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
                        child.DrinkTextBox.Font = new Font("Consolas", 14);

                        while (rdr.Read())
                        {

                            child.DrinkTextBox.Text = rdr[0].ToString();
                        }

                        //Get glasstype
                        //SQLiteCommand cmdglass = new SQLiteCommand("SELECT glasstype FROM recipes WHERE id = " + (reader["id"]) + "", cs);

                        SQLiteCommand cmdglass = new SQLiteCommand("SELECT pictures.picture FROM pictures INNER JOIN recipes ON pictures.id = recipes.id WHERE pictures.id IN (SELECT recipes.glasstype FROM recipes WHERE id = " + (reader["id"]) + ")", cs);



                        SQLiteDataReader rdrglass = cmdglass.ExecuteReader();
                        //MessageBox.Show(rdrglass["pictures.picture"].ToString());

                        while (rdrglass.Read())
                        {
                            //For Image inside a BLOB

                            byte[] imagepic = (byte[])rdrglass[0];
                            MemoryStream ms = new MemoryStream(imagepic);
                            Clipboard.SetImage(Image.FromStream(ms, true));
                            //child.richTextBox1.Paste();
                            child.DrinkBox.Image = Image.FromStream(ms, true);
                        }
                    }

                    cs.Close();
                }
            }
        }


        private void ShotsNameBox_DoubleClick(object sender, EventArgs e)
        {


            if (ShotsNameBox.SelectedItem != null)
            {

                string statusbarrecipe2 = ShotsNameBox.SelectedValue.ToString();
                string tablename = "shots";
                tableIdent = tablename;
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

                    Form3 child = new Form3();
                    child.Text = ShotsNameBox.SelectedValue.ToString();
                    child.FavoritesButton.Name = child.Text;
                    child.FavoritesButton.Text = "shots";
                    //child.FavoritesButton.Text = statusbarrecipe2.Substring(0, statusbarrecipe2.LastIndexOf("Name") + 1);
                    //child.toolStripStatusLabel1.Text = statusbarrecipe;

                    child.MdiParent = this;
                    client.BringToFront();//This will make your child form shown on top.   
                    child.Show();
                    //disables button in form3, if the favorite drink is present
                    child.DrinkfavoriteCheck();
                    //Adds an icon to mdi child window
                    string path = Directory.GetCurrentDirectory() + "\\Resources\\shots.png";
                    Image myImg = Image.FromFile(path);
                    xtraTabbedMdiManager1.SelectedPage.Image = myImg;



                    while (reader.Read())
                    {
                        // Get Ingredients
                        SQLiteCommand cmding = new SQLiteCommand("SELECT ingredient1, ingredient2, ingredient3, ingredient4, ingredient5, ingredient6, ingredient7, ingredient8, ingredient9, ingredient10, ingredient11, ingredient12, ingredient13, ingredient14, ingredient15 FROM shots WHERE shots_key=" + (reader["shots_key"]) + "", cs2);
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

                            ListViewItem ingredient15 = new ListViewItem();
                            ingredient15.SubItems[0].Text = rdring[14].ToString();
                            child.listView2.Items.Add(ingredient15);

                        }
                        //Get Amounts
                        SQLiteCommand cmdamt = new SQLiteCommand("SELECT amt1, amt2, amt3, amt4, amt5, amt6, amt7, amt8, amt9, amt10, amt11, amt12, amt13, amt14, amt15 FROM shots WHERE shots_key=" + (reader["shots_key"]) + "", cs2);
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

                            ListViewItem amt15 = new ListViewItem();
                            amt15.SubItems[0].Text = rdramt[14].ToString();
                            child.listView1.Items.Add(amt15);

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
                string tablename = "liqueurs";
                tableIdent = tablename;
                statusbarrecipe3 = statusbarrecipe3.Replace("'", "''");


                using (SQLiteConnection cs3 = new SQLiteConnection("Data Source = |DataDirectory|\\XpressShots.db"))
                {
                    cs3.Open();


                    SQLiteCommand cmd = cs3.CreateCommand();

                    cmd.Parameters.Add(new SQLiteParameter("@statusbarrecipe3", statusbarrecipe3));
                    cmd.CommandText = "SELECT liqueur_key FROM liqueurs WHERE name ='" + @statusbarrecipe3 + "'";

                    SQLiteDataReader reader = cmd.ExecuteReader();

                    //MessageBox.Show(reader["id"].ToString());

                    Form3 child = new Form3();
                    child.Text = LiqueursNameBox.SelectedValue.ToString();
                    child.FavoritesButton.Name = child.Text;
                    child.FavoritesButton.Text = "liqueurs";
                    //child.toolStripStatusLabel1.Text = statusbarrecipe;

                    child.MdiParent = this;
                    client.BringToFront();//This will make your child form shown on top.
                    child.Show();
                    //disables button in form3, if the favorite drink is present
                    child.DrinkfavoriteCheck();
                    //Adds an icon to mdi child window
                    string path = Directory.GetCurrentDirectory() + "\\Resources\\liqueurs.png";
                    Image myImg = Image.FromFile(path);
                    xtraTabbedMdiManager1.SelectedPage.Image = myImg;


                    while (reader.Read())
                    {
                        // Get Ingredients
                        SQLiteCommand cmding = new SQLiteCommand("SELECT ingredient1, ingredient2, ingredient3, ingredient4, ingredient5, ingredient6, ingredient7, ingredient8, ingredient9, ingredient10, ingredient11, ingredient12, ingredient13, ingredient14, ingredient15  FROM liqueurs WHERE liqueur_key=" + (reader["liqueur_key"]) + "", cs3);
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

                            ListViewItem ingredient15 = new ListViewItem();
                            ingredient15.SubItems[0].Text = rdring[14].ToString();
                            child.listView2.Items.Add(ingredient15);

                        }
                        //Get Amounts
                        SQLiteCommand cmdamt = new SQLiteCommand("SELECT amt1, amt2, amt3, amt4, amt5, amt6, amt7, amt8, amt9, amt10, amt11, amt12, amt13, amt14, amt15 FROM liqueurs WHERE liqueur_key=" + (reader["liqueur_key"]) + "", cs3);
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

                            ListViewItem amt15 = new ListViewItem();
                            amt15.SubItems[0].Text = rdramt[14].ToString();
                            child.listView1.Items.Add(amt15);
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
                    string tablename = "Punches";
                    tableIdent = tablename;

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

                        Form3 child = new Form3();
                        child.Text = PunchesNameBox.SelectedValue.ToString();
                        child.FavoritesButton.Name = child.Text;
                        child.FavoritesButton.Text = "punches";
                        //child.toolStripStatusLabel1.Text = statusbarrecipe;

                        child.MdiParent = this;
                        client.BringToFront();//This will make your child form shown on top.
                        child.Show();
                        //disables button in form3, if the favorite drink is present
                        child.DrinkfavoriteCheck();
                        //Adds an icon to mdi child window
                        string path = Directory.GetCurrentDirectory() + "\\Resources\\punches.png";
                        Image myImg = Image.FromFile(path);
                        xtraTabbedMdiManager1.SelectedPage.Image = myImg;



                        while (reader.Read())
                        {
                            // Get Ingredients
                            SQLiteCommand cmding = new SQLiteCommand("SELECT ingredient1, ingredient2, ingredient3, ingredient4, ingredient5, ingredient6, ingredient7, ingredient8, ingredient9, ingredient10, ingredient11, ingredient12, ingredient13, ingredient14, ingredient15 FROM punches WHERE punch_key=" + (reader["punch_key"]) + "", cs4);
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

                                ListViewItem ingredient15 = new ListViewItem();
                                ingredient15.SubItems[0].Text = rdring[14].ToString();
                                child.listView2.Items.Add(ingredient15);
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
                    string tablename = "Cocktails";
                    tableIdent = tablename;
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

                        Form3 child = new Form3();
                        child.Text = CocktailsNameBox.SelectedValue.ToString();
                        child.FavoritesButton.Name = child.Text;
                        child.FavoritesButton.Text = "cocktails";

                        //child.toolStripStatusLabel1.Text = statusbarrecipe;

                        child.MdiParent = this;
                        client.BringToFront();//This will make your child form shown on top.
                        child.Show();
                        //disables button in form3, if the favorite drink is present
                        child.DrinkfavoriteCheck();
                        //Adds an icon to mdi child window
                        string path = Directory.GetCurrentDirectory() + "\\Resources\\cocktails.png";
                        Image myImg = Image.FromFile(path);
                        xtraTabbedMdiManager1.SelectedPage.Image = myImg;


                        while (reader.Read())
                        {
                            // Get Ingredients
                            SQLiteCommand cmding = new SQLiteCommand("SELECT ingredient1, ingredient2, ingredient3, ingredient4, ingredient5, ingredient6, ingredient7, ingredient8, ingredient9, ingredient10, ingredient11, ingredient12, ingredient13, ingredient14, ingredient15 FROM cocktails WHERE cocktail_key=" + (reader["cocktail_key"]) + "", cs5);
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

                                ListViewItem ingredient15 = new ListViewItem();
                                ingredient15.SubItems[0].Text = rdring[14].ToString();
                                child.listView2.Items.Add(ingredient15);

                            }
                            //Get Amounts
                            SQLiteCommand cmdamt = new SQLiteCommand("SELECT amt1, amt2, amt3, amt4, amt5, amt6, amt7, amt8, amt9, amt10, amt11, amt12, amt13, amt14, amt15 FROM cocktails WHERE cocktail_key=" + (reader["cocktail_key"]) + "", cs5);
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

                                ListViewItem amt15 = new ListViewItem();
                                amt15.SubItems[0].Text = rdramt[14].ToString();
                                child.listView1.Items.Add(amt15);

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
                string tablename = "Beers";
                tableIdent = tablename;

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

                    Form3 child = new Form3();
                    child.Text = BeerAleNameBox.SelectedValue.ToString();
                    child.FavoritesButton.Name = child.Text;
                    child.FavoritesButton.Text = "beers";
                    //child.toolStripStatusLabel1.Text = statusbarrecipe;

                    child.MdiParent = this;
                    client.BringToFront();//This will make your child form shown on top.
                    child.Show();
                    //disables button in form3, if the favorite drink is present
                    child.DrinkfavoriteCheck();
                    //Adds an icon to mdi child window
                    string path = Directory.GetCurrentDirectory() + "\\Resources\\beers.png";
                    Image myImg = Image.FromFile(path);
                    xtraTabbedMdiManager1.SelectedPage.Image = myImg;


                    while (reader.Read())
                    {
                        // Get Ingredients
                        SQLiteCommand cmding = new SQLiteCommand("SELECT ingredient1, ingredient2, ingredient3, ingredient4, ingredient5, ingredient6, ingredient7, ingredient8, ingredient9, ingredient10, ingredient11, ingredient12, ingredient13, ingredient14, ingredient15  FROM beers WHERE beer_key=" + (reader["beer_key"]) + "", cs6);
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

                            ListViewItem ingredient15 = new ListViewItem();
                            ingredient15.SubItems[0].Text = rdring[14].ToString();
                            child.listView2.Items.Add(ingredient15);
                        }
                        //Get Amounts
                        SQLiteCommand cmdamt = new SQLiteCommand("SELECT amt1, amt2, amt3, amt4, amt5, amt6, amt7, amt8, amt9, amt10, amt11, amt12, amt13, amt14, amt15 FROM beers WHERE beer_key=" + (reader["beer_key"]) + "", cs6);
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

                            ListViewItem amt15 = new ListViewItem();
                            amt15.SubItems[0].Text = rdramt[14].ToString();
                            child.listView1.Items.Add(amt15);
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
                string tablename = "NonAlcoholic";
                tableIdent = tablename;
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

                    Form3 child = new Form3();
                    child.Text = NonAlcoholicNameBox.SelectedValue.ToString();
                    child.FavoritesButton.Name = child.Text;
                    child.FavoritesButton.Text = "nonalcoholic";

                    //child.toolStripStatusLabel1.Text = statusbarrecipe;

                    child.MdiParent = this;
                    client.BringToFront();//This will make your child form shown on top.
                    child.Show();
                    //disables button in form3, if the favorite drink is present
                    child.DrinkfavoriteCheck();
                    //Adds an icon to mdi child window
                    string path = Directory.GetCurrentDirectory() + "\\Resources\\nonAlcohol.png";
                    Image myImg = Image.FromFile(path);
                    xtraTabbedMdiManager1.SelectedPage.Image = myImg;



                    while (reader.Read())
                    {
                        // Get Ingredients
                        SQLiteCommand cmding = new SQLiteCommand("SELECT ingredient1, ingredient2, ingredient3, ingredient4, ingredient5, ingredient6, ingredient7, ingredient8, ingredient9, ingredient10, ingredient11, ingredient12, ingredient13, ingredient14, ingredient15 FROM nonalcoholic WHERE nonalcoholic_key=" + (reader["nonalcoholic_key"]) + "", cs7);
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

                            ListViewItem ingredient15 = new ListViewItem();
                            ingredient15.SubItems[0].Text = rdring[14].ToString();
                            child.listView2.Items.Add(ingredient15);

                        }
                        //Get Amounts
                        SQLiteCommand cmdamt = new SQLiteCommand("SELECT amt1, amt2, amt3, amt4, amt5, amt6, amt7, amt8, amt9, amt10, amt11, amt12, amt13, amt14, amt15 FROM nonalcoholic WHERE nonalcoholic_key=" + (reader["nonalcoholic_key"]) + "", cs7);
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

                            ListViewItem amt15 = new ListViewItem();
                            amt15.SubItems[0].Text = rdramt[14].ToString();
                            child.listView1.Items.Add(amt15);

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
                string tablename = "CoffeeTea";
                tableIdent = tablename;
                toolStripStatusLabel1.Text = statusbarrecipe2;



                using (SQLiteConnection conn6 = new SQLiteConnection("Data Source = |DataDirectory|\\XpressShots.db"))
                {
                    conn6.Open();

                    //Get ID
                    //string selectedvalue

                    SQLiteCommand cmd = new SQLiteCommand("SELECT coffeetea_key FROM coffeetea WHERE name ='" + (statusbarrecipe2.Trim().Replace("'", "''")) + " '", conn6);
                    SQLiteDataReader reader = cmd.ExecuteReader();


                    Form3 child = new Form3();
                    child.Text = CoffeeTeaNameBox.SelectedValue.ToString();
                    child.FavoritesButton.Name = child.Text;
                    child.FavoritesButton.Text = "coffeetea";
                    //child.toolStripStatusLabel1.Text = statusbarrecipe;

                    child.MdiParent = this;
                    client.BringToFront();//This will make your child form shown on top.
                    child.Show();
                    //disables button in form3, if the favorite drink is present
                    child.DrinkfavoriteCheck();
                    //Adds an icon to mdi child window
                    string path = Directory.GetCurrentDirectory() + "\\Resources\\teaCoffee.png";
                    Image myImg = Image.FromFile(path);
                    xtraTabbedMdiManager1.SelectedPage.Image = myImg;


                    while (reader.Read())
                    {
                        // Get Ingredients
                        SQLiteCommand cmding = new SQLiteCommand("SELECT ingredient1, ingredient2, ingredient3, ingredient4, ingredient5, ingredient6, ingredient7, ingredient8, ingredient9, ingredient10, ingredient11, ingredient12, ingredient13, ingredient14, ingredient15 FROM coffeetea WHERE coffeetea_key=" + (reader["coffeetea_key"]) + "", conn6);
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

                            ListViewItem ingredient15 = new ListViewItem();
                            ingredient15.SubItems[0].Text = rdring[14].ToString();
                            child.listView2.Items.Add(ingredient15);


                        }
                        //Get Amounts
                        SQLiteCommand cmdamt = new SQLiteCommand("SELECT amt1, amt2, amt3, amt4, amt5, amt6, amt7, amt8, amt9, amt10, amt11, amt12, amt13, amt14, amt15 FROM coffeetea WHERE coffeetea_key=" + (reader["coffeetea_key"]) + "", conn6);
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

                            ListViewItem amt15 = new ListViewItem();
                            amt15.SubItems[0].Text = rdramt[14].ToString();
                            child.listView1.Items.Add(amt15);
                        }

                        //Get Directions
                        SQLiteCommand cmddir = new SQLiteCommand("SELECT directions FROM coffeetea WHERE coffeetea_key= " + (reader["coffeetea_key"]) + "", conn6);
                        SQLiteDataReader rdr = cmddir.ExecuteReader();

                        while (rdr.Read())
                        {
                            child.richTextBox1.Text = rdr[0].ToString();
                        }

                    }
                    conn6.Close();
                }
            }

        }

        private void CustomNameBox_DoubleClick(object sender, EventArgs e)
        {
            if (CustomNameBox.SelectedItem != null)
            {
                string statusbarrecipe2 = CustomNameBox.SelectedValue.ToString();
                string tablename = "Custom";
                tableIdent = tablename;
                statusbarrecipe2 = statusbarrecipe2.Replace("'", "''");
                toolStripStatusLabel1.Text = statusbarrecipe2;


                using (SQLiteConnection conn21 = new SQLiteConnection("Data Source = |DataDirectory|\\Custom.db"))
                {
                    conn21.Open();

                    SQLiteCommand cmd = conn21.CreateCommand();

                    cmd.Parameters.Add(new SQLiteParameter("@statusbarrecipe2", statusbarrecipe2));
                    cmd.CommandText = "SELECT myrecipes_key FROM MyRecipes WHERE name ='" + @statusbarrecipe2 + "'";

                    SQLiteDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        //MessageBox.Show(reader["myrecipes_key"].ToString());
                        Form3 child = new Form3();
                        child.Text = CustomNameBox.SelectedValue.ToString();
                        child.FavoritesButton.Name = child.Text;
                        child.FavoritesButton.Text = "myRecipes";
                        //child.toolStripStatusLabel1.Text = statusbarrecipe;
                        child.MdiParent = this;
                        client.BringToFront();//This will make your child form shown on top.
                        child.Show();

                        //disables button in form3, if the favorite drink is present
                        child.DrinkfavoriteCheck();
                        //Adds an icon to mdi child window
                        string path = Directory.GetCurrentDirectory() + "\\Resources\\CustomRecipe.png";
                        Image myImg = Image.FromFile(path);
                        xtraTabbedMdiManager1.SelectedPage.Image = myImg;


                        //if (reader.Read())
                        {
                            // Get Ingredients
                            SQLiteCommand cmding = new SQLiteCommand("SELECT ingredient1, ingredient2, ingredient3, ingredient4, ingredient5, ingredient6, ingredient7, ingredient8, ingredient9, ingredient10, ingredient11, ingredient12, ingredient13, ingredient14, ingredient15 FROM myRecipes WHERE myrecipes_key =" + (reader["myrecipes_key"]) + "", conn21);
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

                                ListViewItem ingredient15 = new ListViewItem();
                                ingredient15.SubItems[0].Text = rdring[14].ToString();
                                child.listView2.Items.Add(ingredient15);

                            }

                            //Get Amounts
                            SQLiteCommand cmdamt = new SQLiteCommand("SELECT amt1, amt2, amt3, amt4, amt5, amt6, amt7, amt8, amt9, amt10, amt11, amt12, amt13, amt14, amt15 FROM myRecipes WHERE myrecipes_key=" + (reader["myrecipes_key"]) + "", conn21);
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

                                ListViewItem amt15 = new ListViewItem();
                                amt15.SubItems[0].Text = rdramt[14].ToString();
                                child.listView1.Items.Add(amt15);
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




        private void FavoritesNameBox_DoubleClick(object sender, EventArgs e)
        {
            if (FavoritesNameBox.SelectedItem != null)
            {
                string statusbarrecipe2 = FavoritesNameBox.SelectedValue.ToString();
                statusbarrecipe2 = statusbarrecipe2.Replace("'", "''");
                toolStripStatusLabel1.Text = statusbarrecipe2;


                using (SQLiteConnection conn22 = new SQLiteConnection("Data Source = |DataDirectory|\\Custom.db"))
                {
                    conn22.Open();

                    SQLiteCommand cmd = conn22.CreateCommand();

                    cmd.Parameters.Add(new SQLiteParameter("@statusbarrecipe2", statusbarrecipe2));
                    cmd.CommandText = "SELECT favorites_key FROM Favorites WHERE name ='" + @statusbarrecipe2 + "'";

                    SQLiteDataReader reader = cmd.ExecuteReader();


                    if (reader.Read())
                    {
                        //MessageBox.Show(reader["myrecipes_key"].ToString());
                        Form4 child = new Form4();
                        child.Text = FavoritesNameBox.SelectedValue.ToString();
                        //child.toolStripStatusLabel1.Text = statusbarrecipe;
                        child.MdiParent = this;
                        client.BringToFront();//This will make your child form shown on top.
                        child.Show();
                        //Adds an icon to mdi child window
                        string path = Directory.GetCurrentDirectory() + "\\Resources\\favorite.png";
                        Image myImg = Image.FromFile(path);
                        xtraTabbedMdiManager1.SelectedPage.Image = myImg;

                        //if (reader.Read())
                        {
                            // Get Ingredients
                            SQLiteCommand cmding = new SQLiteCommand("SELECT ingredient1, ingredient2, ingredient3, ingredient4, ingredient5, ingredient6, ingredient7, ingredient8, ingredient9, ingredient10, ingredient11, ingredient12, ingredient13, ingredient14, ingredient15 FROM Favorites WHERE favorites_key =" + (reader["favorites_key"]) + "", conn22);
                            SQLiteDataReader rdring = cmding.ExecuteReader();

                            if (rdring.Read())
                            {
                                ListViewItem ingredient1 = new ListViewItem();
                                ingredient1.SubItems[0].Text = rdring[0].ToString().Trim();
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

                                ListViewItem ingredient15 = new ListViewItem();
                                ingredient15.SubItems[0].Text = rdring[14].ToString();
                                child.listView2.Items.Add(ingredient15);

                            }

                            //Get Amounts
                            SQLiteCommand cmdamt = new SQLiteCommand("SELECT amt1, amt2, amt3, amt4, amt5, amt6, amt7, amt8, amt9, amt10, amt11, amt12, amt13, amt14, amt15 FROM Favorites WHERE favorites_key=" + (reader["favorites_key"]) + "", conn22);
                            SQLiteDataReader rdramt = cmdamt.ExecuteReader();

                            if (rdramt.Read())
                            {
                                ListViewItem amt1 = new ListViewItem();
                                amt1.SubItems[0].Text = rdramt[0].ToString().Trim();
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

                                ListViewItem amt15 = new ListViewItem();
                                amt15.SubItems[0].Text = rdramt[14].ToString();
                                child.listView1.Items.Add(amt15);
                            }

                            //Get Directions
                            SQLiteCommand cmddir = new SQLiteCommand("SELECT directions FROM Favorites WHERE favorites_key= " + (reader["favorites_key"]) + "", conn22);
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

        private void IngredientsNameBox_DoubleClick(object sender, EventArgs e)
        {


            if (IngredientsNameBox.SelectedItem != null)
            {

                string statusbarrecipe2 = f1ListBox.SelectedValue.ToString();
                toolStripStatusLabel1.Text = statusbarrecipe2;


                using (SQLiteConnection cs106 = new SQLiteConnection("Data Source = |DataDirectory|\\XpressShots.db"))
                {
                    cs106.Open();


                    //Get ID
                    //string selectedvalue

                    SQLiteCommand cmd = new SQLiteCommand("SELECT DrinkID FROM masterdrinks WHERE name ='" + (statusbarrecipe2.Trim().Replace("'", "''")) + "'", cs106);

                    SQLiteDataReader reader = cmd.ExecuteReader();

                    Form3 child = new Form3();
                    child.Text = f1ListBox.SelectedValue.ToString();
                    child.FavoritesButton.Name = child.Text;
                    child.FavoritesButton.Text = "liqueurCabinet";

                    child.MdiParent = this;
                    client.BringToFront();//This will make your child form shown on top.
                    child.Show();

                    int i = 0;

                    if (i == 0)
                    {
                        while (reader.Read())
                        {
                            // Get Ingredients
                            SQLiteCommand cmding = new SQLiteCommand("SELECT ingredient1, ingredient2, ingredient3, ingredient4, ingredient5, ingredient6, ingredient7, ingredient8, ingredient9, ingredient10, ingredient11, ingredient12, ingredient13, ingredient14, ingredient15 FROM masterdrinks WHERE DrinkID=" + (reader["DrinkID"]) + "", cs106);
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

                                ListViewItem ingredient15 = new ListViewItem();
                                ingredient15.SubItems[0].Text = rdring[14].ToString();
                                child.listView2.Items.Add(ingredient15);

                            }

                            //Get Amounts
                            SQLiteCommand cmdamt = new SQLiteCommand("SELECT amt1, amt2, amt3, amt4, amt5, amt6, amt7, amt8, amt9, amt10, amt11, amt12, amt13, amt14, amt15 FROM masterdrinks WHERE DrinkID=" + (reader["DrinkID"]) + "", cs106);
                            SQLiteDataReader rdramt = cmdamt.ExecuteReader();

                            while (rdramt.Read())
                            {
                                ListViewItem amt1 = new ListViewItem();
                                amt1.SubItems[0].Text = rdramt[0].ToString();
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

                                ListViewItem amt15 = new ListViewItem();
                                amt15.SubItems[0].Text = rdramt[14].ToString();
                                child.listView1.Items.Add(amt15);

                            }

                            //Get Directions
                            SQLiteCommand cmddir = new SQLiteCommand("SELECT directions FROM masterdrinks WHERE DrinkID = " + (reader["DrinkID"]) + "", cs106);
                            SQLiteDataReader rdr = cmddir.ExecuteReader();

                            while (rdr.Read())
                            {
                                child.richTextBox1.Text = rdr[0].ToString();
                            }


                        }

                        i++;
                    }

                    // cs106.Close(); 
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
            //Adds an icon to mdi child window
            string path = Directory.GetCurrentDirectory() + "\\Resources\\CustomRecipe.png";
            Image myImg = Image.FromFile(path);
            xtraTabbedMdiManager1.SelectedPage.Image = myImg;

        }


        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            WizardPages.SelectedTab = Favorites;
            FavoritesNameBox.Show();
            FavoritesNameBox.Focus();
            toolStripStatusLabel1.Text = (this.FavoritesNameBox.ItemCount.ToString()) + " Favorites Recipes ";
        }

        private void MyRecipesItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            WizardPages.SelectedTab = CustomTab;
            CustomNameBox.Show();
            CustomNameBox.Focus();
            toolStripStatusLabel1.Text = (this.CustomNameBox.ItemCount.ToString()) + " Custom Recipes ";
        }


        private void IBoxItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            CabinetSearch child = new CabinetSearch();
            child.MdiParent = this;
            client.BringToFront();//This will make your child form shown on top.
            child.Show();
            string path = Directory.GetCurrentDirectory() + "\\Resources\\liqueurCabinet.png";
            Image myImg = Image.FromFile(path);
            xtraTabbedMdiManager1.SelectedPage.Image = myImg;
            WizardPages.SelectedTab = IngredientsTab;
            IngredientsNameBox.Show();
            IngredientsNameBox.Focus();
            toolStripStatusLabel1.Text = (this.IngredientsNameBox.ItemCount.ToString()) + " Recipes with your Ingredients";

        }

        private void IngredientsSearch_TextChanged(object sender, EventArgs e)
        {
            IngredientsSearch.Font = new Font("Default", 8, FontStyle.Regular);
            int index = IngredientsNameBox.FindString(IngredientsSearch.Text);
            if (0 <= index)
            {
                IngredientsNameBox.SelectedIndex = index;
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

        private void IngredientNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.DrinksNameBox_DoubleClick(e.KeyChar, e);
                DrinksNameBox.Focus();
            }

        }
        private void DrinksNameBox_TabStopChanged(object sender, EventArgs e)
        {
            DrinksNameBox.TabStop = true;
        }

        private void IngredientsNameBox_TabStopChanged(object sender, EventArgs e)
        {
            IngredientsNameBox.TabStop = true;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AutoUpdater.Start("http://lolliesoft.com/updates/software.xml");
        }

        private void AddRecipeButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WizardPages.SelectedTab = CustomTab;
            toolStripStatusLabel1.Text = (this.CustomNameBox.ItemCount.ToString()) + " Custom Recipes ";
            customRecipes child = new customRecipes();
            child.MdiParent = this;
            client.BringToFront(); //This will make your child form shown on top.
            child.Show();
            //Adds an icon to mdi child window
            string path = Directory.GetCurrentDirectory() + "\\Resources\\CustomRecipe.png";
            Image myImg = Image.FromFile(path);
            xtraTabbedMdiManager1.SelectedPage.Image = myImg;
        }
        public void randomDrinkClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Connection shuffle = new Connection();           
            //shuffle.RandomConnection();
            //string statusbarrecipe = DrinksNameBox.SelectedValue.ToString();
            //string tablename = "drinks";
            //toolStripStatusLabel1.Text = statusbarrecipe;


            using (SQLiteConnection cs101 = new SQLiteConnection("Data Source = |DataDirectory|\\bartenderExpress.db"))
            {
                cs101.Open();

                //Get ID
                SQLiteCommand cmd = new SQLiteCommand("SELECT id,name FROM recipes ORDER BY RANDOM() LIMIT 1", cs101);
                SQLiteDataReader reader = cmd.ExecuteReader();



                while (reader.Read())
                {
                    //string statusbarrecipe = DrinksNameBox.SelectedValue.ToString();
                    string tablename = "drinks";

                    string DrinkName = reader["name"].ToString();
                    toolStripStatusLabel1.Text = DrinkName;

                    // Get Ingredients
                    SQLiteCommand cmding = new SQLiteCommand("SELECT name FROM ingredients INNER JOIN recipeingredients ON ingredients.id=recipeingredients.ingid WHERE recipeid=" + (reader["id"]) + "", cs101);
                    SQLiteDataReader rdring = cmding.ExecuteReader();

                    Form2 child = new Form2(DrinkName, tablename);
                    child.Text = DrinkName;
                    //child.FavoritesButton.Name = child.Text;
                    //child.toolStripStatusLabel1.Text = child.Text;
                    child.MdiParent = this;
                    client.BringToFront(); //This will make your child form shown on top.
                    child.Show();
                    //Adds an icon to mdi child window
                    string path = Directory.GetCurrentDirectory() + "\\Resources\\shuffle.png";
                    Image myImg = Image.FromFile(path);
                    xtraTabbedMdiManager1.SelectedPage.Image = myImg;

                    while (rdring.Read())
                    {
                        ListViewItem ingredients = new ListViewItem();
                        ingredients.SubItems[0].Text = rdring[0].ToString();
                        child.listView2.Items.Add(ingredients);

                    }
                    //Get Amounts
                    SQLiteCommand cmdamt = new SQLiteCommand("SELECT amount FROM recipeingredients INNER JOIN ingredients ON ingredients.id=recipeingredients.ingid WHERE recipeid=" + (reader["id"]) + "", cs101);
                    SQLiteDataReader rdramt = cmdamt.ExecuteReader();

                    while (rdramt.Read())
                    {
                        ListViewItem amount = new ListViewItem();
                        amount.SubItems[0].Text = rdramt[0].ToString();
                        child.listView1.Items.Add(amount);
                    }

                    //Get Directions
                    SQLiteCommand cmddir = new SQLiteCommand("SELECT directions FROM recipes WHERE id = " + (reader["id"]) + "", cs101);
                    SQLiteDataReader rdr = cmddir.ExecuteReader();
                    child.richTextBox1.Font = new Font("Consolas", 14);

                    while (rdr.Read())
                    {
                        child.DrinkTextBox.Text = rdr[0].ToString();

                    }

                    //Get glasstype
                    //SQLiteCommand cmdglass = new SQLiteCommand("SELECT glasstype FROM recipes WHERE id = " + (reader["id"]) + "", cs);

                    SQLiteCommand cmdglass = new SQLiteCommand("SELECT pictures.picture FROM pictures INNER JOIN recipes ON pictures.id = recipes.id WHERE pictures.id IN (SELECT recipes.glasstype FROM recipes WHERE id = " + (reader["id"]) + ")", cs101);



                    SQLiteDataReader rdrglass = cmdglass.ExecuteReader();
                    //MessageBox.Show(rdrglass["pictures.picture"].ToString());

                    while (rdrglass.Read())
                    {
                        //For Image inside a BLOB

                        byte[] imagepic = (byte[])rdrglass[0];
                        MemoryStream ms = new MemoryStream(imagepic);
                        Clipboard.SetImage(Image.FromStream(ms, true));
                        //child.richTextBox1.Paste();
                        child.DrinkBox.Image = Image.FromStream(ms, true);
                    }
                }
            }
        }

        public void favoritesDrinkClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            WizardPages.SelectedTab = Favorites;
            FavoritesNameBox.Show();
            FavoritesNameBox.Focus();
            toolStripStatusLabel1.Text = (this.FavoritesNameBox.ItemCount.ToString()) + " Favorites Recipes ";
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BAC_Calculator child = new BAC_Calculator();
            child.MdiParent = this;
            client.BringToFront();//This will make your child form shown on top.    
            child.StartPosition = FormStartPosition.CenterScreen;
            child.Show();
            //Adds an icon to mdi child window
            string path1 = Directory.GetCurrentDirectory() + "\\Resources\\Calculator.png";
            Image myImg1 = Image.FromFile(path1);
            xtraTabbedMdiManager1.SelectedPage.Image = myImg1;
        }

        private void CustomNameBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int oldFocusedIndex = CustomNameBox.SelectedIndex;
        }

        private void RefreshIngredientStatusStrip()
        {
            //Refresh statustrip when using ingredients search

            if (IngredientsNameBox.ItemCount > 0)
            {
                toolStripStatusLabel1.Text = (this.IngredientsNameBox.ItemCount.ToString()) + " Recipes with your Ingredients";
            }
            else if (IngredientsNameBox.ItemCount == 0)
            {
                toolStripStatusLabel1.Text = ("Double Click to Open Recipe");
            }

        }


        private void RefreshMyRecipes()
        {

            int oldFocusedIndex = CustomNameBox.SelectedIndex;

            //Refresh database
            CustomNameBox.DataSource = null;
            CustomNameBox.Items.Clear();
            //loads data into the 'custom_RecipesDataSet' table.
            this.myRecipesTableAdapter1.Fill(this.customDataSet.myRecipes);
            CustomNameBox.DataSource = customDataSet.Tables["myRecipes"];
            CustomNameBox.DisplayMember = "name";
            CustomNameBox.ValueMember = "name";

            CustomNameBox.SelectedIndex = oldFocusedIndex;

        }

        private void RefreshFavorites()
        {

            int oldFocusedIndex1 = FavoritesNameBox.SelectedIndex;

            //Refresh database
            FavoritesNameBox.DataSource = null;
            FavoritesNameBox.Items.Clear();
            //loads data into the 'custom_RecipesDataSet' table.
            this.favoritesTableAdapter.Fill(this.favoritesDataSet.Favorites);
            FavoritesNameBox.DataSource = favoritesDataSet.Tables["Favorites"];
            FavoritesNameBox.DisplayMember = "name";
            FavoritesNameBox.ValueMember = "name";

            FavoritesNameBox.SelectedIndex = oldFocusedIndex1;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            RefreshMyRecipes();
            RefreshFavorites();
            RefreshIngredientStatusStrip();
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string folderPath = string.Empty;
            string fullfolderPath = string.Empty;


            using (FolderBrowserDialog fdb = new FolderBrowserDialog())
            {
                fdb.Description = "Select Backup Location for My Recipes backup";
                fdb.RootFolder = Environment.SpecialFolder.Desktop;

                if (fdb.ShowDialog() == DialogResult.OK)
                {

                    folderPath = fdb.SelectedPath;
                    fullfolderPath = folderPath + "\\Backup.db";

                    using (var source = new SQLiteConnection("Data Source = |DataDirectory|\\Custom.db; Version=3;"))
                    using (var destination = new SQLiteConnection("Data Source=" + fullfolderPath + "; Version=3;"))
                    {
                        source.Open();
                        destination.Open();
                        //source.BackupDatabase(destination, "main", "main", -1, null, 0);
                        source.BackupDatabase(destination, "main", "main", -1);


                    }

                    MessageBox.Show("Backup.db saved to: " + fullfolderPath + "\n" + "Use this file to restore your custom Recipes at a later time", "Custom Recipes Backed up", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenFileDialog odb = new OpenFileDialog();

            odb.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            odb.Filter = "Data Base File |*.db";
            odb.FilterIndex = 1;
            odb.Multiselect = true;
            string restorefolderPath = string.Empty;

            if (odb.ShowDialog() == DialogResult.OK)
            {
                string directoryPath = System.IO.Path.GetDirectoryName(odb.FileName);
                restorefolderPath = odb.FileName;
                using (var source = new SQLiteConnection("Data Source=" + restorefolderPath + "; Version=3;"))
                using (var destination = new SQLiteConnection("Data Source = |DataDirectory|\\Custom.db; Version=3;"))
                {
                    source.Open();
                    destination.Open();
                    //source.BackupDatabase(destination, "main", "main", -1, null, 0);
                    source.BackupDatabase(destination, "main", "main", -1);
                }

                MessageBox.Show("Backup.db restored" + "\n" + "All custom recipes exported", "Custom Recipes Restored", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            WizardPages.SelectedTab = CustomTab;
            toolStripStatusLabel1.Text = (this.CustomNameBox.ItemCount.ToString()) + " Custom Recipes ";
            customRecipes child = new customRecipes();
            child.MdiParent = this;
            client.BringToFront(); //This will make your child form shown on top.
            child.Show();
            string path = Directory.GetCurrentDirectory() + "\\Resources\\CustomRecipe.png";
            Image myImg = Image.FromFile(path);
            xtraTabbedMdiManager1.SelectedPage.Image = myImg;
        }

        private void randomdrink_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (SQLiteConnection cs102 = new SQLiteConnection("Data Source = |DataDirectory|\\bartenderExpress.db"))
            {
                cs102.Open();

                //Get ID
                SQLiteCommand cmd = new SQLiteCommand("SELECT id,name FROM recipes ORDER BY RANDOM() LIMIT 1", cs102);
                SQLiteDataReader reader = cmd.ExecuteReader();



                while (reader.Read())
                {
                    //string statusbarrecipe = DrinksNameBox.SelectedValue.ToString();
                    string tablename = "drinks";

                    string DrinkName = reader["name"].ToString();
                    toolStripStatusLabel1.Text = DrinkName;

                    // Get Ingredients
                    SQLiteCommand cmding = new SQLiteCommand("SELECT name FROM ingredients INNER JOIN recipeingredients ON ingredients.id=recipeingredients.ingid WHERE recipeid=" + (reader["id"]) + "", cs102);
                    SQLiteDataReader rdring = cmding.ExecuteReader();

                    Form2 child = new Form2(DrinkName, tablename);
                    child.Text = DrinkName;
                    //child.FavoritesButton.Name = child.Text;
                    //child.toolStripStatusLabel1.Text = child.Text;
                    child.MdiParent = this;
                    client.BringToFront(); //This will make your child form shown on top.
                    child.Show();

                    //Adds an icon to mdi child window
                    string path1 = Directory.GetCurrentDirectory() + "\\Resources\\shuffle.png";
                    Image myImg1 = Image.FromFile(path1);
                    xtraTabbedMdiManager1.SelectedPage.Image = myImg1;

                    while (rdring.Read())
                    {
                        ListViewItem ingredients = new ListViewItem();
                        ingredients.SubItems[0].Text = rdring[0].ToString();
                        child.listView2.Items.Add(ingredients);

                    }
                    //Get Amounts
                    SQLiteCommand cmdamt = new SQLiteCommand("SELECT amount FROM recipeingredients INNER JOIN ingredients ON ingredients.id=recipeingredients.ingid WHERE recipeid=" + (reader["id"]) + "", cs102);
                    SQLiteDataReader rdramt = cmdamt.ExecuteReader();

                    while (rdramt.Read())
                    {
                        ListViewItem amount = new ListViewItem();
                        amount.SubItems[0].Text = rdramt[0].ToString();
                        child.listView1.Items.Add(amount);
                    }

                    //Get Directions
                    SQLiteCommand cmddir = new SQLiteCommand("SELECT directions FROM recipes WHERE id = " + (reader["id"]) + "", cs102);
                    SQLiteDataReader rdr = cmddir.ExecuteReader();
                    child.richTextBox1.Font = new Font("Consolas", 14);

                    while (rdr.Read())
                    {
                        child.DrinkTextBox.Text = rdr[0].ToString();

                    }

                    //Get glasstype
                    //SQLiteCommand cmdglass = new SQLiteCommand("SELECT glasstype FROM recipes WHERE id = " + (reader["id"]) + "", cs);

                    SQLiteCommand cmdglass = new SQLiteCommand("SELECT pictures.picture FROM pictures INNER JOIN recipes ON pictures.id = recipes.id WHERE pictures.id IN (SELECT recipes.glasstype FROM recipes WHERE id = " + (reader["id"]) + ")", cs102);



                    SQLiteDataReader rdrglass = cmdglass.ExecuteReader();
                    //MessageBox.Show(rdrglass["pictures.picture"].ToString());

                    while (rdrglass.Read())
                    {
                        //For Image inside a BLOB

                        byte[] imagepic = (byte[])rdrglass[0];
                        MemoryStream ms = new MemoryStream(imagepic);
                        Clipboard.SetImage(Image.FromStream(ms, true));
                        //child.richTextBox1.Paste();
                        child.DrinkBox.Image = Image.FromStream(ms, true);
                    }
                }
            }
        }

        private void Liqueur_ItemClick(object sender, ItemClickEventArgs e)
        {
            CabinetSearch child = new CabinetSearch();
            child.MdiParent = this;
            client.BringToFront();//This will make your child form shown on top.
            child.Show();
            string path = Directory.GetCurrentDirectory() + "\\Resources\\liqueurCabinet.png";
            Image myImg = Image.FromFile(path);
            xtraTabbedMdiManager1.SelectedPage.Image = myImg;

            WizardPages.SelectedTab = IngredientsTab;
            IngredientsNameBox.Show();
            IngredientsNameBox.Focus();
            toolStripStatusLabel1.Text = (IngredientsNameBox.ItemCount.ToString()) + " Recipes with your Ingredients";
        }

        private void tileItem5_ItemClick(object sender, TileItemEventArgs e)
        {
            BAC_Calculator child = new BAC_Calculator();
            child.MdiParent = this;
            client.BringToFront();//This will make your child form shown on top.    
            child.StartPosition = FormStartPosition.CenterScreen;
            child.Show();
            //Adds an icon to mdi child window
            string path = Directory.GetCurrentDirectory() + "\\Resources\\Calculator.png";
            Image myImg = Image.FromFile(path);
            xtraTabbedMdiManager1.SelectedPage.Image = myImg;
        }


        private void tileItem8_ItemClick(object sender, TileItemEventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + "\\BartenderExpressCalculator.exe");
        }

        private void Calculator_ItemClick(object sender, ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + "\\BartenderExpressCalculator.exe");
        }

        private void tileItem7_ItemClick(object sender, TileItemEventArgs e)
        {
            AutoUpdater.Start("http://lolliesoft.com/updates/software.xml");
        }

        private void tileItem3_ItemClick(object sender, TileItemEventArgs e)
        {
            CabinetSearch child = new CabinetSearch();
            child.MdiParent = this;
            client.BringToFront();//This will make your child form shown on top.
            child.Show();
            string path = Directory.GetCurrentDirectory() + "\\Resources\\liqueurCabinet.png";
            Image myImg = Image.FromFile(path);
            xtraTabbedMdiManager1.SelectedPage.Image = myImg;
            WizardPages.SelectedTab = IngredientsTab;
            IngredientsNameBox.Show();
            IngredientsNameBox.Focus();
            toolStripStatusLabel1.Text = (this.IngredientsNameBox.ItemCount.ToString()) + " Recipes with your Ingredients";
        }

        private void RemovecustomDrink()
        {
            string statusbarrecipe = CustomNameBox.SelectedValue.ToString();
            statusbarrecipe = statusbarrecipe.Replace("'", "''");
            toolStripStatusLabel1.Text = statusbarrecipe;

            if (statusbarrecipe != null)
            {
                using (SQLiteConnection cs403 = new SQLiteConnection("Data Source = |DataDirectory|\\Custom.db"))
                {

                    //create command
                    SQLiteCommand cmd2 = new SQLiteCommand();
                    cmd2.CommandText = "DELETE FROM MyRecipes WHERE name='" + statusbarrecipe + "'";
                    cmd2.Connection = cs403;

                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    cs403.Open();
                    cmd2.ExecuteNonQuery();
                    cs403.Close();
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                }
                using (SQLiteConnection cs404 = new SQLiteConnection("Data Source = |DataDirectory|\\XpressShots.db"))
                {

                    //create command
                    SQLiteCommand cmd3 = new SQLiteCommand();
                    cmd3.CommandText = "DELETE FROM MyRecipes WHERE name='" + statusbarrecipe + "'";
                    cmd3.Connection = cs404;

                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    cs404.Open();
                    cmd3.ExecuteNonQuery();
                    cs404.Close();
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                }
            }
        }
        private void DeleteDrink_Click(object sender, EventArgs e)
        {

            if (CustomNameBox.SelectedValue == null)

            {
                MessageBox.Show("Please Select a recipe to be deleted");
            }

            else
            {
                RemovecustomDrink();
            }
        }

        private void RemoveFavoriteDrink()
        {
            string statusbarrecipe = FavoritesNameBox.SelectedValue.ToString();
            statusbarrecipe = statusbarrecipe.Replace("'", "''");
            toolStripStatusLabel1.Text = statusbarrecipe;

            if (statusbarrecipe != null)
            {
                using (SQLiteConnection cs403 = new SQLiteConnection("Data Source = |DataDirectory|\\Custom.db"))
                {

                    //create command
                    SQLiteCommand cmd2 = new SQLiteCommand();
                    cmd2.CommandText = "DELETE FROM Favorites WHERE name='" + statusbarrecipe + "'";
                    cmd2.Connection = cs403;

                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    cs403.Open();
                    cmd2.ExecuteNonQuery();
                    cs403.Close();
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                }

            }
        }
        private void DeleteFavorite_Click(object sender, EventArgs e)
        {
            if (FavoritesNameBox.SelectedValue == null)

            {
                MessageBox.Show("Please Select a recipe to be deleted");
            }

            else
            {
                RemoveFavoriteDrink();
            }
        }

        private void DrinksNameBox_MouseMove(object sender, MouseEventArgs e)
        {
            ListBoxControl DrinksNameBox = sender as ListBoxControl;
            int index = DrinksNameBox.IndexFromPoint(new Point(e.X, e.Y));
            if (index != -1)
            {
                string item = DrinksNameBox.GetItemValue(index) as string;
                toolTipController1.ShowHint(item, DrinksNameBox.PointToScreen(new Point(e.X, e.Y)));
            }
            else
            {
                toolTipController1.HideHint();
            }
        }

        private void ShotsNameBox_MouseMove(object sender, MouseEventArgs e)
        {
            ListBoxControl ShotsNameBox = sender as ListBoxControl;
            int index = ShotsNameBox.IndexFromPoint(new Point(e.X, e.Y));
            if (index != -1)
            {
                string item = ShotsNameBox.GetItemValue(index) as string;
                toolTipController1.ShowHint(item, ShotsNameBox.PointToScreen(new Point(e.X, e.Y)));
            }
            else
            {
                toolTipController1.HideHint();
            }
        }

        private void LiqueursNameBox_MouseMove(object sender, MouseEventArgs e)
        {
            ListBoxControl LiqueursNameBox = sender as ListBoxControl;
            int index = LiqueursNameBox.IndexFromPoint(new Point(e.X, e.Y));
            if (index != -1)
            {
                string item = LiqueursNameBox.GetItemValue(index) as string;
                toolTipController1.ShowHint(item, LiqueursNameBox.PointToScreen(new Point(e.X, e.Y)));
            }
            else
            {
                toolTipController1.HideHint();
            }
        }

        private void PunchesNameBox_MouseMove(object sender, MouseEventArgs e)
        {
            ListBoxControl PunchesNameBox = sender as ListBoxControl;
            int index = PunchesNameBox.IndexFromPoint(new Point(e.X, e.Y));
            if (index != -1)
            {
                string item = PunchesNameBox.GetItemValue(index) as string;
                toolTipController1.ShowHint(item, PunchesNameBox.PointToScreen(new Point(e.X, e.Y)));
            }
            else
            {
                toolTipController1.HideHint();
            }
        }

        private void CocktailsNameBox_MouseMove(object sender, MouseEventArgs e)
        {
            ListBoxControl CocktailsNameBox = sender as ListBoxControl;
            int index = CocktailsNameBox.IndexFromPoint(new Point(e.X, e.Y));
            if (index != -1)
            {
                string item = CocktailsNameBox.GetItemValue(index) as string;
                toolTipController1.ShowHint(item, CocktailsNameBox.PointToScreen(new Point(e.X, e.Y)));
            }
            else
            {
                toolTipController1.HideHint();
            }
        }

        private void CustomNameBox_MouseMove(object sender, MouseEventArgs e)
        {
            ListBoxControl CustomNameBox = sender as ListBoxControl;
            int index = CustomNameBox.IndexFromPoint(new Point(e.X, e.Y));
            if (index != -1)
            {
                string item = CustomNameBox.GetItemValue(index) as string;
                toolTipController1.ShowHint(item, CustomNameBox.PointToScreen(new Point(e.X, e.Y)));
            }
            else
            {
                toolTipController1.HideHint();
            }
        }

        private void FavoritesNameBox_MouseMove(object sender, MouseEventArgs e)
        {
            ListBoxControl FavoritesNameBox = sender as ListBoxControl;
            int index = FavoritesNameBox.IndexFromPoint(new Point(e.X, e.Y));
            if (index != -1)
            {
                string item = FavoritesNameBox.GetItemValue(index) as string;
                toolTipController1.ShowHint(item, FavoritesNameBox.PointToScreen(new Point(e.X, e.Y)));
            }
            else
            {
                toolTipController1.HideHint();
            }
        }

        private void IngredientsNameBox_MouseMove(object sender, MouseEventArgs e)
        {
            ListBoxControl IngredientsNameBox = sender as ListBoxControl;
            int index = IngredientsNameBox.IndexFromPoint(new Point(e.X, e.Y));
            if (index != -1)
            {
                string item = IngredientsNameBox.GetItemValue(index) as string;
                toolTipController1.ShowHint(item, IngredientsNameBox.PointToScreen(new Point(e.X, e.Y)));
            }
            else
            {
                toolTipController1.HideHint();
            }
        }

        private void CoffeeTeaNameBox_MouseMove(object sender, MouseEventArgs e)
        {
            ListBoxControl CoffeeTeaNameBox = sender as ListBoxControl;
            int index = CoffeeTeaNameBox.IndexFromPoint(new Point(e.X, e.Y));
            if (index != -1)
            {
                string item = CoffeeTeaNameBox.GetItemValue(index) as string;
                toolTipController1.ShowHint(item, CoffeeTeaNameBox.PointToScreen(new Point(e.X, e.Y)));
            }
            else
            {
                toolTipController1.HideHint();
            }
        }

        private void NonAlcoholicNameBox_MouseMove(object sender, MouseEventArgs e)
        {
            ListBoxControl NonAlcoholicNameBox = sender as ListBoxControl;
            int index = NonAlcoholicNameBox.IndexFromPoint(new Point(e.X, e.Y));
            if (index != -1)
            {
                string item = NonAlcoholicNameBox.GetItemValue(index) as string;
                toolTipController1.ShowHint(item, NonAlcoholicNameBox.PointToScreen(new Point(e.X, e.Y)));
            }
            else
            {
                toolTipController1.HideHint();
            }
        }

        private void BeerAleNameBox_MouseMove(object sender, MouseEventArgs e)
        {
            ListBoxControl BeerAleNameBox = sender as ListBoxControl;
            int index = BeerAleNameBox.IndexFromPoint(new Point(e.X, e.Y));
            if (index != -1)
            {
                string item = BeerAleNameBox.GetItemValue(index) as string;
                toolTipController1.ShowHint(item, BeerAleNameBox.PointToScreen(new Point(e.X, e.Y)));
            }
            else
            {
                toolTipController1.HideHint();
            }
        }

        private void DrinksNameBox_MouseLeave(object sender, EventArgs e)
        {
            toolTipController1.HideHint();
        }

        void RemoveBuyNow()
        {
            String abc = @"Software\LollieSoft\Bartender Express";

            Microsoft.Win32.RegistryKey regkey = Microsoft.Win32.Registry.CurrentUser;
            regkey = regkey.CreateSubKey(abc); //path
            string Br = (string)regkey.GetValue("Password");
            if (string.IsNullOrEmpty(Br) == false)
            {
                Lolliesoft.Ribbon.Items.Remove(BuyNow);
                notifyIcon1.Dispose();
                notifyIcon2.ShowBalloonTip(6000);
                toolStripLabel1.Text = "";
            }
        }

        private void AboutBtn_ItemClick(object sender, ItemClickEventArgs e)
        {

            XtraMessageBox.Show("Bartender Express Version 4.0\nCopyright © 1996-2019 LollieSoft Inc.\nwww.lolliesoft.com", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Facebook_ItemClick(object sender, ItemClickEventArgs e)
        {
            Facebook child = new Facebook();
            child.MdiParent = this;
            client.BringToFront();//This will make your child form shown on top.   
            child.Show();
        }

        private void barFinder_ItemClick(object sender, ItemClickEventArgs e)
        {
            BarMap child = new BarMap();
            child.MdiParent = this;
            client.BringToFront();//This will make your child form shown on top.   
            child.Show();
            //Adds an icon to mdi child window
            string path = Directory.GetCurrentDirectory() + "\\Resources\\location.png";
            Image myImg = Image.FromFile(path);
            xtraTabbedMdiManager1.SelectedPage.Image = myImg;
        }

        private void tileItem11_ItemClick(object sender, TileItemEventArgs e)
        {
            Lolliesoft child = new Lolliesoft();
            child.MdiParent = this;
            client.BringToFront();//This will make your child form shown on top.   
            child.Show();
        }

        private void tileItem10_ItemClick(object sender, TileItemEventArgs e)
        {
            WizardPages.SelectedTab = Favorites;
            FavoritesNameBox.Show();
            FavoritesNameBox.Focus();
            toolStripStatusLabel1.Text = (this.FavoritesNameBox.ItemCount.ToString()) + " Favorites Recipes ";
        }

        private void navBarItem1_LinkClicked(object sender, ItemClickEventArgs e)
        {
            WizardPages.SelectedTab = Favorites;
            FavoritesNameBox.Show();
            FavoritesNameBox.Focus();
            toolStripStatusLabel1.Text = (this.FavoritesNameBox.ItemCount.ToString()) + " Favorites Recipes ";
        }

        private void tileItem9_ItemClick(object sender, TileItemEventArgs e)
        {
            Twitter child = new Twitter();
            child.MdiParent = this;
            client.BringToFront();//This will make your child form shown on top.   
            child.Show();
        }

        private void BuyNow_ItemClick(object sender, ItemClickEventArgs e)
        {
            BuyNow child = new BuyNow();
            child.MdiParent = this;
            client.BringToFront();//This will make your child form shown on top.   
            child.Show();
        }

        private void helpbtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + "\\BartenderExpressPro.chm");
        }

        private void NotifyNag()
        {
            String abc = @"Software\LollieSoft\Bartender Express";

            Microsoft.Win32.RegistryKey regkey = Microsoft.Win32.Registry.CurrentUser;
            regkey = regkey.CreateSubKey(abc); //path
            string Br = (string)regkey.GetValue("Password");
            if (string.IsNullOrEmpty(Br) == true)
            {
                notifyIcon2.Dispose();
            }
            notifyIcon1.ShowBalloonTip(6000);
            RemoveBuyNow();

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            BuyNow child = new BuyNow();
            child.MdiParent = this;
            client.BringToFront();//This will make your child form shown on top.   
            child.Show();
        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            BuyNow child = new BuyNow();
            child.MdiParent = this;
            client.BringToFront();//This will make your child form shown on top.   
            child.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void MinimizetoTray_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void notifyIcon2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
        }

        private void notifyIcon2_Click(object sender, EventArgs e)
        {
            Show();
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            Show();
            BuyNow child = new BuyNow();
            child.MdiParent = this;
            client.BringToFront();//This will make your child form shown on top.   
            child.Show();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timeStripLabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void xtraTabbedMdiManager1_SelectedPageChanged(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                toolStripStatusLabel1.Text = ActiveMdiChild.Text;
                if (ActiveMdiChild.Text == "Liqueur Cabinet")
                {

                    WizardPages.SelectedTab = IngredientsTab;
                    IngredientsNameBox.Show();

                }
                if (ActiveMdiChild.Text == "Custom Recipes")
                {
                    WizardPages.SelectedTab = CustomTab;
                    CustomNameBox.Show();
                }
            }
            else
            {
                toolStripStatusLabel1.Text = "";
            }
            //toolStripStatusLabel.Text = statusbarrecipe;
        }

        private void CustomNameBox_MouseDown(object sender, MouseEventArgs e)
        {
            CustomNameBox.SelectedIndex = CustomNameBox.IndexFromPoint(e.Location);

        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            RemovecustomDrink();
        }

        public string emailAmountsTxt { get; set; }
        public string emailIngredientsTxt { get; set; }
        public string emailDirections { get; set; }
        public string emailAmtIng { get; set; }

        private void emailStripButton_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                string selectedDrink = ActiveMdiChild.Text;


                string path = Directory.GetCurrentDirectory() + "\\Resources\\Drinks1.ico";
                Image myImg = Image.FromFile(path);

                var iconName = xtraTabbedMdiManager1.SelectedPage.Image;

                if (iconName != null)
                {
                    int iconNameFlag = iconName.Flags;
                    if (iconNameFlag == 77842)
                    {
                        GetDrink GetDrinks = new GetDrink();
                        GetDrinks.getDrinkRecipe(selectedDrink, tableIdent);
                        string emailIngredients = string.Join("<br>", GetDrinks.IngredientsList());
                        var emailIngredientshtml = "<html><head></head><body>" + emailIngredients + "</body></html>";
                        string emailIngredientsTxt = string.Join(Environment.NewLine, GetDrinks.IngredientsList());
                        string emailAmounts = string.Join("<br> ", GetDrinks.AmountList());
                        string emailAmountshtml = "<html><head></head><body>" + emailAmounts + "</body></html>";
                        string emailDirections = string.Join("<br><div>", GetDrinks.DirectionList());
                        string emailDirectionsTxt = string.Join("%0D", GetDrinks.DirectionList());

                        List<string> amtIng = new List<string>();

                        //populate amtIng list with amounts and corresponding ingredients
                        for (int i = 0; i < GetDrinks.AmountList().Count; i++)
                        {
                            amtIng.AddRange(new List<string> { GetDrinks.AmountList()[i].ToString() + "   -   " + GetDrinks.IngredientsList()[i].ToString() });
                        }

                        string emailAmountsTxt = string.Join("%0A", amtIng);

                        emailDrink child2 = new emailDrink(selectedDrink, tableIdent, emailAmountsTxt, emailIngredientsTxt, emailDirectionsTxt, emailAmtIng);

                        child2.webBrowser1.DocumentText = emailAmountshtml;
                        child2.webBrowser2.DocumentText = emailIngredientshtml;
                        child2.webBrowser3.DocumentText = emailDirections;

                        child2.MdiParent = this;
                        child2.Show();
                        //Adds an icon to mdi child window
                        string path1 = Directory.GetCurrentDirectory() + "\\Resources\\email.png";
                        Image myImg1 = Image.FromFile(path1);
                        xtraTabbedMdiManager1.SelectedPage.Image = myImg1;
                    }
                }
                if (iconName == null)
                {
                    MessageBox.Show("not a drink Table");
                }
            }
            else
            {
                MessageBox.Show("no recipe to email!");
            }
        }

        private void contextMenuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //get tablename
            //get Drinkname for each namelist(string statusbarrecipe2 = CocktailsNameBox.SelectedValue.ToString();
            string DrinkName = "A BOMB";
            string TableName = "drinks";
            GetDrink GD = new GetDrink();
            GD.getDrinkRecipe(DrinkName, TableName);
            string emailIngredients = string.Join("<br>", GD.IngredientsList());
            var emailIngredientshtml = "<html><head></head><body>" + emailIngredients + "</body></html>";
            string emailIngredientsTxt = string.Join(Environment.NewLine, GD.IngredientsList());
            string emailAmounts = string.Join("<br> ", GD.AmountList());
            string emailAmountshtml = "<html><head></head><body>" + emailAmounts + "</body></html>";
            string emailDirections = string.Join("<br><div>", GD.DirectionList());
            string emailDirectionsTxt = string.Join("%0D", GD.DirectionList());
          
        }
    }

}
