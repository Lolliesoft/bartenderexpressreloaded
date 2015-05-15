using System;
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


//using DevExpress.XtraBars.Docking;

namespace bartenderexpressReloaded
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Path.Combine(Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData), "Lolliesoft"));
            InitializeComponent();
            
           
            //DrinksNameBox.Show();
            //ShotsNameBox.Hide();
            //LiqueursNameBox.Hide();
            //PunchesNameBox.Hide();
            //CocktailsNameBox.Hide();
            //BeerAleNameBox.Hide();
            //NonAlcoholicNameBox.Hide();
            //CoffeeTeaNameBox.Hide();
           
        }



        private void Form1_Load(object sender, EventArgs e)
        {
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
            CueProvider.SetCue(DrinkSearch,"Search Drinks");
            CueProvider.SetCue(ShotSearch, "Search Shots");
            CueProvider.SetCue(LiqueurSearch, "Search Liqueurs");
            CueProvider.SetCue(PunchSearch, "Search Punches");
            CueProvider.SetCue(BeerSearch, "Search Beer and Ales");
            CueProvider.SetCue(CoffeeTeaSearch, "Search Coffee and Teas");
            CueProvider.SetCue(NonAlcoholicSearch, "Search Non-Alcoholic Drinks");
            CueProvider.SetCue(CocktailSearch, "Search Cocktails");
            CueProvider.SetCue(CustomSearch, "Search Your Recipes");
                   
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

        //private void DrinksNameBox_DoubleClick(object sender, EventArgs e)
        //{
        //    if (DrinksNameBox.SelectedItem != null)
        //    {
        //        string statusbarrecipe = DrinksNameBox.SelectedValue.ToString();


        //        using (SQLiteConnection conn = new SQLiteConnection("Data Source = |DataDirectory|\\bartenderExpress.db"))
        //        {
        //            conn.Open();
        //            SQLiteCommand cmd = new SQLiteCommand("SELECT directions FROM recipes WHERE name='" + (statusbarrecipe.Trim().Replace("'", "''")) + "'", conn);
        //            SQLiteDataReader reader = cmd.ExecuteReader();

        //            while (reader.Read())
        //            { //MessageBox.Show(reader["directions"].ToString());
        //                Form2 child = new Form2();
        //                child.Text = DrinksNameBox.SelectedValue.ToString();
        //                //child.toolStripStatusLabel1.Text = statusbarrecipe;
        //                child.MdiParent = this;
        //                child.Show();

        //                break;
        //            }

        //            //MessageBox.Show(reader["id"].ToString());


        //            //toolStripStatusLabel1.Text = "Drink " + reader["drink_num"].ToString() + " of " + (this.listBoxControl1.Items.Count.ToString());
        //        }
        //    }
        //}

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
                string statusbarrecipe = ShotsNameBox.SelectedValue.ToString();


                using (SQLiteConnection conn = new SQLiteConnection("Data Source = |DataDirectory|\\XpressShots.db"))
                {
                    conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand("SELECT directions FROM shots WHERE name='" + (statusbarrecipe.Trim().Replace("'", "''")) + "'", conn);
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    { //MessageBox.Show(reader["directions"].ToString());
                        Form2 child = new Form2();
                        child.Text = ShotsNameBox.SelectedValue.ToString();
                        //child.toolStripStatusLabel1.Text = statusbarrecipe;
                        child.MdiParent = this;
                        child.Show();

                        break;
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
                string statusbarrecipe = LiqueursNameBox.SelectedValue.ToString();


                using (SQLiteConnection conn = new SQLiteConnection("Data Source = |DataDirectory|\\XpressShots.db"))
                {
                    conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand("SELECT directions FROM liqueurs WHERE name ='" + statusbarrecipe + "'", conn);
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    { //MessageBox.Show(reader["directions"].ToString());
                        Form2 child = new Form2();
                        child.Text = LiqueursNameBox.SelectedValue.ToString();
                        //child.toolStripStatusLabel1.Text = statusbarrecipe;
                        child.MdiParent = this;
                        child.Show();

                        break;
                    }
                }
            }
         }

        private void PunchesNameBox_DoubleClick(object sender, EventArgs e)
        {
            if (PunchesNameBox.SelectedItem != null)
            {
                string statusbarrecipe = PunchesNameBox.SelectedValue.ToString();


                using (SQLiteConnection conn = new SQLiteConnection("Data Source = |DataDirectory|\\XpressShots.db"))
                {
                    conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand("SELECT directions FROM punches WHERE name ='" + statusbarrecipe + "'", conn);
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    { //MessageBox.Show(reader["directions"].ToString());
                        Form2 child = new Form2();
                        child.Text = PunchesNameBox.SelectedValue.ToString();
                        //child.toolStripStatusLabel1.Text = statusbarrecipe;
                        child.MdiParent = this;
                        child.Show();

                        break;
                    }
                }
            }
        }

        private void CocktailsNameBox_DoubleClick(object sender, EventArgs e)
        {
            if (CocktailsNameBox.SelectedItem != null)
            {
                string statusbarrecipe = CocktailsNameBox.SelectedValue.ToString();


                using (SQLiteConnection conn = new SQLiteConnection("Data Source = |DataDirectory|\\XpressShots.db"))
                {
                    conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand("SELECT directions FROM cocktails WHERE name ='" + statusbarrecipe + "'", conn);
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    { //MessageBox.Show(reader["directions"].ToString());
                        Form2 child = new Form2();
                        child.Text = CocktailsNameBox.SelectedValue.ToString();
                        //child.toolStripStatusLabel1.Text = statusbarrecipe;
                        child.MdiParent = this;
                        child.Show();

                        break;
                    }
                }
            }
        }

        private void BeerAleNameBox_DoubleClick(object sender, EventArgs e)
        {
            if (BeerAleNameBox.SelectedItem != null)
            {
                string statusbarrecipe = BeerAleNameBox.SelectedValue.ToString();


                using (SQLiteConnection conn = new SQLiteConnection("Data Source = |DataDirectory|\\XpressShots.db"))
                {
                    conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand("SELECT directions FROM beers WHERE name ='" + statusbarrecipe + "'", conn);
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    { //MessageBox.Show(reader["directions"].ToString());
                        Form2 child = new Form2();
                        child.Text = BeerAleNameBox.SelectedValue.ToString();
                        //child.toolStripStatusLabel1.Text = statusbarrecipe;
                        child.MdiParent = this;
                        child.Show();

                        break;
                    }
                }
            }
        }

        private void NonAlcoholicNameBox_DoubleClick(object sender, EventArgs e)
        {
            if (NonAlcoholicNameBox.SelectedItem != null)
            {
                string statusbarrecipe = NonAlcoholicNameBox.SelectedValue.ToString();


                using (SQLiteConnection conn = new SQLiteConnection("Data Source = |DataDirectory|\\XpressShots.db"))
                {
                    conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand("SELECT directions FROM nonalcoholic WHERE name ='" + statusbarrecipe + "'", conn);
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    { //MessageBox.Show(reader["directions"].ToString());
                        Form2 child = new Form2();
                        child.Text = NonAlcoholicNameBox.SelectedValue.ToString();
                        //child.toolStripStatusLabel1.Text = statusbarrecipe;
                        child.MdiParent = this;
                        child.Show();

                        break;
                    }
                }
            }
        }


        private void CoffeeTeaNameBox_DoubleClick(object sender, EventArgs e)
        {
            if (CoffeeTeaNameBox.SelectedItem != null)
            {
                string statusbarrecipe = CoffeeTeaNameBox.SelectedValue.ToString();


                using (SQLiteConnection conn = new SQLiteConnection("Data Source = |DataDirectory|\\XpressShots.db"))
                {
                    conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand("SELECT directions FROM coffeetea WHERE name ='" + statusbarrecipe + "'", conn);
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    { //MessageBox.Show(reader["directions"].ToString());
                        Form2 child = new Form2();
                        child.Text = CoffeeTeaNameBox.SelectedValue.ToString();
                        //child.toolStripStatusLabel1.Text = statusbarrecipe;
                        child.MdiParent = this;
                        child.Show();

                        break;
                    }
                }
            }
        }

        private void CustomNameBox_DoubleClick(object sender, EventArgs e)
        {
            if (CustomNameBox.SelectedItem != null)
            {
                string statusbarrecipe = CustomNameBox.SelectedValue.ToString();


                using (SQLiteConnection conn = new SQLiteConnection("Data Source = |DataDirectory|\\XpressShots.db"))
                {
                    conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand("SELECT directions FROM MyRecipes WHERE name ='" + statusbarrecipe + "'", conn);
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    { //MessageBox.Show(reader["directions"].ToString());
                        Form2 child = new Form2();
                        child.Text = CustomNameBox.SelectedValue.ToString();
                        //child.toolStripStatusLabel1.Text = statusbarrecipe;
                        child.MdiParent = this;
                        child.Show();

                        break;
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
            CoffeeTeaSearch.Font = new Font("Default", 8, FontStyle.Regular);
            int index = CustomNameBox.FindString(CustomSearch.Text);
            if (0 <= index)
            {
                CustomNameBox.SelectedIndex = index;
            }
        }

        //private void CheckKeys(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == (char)13)
        //    {
        //        this.DrinksNameBox_DoubleClick(e.KeyChar, e);
        //        this.ShotsNameBox_DoubleClick(e.KeyChar, e);
        //    }
        //}

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


      }
  }

