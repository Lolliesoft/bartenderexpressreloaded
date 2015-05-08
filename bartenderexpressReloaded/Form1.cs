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
            
           
            DrinksNameBox.Hide();
            ShotsNameBox.Hide();
            LiqueursNameBox.Hide();
            PunchesNameBox.Hide();
            CocktailsNameBox.Hide();
            BeerAleNameBox.Hide();
            NonAlcoholicNameBox.Hide();
            CoffeeTeaNameBox.Hide();
           
        }



        private void Form1_Load(object sender, EventArgs e)
        {
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
    }
}
