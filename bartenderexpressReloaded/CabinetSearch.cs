using DevExpress.XtraEditors;
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
    public partial class CabinetSearch : Form
    {
        public CabinetSearch()
        {
            InitializeComponent();
            fill_box();
            listBoxControl1.SelectedIndex = -1;
        }

        void fill_box()
        {
            SQLiteConnection cs103 = new SQLiteConnection("Data Source = |DataDirectory|\\XpressShots.db");
            {
                cs103.Open();

                //Get ID
                SQLiteCommand cmd = new SQLiteCommand("SELECT IngredientName FROM allIngredients", cs103);
                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string sName = reader["IngredientName"].ToString();
                    //listBox1.Items.Add(sName);
                    listBoxControl1.Items.Add(sName);
                }
            }
        }


        Point p = Point.Empty;



        private void listBoxControl1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {

            ListBoxControl c = sender as ListBoxControl;

            p = new Point(e.X, e.Y);

            int selectedIndex = c.IndexFromPoint(p);

            if (selectedIndex == -1)

                p = Point.Empty;

        }


        private void listBoxControl1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)

                if ((p != Point.Empty) && ((Math.Abs(e.X - p.X) > SystemInformation.DragSize.Width) || (Math.Abs(e.Y - p.Y) > SystemInformation.DragSize.Height)))

                    listBoxControl1.DoDragDrop(sender, DragDropEffects.Move);

        }

        private void listBoxControl2_DragOver(object sender, System.Windows.Forms.DragEventArgs e)
        {

            e.Effect = DragDropEffects.Move;

        }

        private void listBoxControl2_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {

            ListBoxControl listBox = sender as ListBoxControl;

            Point newPoint = new Point(e.X, e.Y);

            newPoint = listBox.PointToClient(newPoint);

            int selectedIndex = listBox.IndexFromPoint(newPoint);

            object item = listBoxControl1.Items[listBoxControl1.IndexFromPoint(p)];

            if (selectedIndex == -1)
            {
                listBox.Items.Add(item);
            }
            else
            {
                listBox.Items.Insert(selectedIndex, item);
            }
            ListCount();
            DrinksfromIngredients();
        }

        private void ListCount()

        {
            String ItemCount;
            ItemCount = listBoxControl2.Items.Count.ToString();
            MessageBox.Show(ItemCount);
        }

        private void GetIngredientResults()
        {
            string SelectedIngredients = "";

            foreach (string item in listBoxControl2.Items)
            {
                SelectedIngredients += "'" + item.ToString() + "'" + ",";
            }

           // MessageBox.Show(SelectedIngredients);
        }

        private void DrinksfromIngredients()
        {
            string SelectedIngredients = "";

            foreach (string item in listBoxControl2.Items)
            {
                SelectedIngredients += "'" + item.ToString() + "'" + ",";
                //SelectedIngredients +=  item.ToString()  + ",";
            }

            SelectedIngredients = SelectedIngredients.Remove(SelectedIngredients.Length - 1);


        SQLiteConnection cs104 = new SQLiteConnection("Data Source = |DataDirectory|\\XpressShots.db");
            {
                cs104.Open();

                //Get Drink Name from masterdrinks table

                String sql1 = "SELECT name FROM masterdrinks WHERE Ingredient1 IN (" + SelectedIngredients + ")";

                String sql2 = "SELECT name FROM masterdrinks WHERE Ingredient1 IN (" +
                                SelectedIngredients + ") AND Ingredient2 IN (" +
                                SelectedIngredients + ")";
                String sql3 = "SELECT name FROM masterdrinks WHERE Ingredient1 IN (" +
                                SelectedIngredients + ") AND Ingredient2 IN (" +
                                SelectedIngredients + ") AND Ingredient3 IN (" +
                                SelectedIngredients + ")";
                String sql4 = "SELECT name FROM masterdrinks WHERE Ingredient1 IN (" +
                                SelectedIngredients + ") AND Ingredient2 IN (" +
                                SelectedIngredients + ") AND Ingredient3 IN (" +
                                SelectedIngredients + ") AND Ingredient4 IN (" +
                                SelectedIngredients + ")";
                String sql5 = "SELECT name FROM masterdrinks WHERE Ingredient1 IN (" +
                                SelectedIngredients + ") AND Ingredient2 IN (" +
                                SelectedIngredients + ") AND Ingredient3 IN (" +
                                SelectedIngredients + ") AND Ingredient4 IN (" +
                                SelectedIngredients + ") AND Ingredient5 IN (" +
                                SelectedIngredients + ")";
                String sql6 = "SELECT name FROM masterdrinks WHERE Ingredient1 IN (" +
                                SelectedIngredients + ") AND Ingredient2 IN (" +
                                SelectedIngredients + ") AND Ingredient3 IN (" +
                                SelectedIngredients + ") AND Ingredient4 IN (" +
                                SelectedIngredients + ") AND Ingredient5 IN (" +
                                SelectedIngredients + ") AND Ingredient6 IN (" +
                                SelectedIngredients + ")";
                String sql7 = "SELECT name FROM masterdrinks WHERE Ingredient1 IN (" +
                                SelectedIngredients + ") AND Ingredient2 IN (" +
                                SelectedIngredients + ") AND Ingredient3 IN (" +
                                SelectedIngredients + ") AND Ingredient4 IN (" +
                                SelectedIngredients + ") AND Ingredient5 IN (" +
                                SelectedIngredients + ") AND Ingredient6 IN (" +
                                SelectedIngredients + ") AND Ingredient7 IN (" +
                                SelectedIngredients + ")";
                String sql8 = "SELECT name FROM masterdrinks WHERE Ingredient1 IN (" +
                                SelectedIngredients + ") AND Ingredient2 IN (" +
                                SelectedIngredients + ") AND Ingredient3 IN (" +
                                SelectedIngredients + ") AND Ingredient4 IN (" +
                                SelectedIngredients + ") AND Ingredient5 IN (" +
                                SelectedIngredients + ") AND Ingredient6 IN (" +
                                SelectedIngredients + ") AND Ingredient7 IN (" +
                                SelectedIngredients + ") AND Ingredient8 IN (" +
                                SelectedIngredients + ")";
                String sql9 = "SELECT name FROM masterdrinks WHERE Ingredient1 IN (" +
                                SelectedIngredients + ") AND Ingredient2 IN (" +
                                SelectedIngredients + ") AND Ingredient3 IN (" +
                                SelectedIngredients + ") AND Ingredient4 IN (" +
                                SelectedIngredients + ") AND Ingredient5 IN (" +
                                SelectedIngredients + ") AND Ingredient6 IN (" +
                                SelectedIngredients + ") AND Ingredient7 IN (" +
                                SelectedIngredients + ") AND Ingredient8 IN (" +
                                SelectedIngredients + ") AND Ingredient9 IN (" +
                                SelectedIngredients + ")";
                String sql10 = "SELECT name FROM masterdrinks WHERE Ingredient1 IN (" +
                                SelectedIngredients + ") AND Ingredient2 IN (" +
                                SelectedIngredients + ") AND Ingredient3 IN (" +
                                SelectedIngredients + ") AND Ingredient4 IN (" +
                                SelectedIngredients + ") AND Ingredient5 IN (" +
                                SelectedIngredients + ") AND Ingredient6 IN (" +
                                SelectedIngredients + ") AND Ingredient7 IN (" +
                                SelectedIngredients + ") AND Ingredient8 IN (" +
                                SelectedIngredients + ") AND Ingredient9 IN (" +
                                SelectedIngredients + ") AND Ingredient10 IN (" +
                                SelectedIngredients + ")";
                String sql11 = "SELECT name FROM masterdrinks WHERE Ingredient1 IN (" +
                                SelectedIngredients + ") AND Ingredient2 IN (" +
                                SelectedIngredients + ") AND Ingredient3 IN (" +
                                SelectedIngredients + ") AND Ingredient4 IN (" +
                                SelectedIngredients + ") AND Ingredient5 IN (" +
                                SelectedIngredients + ") AND Ingredient6 IN (" +
                                SelectedIngredients + ") AND Ingredient7 IN (" +
                                SelectedIngredients + ") AND Ingredient8 IN (" +
                                SelectedIngredients + ") AND Ingredient9 IN (" +
                                SelectedIngredients + ") AND Ingredient10 IN (" +
                                SelectedIngredients + ") AND Ingredient11 IN (" +
                                SelectedIngredients + ")";
                String sql12 = "SELECT name FROM masterdrinks WHERE Ingredient1 IN (" +
                                SelectedIngredients + ") AND Ingredient2 IN (" +
                                SelectedIngredients + ") AND Ingredient3 IN (" +
                                SelectedIngredients + ") AND Ingredient4 IN (" +
                                SelectedIngredients + ") AND Ingredient5 IN (" +
                                SelectedIngredients + ") AND Ingredient6 IN (" +
                                SelectedIngredients + ") AND Ingredient7 IN (" +
                                SelectedIngredients + ") AND Ingredient8 IN (" +
                                SelectedIngredients + ") AND Ingredient9 IN (" +
                                SelectedIngredients + ") AND Ingredient10 IN (" +
                                SelectedIngredients + ") AND Ingredient11 IN (" +
                                SelectedIngredients + ") AND Ingredient12 IN (" +
                                SelectedIngredients + ")";
                String sql13 = "SELECT name FROM masterdrinks WHERE Ingredient1 IN (" +
                                SelectedIngredients + ") AND Ingredient2 IN (" +
                                SelectedIngredients + ") AND Ingredient3 IN (" +
                                SelectedIngredients + ") AND Ingredient4 IN (" +
                                SelectedIngredients + ") AND Ingredient5 IN (" +
                                SelectedIngredients + ") AND Ingredient6 IN (" +
                                SelectedIngredients + ") AND Ingredient7 IN (" +
                                SelectedIngredients + ") AND Ingredient8 IN (" +
                                SelectedIngredients + ") AND Ingredient9 IN (" +
                                SelectedIngredients + ") AND Ingredient10 IN (" +
                                SelectedIngredients + ") AND Ingredient11 IN (" +
                                SelectedIngredients + ") AND Ingredient12 IN (" +
                                SelectedIngredients + ") AND Ingredient13 IN (" +
                                SelectedIngredients + ")";
                String sql14 = "SELECT name FROM masterdrinks WHERE Ingredient1 IN (" +
                                SelectedIngredients + ") AND Ingredient2 IN (" +
                                SelectedIngredients + ") AND Ingredient3 IN (" +
                                SelectedIngredients + ") AND Ingredient4 IN (" +
                                SelectedIngredients + ") AND Ingredient5 IN (" +
                                SelectedIngredients + ") AND Ingredient6 IN (" +
                                SelectedIngredients + ") AND Ingredient7 IN (" +
                                SelectedIngredients + ") AND Ingredient8 IN (" +
                                SelectedIngredients + ") AND Ingredient9 IN (" +
                                SelectedIngredients + ") AND Ingredient10 IN (" +
                                SelectedIngredients + ") AND Ingredient11 IN (" +
                                SelectedIngredients + ") AND Ingredient12 IN (" +
                                SelectedIngredients + ") AND Ingredient13 IN (" +
                                SelectedIngredients + ") AND Ingredient14 IN (" +
                                SelectedIngredients + ")";
                String sql15 = "SELECT name FROM masterdrinks WHERE Ingredient1 IN (" +
                                SelectedIngredients + ") AND Ingredient2 IN (" + 
                                SelectedIngredients + ") AND Ingredient3 IN (" +
                                SelectedIngredients + ") AND Ingredient4 IN (" +
                                SelectedIngredients + ") AND Ingredient5 IN (" +
                                SelectedIngredients + ") AND Ingredient6 IN (" +
                                SelectedIngredients + ") AND Ingredient7 IN (" +
                                SelectedIngredients + ") AND Ingredient8 IN (" +
                                SelectedIngredients + ") AND Ingredient9 IN (" +
                                SelectedIngredients + ") AND Ingredient10 IN (" +
                                SelectedIngredients + ") AND Ingredient11 IN (" +
                                SelectedIngredients + ") AND Ingredient12 IN (" +
                                SelectedIngredients + ") AND Ingredient13 IN (" +
                                SelectedIngredients + ") AND Ingredient14 IN (" +
                                SelectedIngredients + ") AND Ingredient15 IN (" +
                                SelectedIngredients + ")";
                //Determine the number of items dragged into listBoxControl2
                int IngCount;
                IngCount = listBoxControl2.Items.Count;

                SQLiteCommand cmd1 = new SQLiteCommand(sql1, cs104);

                SQLiteDataReader reader1 = cmd1.ExecuteReader();

                

                while (reader1.Read())
                {
                    if (IngCount == 1)
                     { 

                        string sName = reader["name"].ToString();
                        MessageBox.Show(sName);
                     }

                    

                }
                }


                 }

            }
        }
    }
