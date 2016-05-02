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
                //SelectedIngredients += "'" + item.ToString() + "'" + ",";
                SelectedIngredients +=  item.ToString()  + ",";
            }

            SelectedIngredients = SelectedIngredients.Remove(SelectedIngredients.Length - 1);


        SQLiteConnection cs104 = new SQLiteConnection("Data Source = |DataDirectory|\\XpressShots.db");
            {
                cs104.Open();

                //Get Drink Name frommasterdrinks table
                //SQLiteCommand cmd = new SQLiteCommand("SELECT Name FROM masterdrinks WHERE Ingredient1 IN '" + (SelectedIngredients.Trim().Replace(",", "")) + "'", cs104);


                //"SELECT cocktail_key FROM cocktails WHERE name ='" + (statusbarrecipe2.Trim().Replace("'", "''")) + "'", cs5);
                String sql = "SELECT name FROM masterdrinks WHERE Ingredient1 IN ('" + SelectedIngredients + "')";

                SQLiteCommand cmd = new SQLiteCommand(sql, cs104);




                //+ "'+ AND Ingredient2 IN ('" + (SelectedIngredients) + ") AND Ingredient3 IN ('" + (SelectedIngredients) + "')", cs104);

                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                               string sName = reader["name"].ToString();
                               MessageBox.Show(sName);
                }


                 }

            }
        }
    }
