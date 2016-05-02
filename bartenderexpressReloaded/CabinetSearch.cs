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
            // ListCount();
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

                String sql1 = "SELECT name FROM masterdrinks WHERE Ingredient1 = (" + SelectedIngredients + ")";

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

                if (IngCount == 1)
                {
                    SQLiteCommand cmd1 = new SQLiteCommand(sql1, cs104);
                    SQLiteDataReader reader1 = cmd1.ExecuteReader();



                    while (reader1.Read())

                    {
                        string sName = reader1["name"].ToString();
                        //MessageBox.Show(sName);
                    }

                }

                if (IngCount == 2)
                {
                    SQLiteCommand cmd2 = new SQLiteCommand(sql2, cs104);
                    SQLiteDataReader reader2 = cmd2.ExecuteReader();



                    while (reader2.Read())

                    {
                        string sName = reader2["name"].ToString();
                        MessageBox.Show(sName);
                    }

                }

                if (IngCount == 3)
                {
                    SQLiteCommand cmd3 = new SQLiteCommand(sql3, cs104);
                    SQLiteDataReader reader3 = cmd3.ExecuteReader();



                    while (reader3.Read())

                    {
                        string sName = reader3["name"].ToString();
                        MessageBox.Show(sName);
                    }

                }

                if (IngCount == 4)
                {
                    SQLiteCommand cmd4 = new SQLiteCommand(sql4, cs104);
                    SQLiteDataReader reader4 = cmd4.ExecuteReader();



                    while (reader4.Read())

                    {
                        string sName = reader4["name"].ToString();
                        MessageBox.Show(sName);
                    }

                }

                if (IngCount == 5)
                {
                    SQLiteCommand cmd5 = new SQLiteCommand(sql5, cs104);
                    SQLiteDataReader reader5 = cmd5.ExecuteReader();



                    while (reader5.Read())

                    {
                        string sName = reader5["name"].ToString();
                        MessageBox.Show(sName);
                    }

                }

                if (IngCount == 6)
                {
                    SQLiteCommand cmd6 = new SQLiteCommand(sql6, cs104);
                    SQLiteDataReader reader6 = cmd6.ExecuteReader();



                    while (reader6.Read())

                    {
                        string sName = reader6["name"].ToString();
                        MessageBox.Show(sName);
                    }

                }

                if (IngCount == 7)
                {
                    SQLiteCommand cmd7 = new SQLiteCommand(sql7, cs104);
                    SQLiteDataReader reader7 = cmd7.ExecuteReader();



                    while (reader7.Read())

                    {
                        string sName = reader7["name"].ToString();
                        MessageBox.Show(sName);
                    }

                }

                if (IngCount == 8)
                {
                    SQLiteCommand cmd8 = new SQLiteCommand(sql8, cs104);
                    SQLiteDataReader reader8 = cmd8.ExecuteReader();



                    while (reader8.Read())

                    {
                        string sName = reader8["name"].ToString();
                        MessageBox.Show(sName);
                    }

                }

                if (IngCount == 9)
                {
                    SQLiteCommand cmd9 = new SQLiteCommand(sql9, cs104);
                    SQLiteDataReader reader9 = cmd9.ExecuteReader();



                    while (reader9.Read())

                    {
                        string sName = reader9["name"].ToString();
                        MessageBox.Show(sName);
                    }

                }

                if (IngCount == 10)
                {
                    SQLiteCommand cmd10 = new SQLiteCommand(sql10, cs104);
                    SQLiteDataReader reader10 = cmd10.ExecuteReader();



                    while (reader10.Read())

                    {
                        string sName = reader10["name"].ToString();
                        MessageBox.Show(sName);
                    }

                }

                if (IngCount == 11)
                {
                    SQLiteCommand cmd11 = new SQLiteCommand(sql11, cs104);
                    SQLiteDataReader reader11 = cmd11.ExecuteReader();



                    while (reader11.Read())

                    {
                        string sName = reader11["name"].ToString();
                        MessageBox.Show(sName);
                    }

                }

                if (IngCount == 12)
                {
                    SQLiteCommand cmd12 = new SQLiteCommand(sql12, cs104);
                    SQLiteDataReader reader12 = cmd12.ExecuteReader();



                    while (reader12.Read())

                    {
                        string sName = reader12["name"].ToString();
                        MessageBox.Show(sName);
                    }

                }

                if (IngCount == 13)
                {
                    SQLiteCommand cmd13 = new SQLiteCommand(sql13, cs104);
                    SQLiteDataReader reader13 = cmd13.ExecuteReader();



                    while (reader13.Read())

                    {
                        string sName = reader13["name"].ToString();
                        MessageBox.Show(sName);
                    }

                }

                if (IngCount == 14)
                {
                    SQLiteCommand cmd14 = new SQLiteCommand(sql14, cs104);
                    SQLiteDataReader reader14 = cmd14.ExecuteReader();



                    while (reader14.Read())

                    {
                        string sName = reader14["name"].ToString();
                        MessageBox.Show(sName);
                    }

                }

                if (IngCount == 15)
                {
                    SQLiteCommand cmd15 = new SQLiteCommand(sql15, cs104);
                    SQLiteDataReader reader15 = cmd15.ExecuteReader();



                    while (reader15.Read())

                    {
                        string sName = reader15["name"].ToString();
                        MessageBox.Show(sName);
                    }

                }

            }
        }

        //private void listBoxControl2_MouseDown(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Right)
        //    {
        //        if (e.Button == MouseButtons.Right)
        //        {
        //            var item = listBoxControl2.IndexFromPoint(e.Location);
        //            if (item >= 0)
        //            {
        //                listBoxControl2.SelectedIndex = item;
                        



        //            }
        //        }
        //    }
        //}

        private void listBoxControl2_contextMenuStrip_Click(object sender, EventArgs e)
        {

            string selecteditem2 = listBoxControl2.SelectedItem.ToString();
          
            listBoxControl2.Items.Remove(selecteditem2);
        }
    }
}
