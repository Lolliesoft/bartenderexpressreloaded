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
            CueProvider.SetCue(DrinkSearch, "Search Drinks");
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




        private void DrinksNameBox_DoubleClick(object sender, EventArgs e)
        {
            if (DrinksNameBox.SelectedItem != null)
            {
                string statusbarrecipe = DrinksNameBox.SelectedValue.ToString();


                using (SQLiteConnection conn = new SQLiteConnection("Data Source = |DataDirectory|\\bartenderExpress.db"))
                {
                    conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand("SELECT directions FROM recipes WHERE name='" + (statusbarrecipe.Trim().Replace("'", "''")) + "'", conn);
                    SQLiteDataReader reader = cmd.ExecuteReader();
                   
                    while (reader.Read())
                    { //MessageBox.Show(reader["directions"].ToString());
                    Form2 child = new Form2();
                    child.Text = DrinksNameBox.SelectedValue.ToString();
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

        private void DrinksBoxItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            WizardPages.SelectedTab = DrinksTab;
                
            DrinksNameBox.Show();
          
        }

        private void ShotsBarItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ShotsNameBox.Show();
            WizardPages.SelectedTab = ShotsTab;
          
        }

        private void LiqueursBarItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            WizardPages.SelectedTab = LiqueursTab; 
            LiqueursNameBox.Show();
         
        }

        private void PunchesBarItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            WizardPages.SelectedTab = PunchesTab; 
            PunchesNameBox.Show();
          
        }

        private void CocktailsBarItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            WizardPages.SelectedTab = CocktailsTab; 
            CocktailsNameBox.Show();
          
        }

        private void BeerAleBarItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            WizardPages.SelectedTab = BeerAlesTab; 
            BeerAleNameBox.Show();
         
        }

        private void NonAlcoholicBarItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            WizardPages.SelectedTab = nonAlcoholicTab; 
            NonAlcoholicNameBox.Show();
           
        }

        private void CoffeeTeaBarItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            WizardPages.SelectedTab = CoffeeTeaTab; 
            CoffeeTeaNameBox.Show();
   
        }

        private void CustomItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            WizardPages.SelectedTab = CustomTab;
            CustomNameBox.Show();
        }

        private void DrinkSearch_TextChanged(object sender, EventArgs e)
        {
            int index = DrinksNameBox.FindString(DrinkSearch.Text);
            if (0 <= index)
            {
                DrinksNameBox.SelectedIndex = index;
                
            }
        }

        private void ShotSearch_TextChanged(object sender, EventArgs e)
        {
            int index = ShotsNameBox.FindString(ShotSearch.Text);
            if (0 <= index)
            {
                ShotsNameBox.SelectedIndex = index;
            }

        }

        private void LiqueurSearch_TextChanged(object sender, EventArgs e)
        {
            int index = LiqueursNameBox.FindString(LiqueurSearch.Text);
            if (0 <= index)
            {
                LiqueursNameBox.SelectedIndex = index;
            }

        }

        private void PunchSearch_TextChanged(object sender, EventArgs e)
        {
            int index = PunchesNameBox.FindString(PunchSearch.Text);
            if (0 <= index)
            {
                PunchesNameBox.SelectedIndex = index;
            }
        }

        private void CocktailSearch_TextChanged(object sender, EventArgs e)
        {
            int index = CocktailsNameBox.FindString(CocktailSearch.Text);
            if (0 <= index)
            {
                CocktailsNameBox.SelectedIndex = index;
            }

        }

        private void BeerSearch_TextChanged(object sender, EventArgs e)
        {
            int index = BeerAleNameBox.FindString(BeerSearch.Text);
            if (0 <= index)
            {
                BeerAleNameBox.SelectedIndex = index;
            }

        }

        private void NonAlcoholicSearch_TextChanged(object sender, EventArgs e)
        {
            int index = NonAlcoholicNameBox.FindString(NonAlcoholicSearch.Text);
            if (0 <= index)
            {
                NonAlcoholicNameBox.SelectedIndex = index;
            }
        }

        private void CoffeeTeaSearch_TextChanged(object sender, EventArgs e)
        {
            int index = CoffeeTeaNameBox.FindString(CoffeeTeaSearch.Text);
            if (0 <= index)
            {
                CoffeeTeaNameBox.SelectedIndex = index;
            }
        }

        private void CustomSearch_TextChanged(object sender, EventArgs e)
        {
            int index = CustomNameBox.FindString(CustomSearch.Text);
            if (0 <= index)
            {
                CustomNameBox.SelectedIndex = index;
            }
        }

        private void CheckKeys(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.DrinksNameBox_DoubleClick(e.KeyChar, e);
            }
        }

        private void DrinksNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.DrinksNameBox_DoubleClick(e.KeyChar, e);
            }

        }
    }
}
