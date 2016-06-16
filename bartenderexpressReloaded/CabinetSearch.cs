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
        //List<string> _items = new List<string>();

        public CabinetSearch()
        {
            InitializeComponent();
            fill_box();
            listBoxControl1.SelectedIndex = -1;
            CueProvider CreateaCue = new CueProvider();
            CreateaCue.SetCue(CabinetSearchBox, "Search For Your Ingredients...");

        }

        private ListBoxControl IngredientsNameBox;

        private void CabinetSearch_Load(object sender, System.EventArgs e)
        {
            new Form1().Show();

            // note we access the ListBox from
            // the Class Form1, not the instance of Form1
            IngredientsNameBox = Form1.f1ListBox;
        }
        void fill_box()
        {
            SQLiteConnection cs103 = new SQLiteConnection("Data Source = |DataDirectory|\\XpressShots.db");
            {
                cs103.Open();
                
                //Get Names
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

        public void DrinksfromIngredients()
        {
            string SelectedIngredients = "";

            foreach (string item in listBoxControl2.Items)
            {
                SelectedIngredients += "'" + item.ToString() + "'" + ",";
            }

            SelectedIngredients = SelectedIngredients.Remove(SelectedIngredients.Length - 1);


            SQLiteConnection cs104 = new SQLiteConnection("Data Source = |DataDirectory|\\XpressShots.db");
            {
                cs104.Open();

                //Get Drink Name from masterdrinks table

                SQLiteCommand sql1 = cs104.CreateCommand();
                sql1.CommandText = "SELECT name FROM masterdrinks WHERE Ingredient1 = @SelectedIngredients";
                sql1.Parameters.Add(new SQLiteParameter("@SelectedIngredients", SelectedIngredients));

                SQLiteCommand sql2 = cs104.CreateCommand();
                sql2.CommandText = "SELECT name FROM masterdrinks WHERE Ingredient1 IN (@SelectedIngredients) AND Ingredient2 IN (@SelectedIngredients)";
                sql2.Parameters.Add(new SQLiteParameter("@SelectedIngredients", SelectedIngredients));

                SQLiteCommand sql3 = cs104.CreateCommand();
                sql3.CommandText = "SELECT name FROM masterdrinks WHERE Ingredient1 IN (@SelectedIngredients) AND Ingredient2 IN (@SelectedIngredients) AND Ingredient3 IN (@SelectedIngredients)";
                sql3.Parameters.Add(new SQLiteParameter("@SelectedIngredients", SelectedIngredients));

                SQLiteCommand sql4 = cs104.CreateCommand();
                sql4.CommandText = "SELECT name FROM masterdrinks WHERE Ingredient1 IN (@SelectedIngredients) AND Ingredient2 IN (@SelectedIngredients) AND Ingredient3 IN(@SelectedIngredients) AND Ingredient4 IN (@SelectedIngredients)";              
                sql4.Parameters.Add(new SQLiteParameter("@SelectedIngredients", SelectedIngredients));


                SQLiteCommand sql5 = cs104.CreateCommand();
                sql5.CommandText = "SELECT name FROM masterdrinks WHERE Ingredient1 IN (@SelectedIngredients) AND Ingredient2 IN (@SelectedIngredients) AND Ingredient3 IN(@SelectedIngredients) AND Ingredient4 IN (@SelectedIngredients) AND Ingredient5 IN (@SelectedIngredients)";
                sql5.Parameters.Add(new SQLiteParameter("@SelectedIngredients", SelectedIngredients));

                SQLiteCommand sql6 = cs104.CreateCommand();
                sql6.CommandText = "SELECT name FROM masterdrinks WHERE Ingredient1 IN (@SelectedIngredients) AND Ingredient2 IN (@SelectedIngredients) AND Ingredient3 IN(@SelectedIngredients) AND Ingredient4 IN (@SelectedIngredients) AND Ingredient5 IN (@SelectedIngredients) AND Ingredient6 IN (@SelectedIngredients)";
                sql6.Parameters.Add(new SQLiteParameter("@SelectedIngredients", SelectedIngredients));

                SQLiteCommand sql7 = cs104.CreateCommand();
                sql7.CommandText = "SELECT name FROM masterdrinks WHERE Ingredient1 IN (@SelectedIngredients) AND Ingredient2 IN (@SelectedIngredients) AND Ingredient3 IN(@SelectedIngredients) AND Ingredient4 IN (@SelectedIngredients) AND Ingredient5 IN (@SelectedIngredients) AND Ingredient6 IN (@SelectedIngredients) AND Ingredient7 IN (@SelectedIngredients)";
                sql7.Parameters.Add(new SQLiteParameter("@SelectedIngredients", SelectedIngredients));

                SQLiteCommand sql8 = cs104.CreateCommand();
                sql8.CommandText = "SELECT name FROM masterdrinks WHERE Ingredient1 IN (@SelectedIngredients) AND Ingredient2 IN (@SelectedIngredients) AND Ingredient3 IN(@SelectedIngredients) AND Ingredient4 IN (@SelectedIngredients) AND Ingredient5 IN (@SelectedIngredients) AND Ingredient6 IN (@SelectedIngredients) AND Ingredient7 IN (@SelectedIngredients) AND Ingredient8 IN (@SelectedIngredients)";
                sql8.Parameters.Add(new SQLiteParameter("@SelectedIngredients", SelectedIngredients));

                SQLiteCommand sql9 = cs104.CreateCommand();
                sql9.CommandText = "SELECT name FROM masterdrinks WHERE Ingredient1 IN (@SelectedIngredients) AND Ingredient2 IN (@SelectedIngredients) AND Ingredient3 IN(@SelectedIngredients) AND Ingredient4 IN (@SelectedIngredients) AND Ingredient5 IN (@SelectedIngredients) AND Ingredient6 IN (@SelectedIngredients) AND Ingredient7 IN (@SelectedIngredients) AND Ingredient8 IN (@SelectedIngredients) AND Ingredient9 IN (@SelectedIngredients)";
                sql9.Parameters.Add(new SQLiteParameter("@SelectedIngredients", SelectedIngredients));

                SQLiteCommand sql10 = cs104.CreateCommand();
                sql10.CommandText = "SELECT name FROM masterdrinks WHERE Ingredient1 IN (@SelectedIngredients) AND Ingredient2 IN (@SelectedIngredients) AND Ingredient3 IN(@SelectedIngredients) AND Ingredient4 IN (@SelectedIngredients) AND Ingredient5 IN (@SelectedIngredients) AND Ingredient6 IN (@SelectedIngredients) AND Ingredient7 IN (@SelectedIngredients) AND Ingredient8 IN (@SelectedIngredients) AND Ingredient9 IN (@SelectedIngredients) AND Ingredient10 IN (@SelectedIngredients)";
                sql10.Parameters.Add(new SQLiteParameter("@SelectedIngredients", SelectedIngredients));


                SQLiteCommand sql11 = cs104.CreateCommand();
                sql11.CommandText = "SELECT name FROM masterdrinks WHERE Ingredient1 IN (@SelectedIngredients) AND Ingredient2 IN (@SelectedIngredients) AND Ingredient3 IN(@SelectedIngredients) AND Ingredient4 IN (@SelectedIngredients) AND Ingredient5 IN (@SelectedIngredients) AND Ingredient6 IN (@SelectedIngredients) AND Ingredient7 IN (@SelectedIngredients) AND Ingredient8 IN (@SelectedIngredients) AND Ingredient9 IN (@SelectedIngredients) AND Ingredient10 IN (@SelectedIngredients) AND Ingredient11 IN (@SelectedIngredients)";
                sql11.Parameters.Add(new SQLiteParameter("@SelectedIngredients", SelectedIngredients));


                SQLiteCommand sql12 = cs104.CreateCommand();
                sql12.CommandText = "SELECT name FROM masterdrinks WHERE Ingredient1 IN (@SelectedIngredients) AND Ingredient2 IN (@SelectedIngredients) AND Ingredient3 IN(@SelectedIngredients) AND Ingredient4 IN (@SelectedIngredients) AND Ingredient5 IN (@SelectedIngredients) AND Ingredient6 IN (@SelectedIngredients) AND Ingredient7 IN (@SelectedIngredients) AND Ingredient8 IN (@SelectedIngredients) AND Ingredient9 IN (@SelectedIngredients) AND Ingredient10 IN (@SelectedIngredients) AND Ingredient11 IN (@SelectedIngredients) AND Ingredient12 IN (@SelectedIngredients)";
                sql12.Parameters.Add(new SQLiteParameter("@SelectedIngredients", SelectedIngredients));

                SQLiteCommand sql13 = cs104.CreateCommand();
                sql13.CommandText = "SELECT name FROM masterdrinks WHERE Ingredient1 IN (@SelectedIngredients) AND Ingredient2 IN (@SelectedIngredients) AND Ingredient3 IN(@SelectedIngredients) AND Ingredient4 IN (@SelectedIngredients) AND Ingredient5 IN (@SelectedIngredients) AND Ingredient6 IN (@SelectedIngredients) AND Ingredient7 IN (@SelectedIngredients) AND Ingredient8 IN (@SelectedIngredients) AND Ingredient9 IN (@SelectedIngredients) AND Ingredient10 IN (@SelectedIngredients) AND Ingredient11 IN (@SelectedIngredients) AND Ingredient12 IN (@SelectedIngredients) AND Ingredient13 IN (@SelectedIngredients)";
                sql13.Parameters.Add(new SQLiteParameter("@SelectedIngredients", SelectedIngredients));


                SQLiteCommand sql14 = cs104.CreateCommand();
                sql14.CommandText = "SELECT name FROM masterdrinks WHERE Ingredient1 IN (@SelectedIngredients) AND Ingredient2 IN (@SelectedIngredients) AND Ingredient3 IN(@SelectedIngredients) AND Ingredient4 IN (@SelectedIngredients) AND Ingredient5 IN (@SelectedIngredients) AND Ingredient6 IN (@SelectedIngredients) AND Ingredient7 IN (@SelectedIngredients) AND Ingredient8 IN (@SelectedIngredients) AND Ingredient9 IN (@SelectedIngredients) AND Ingredient10 IN (@SelectedIngredients) AND Ingredient11 IN (@SelectedIngredients) AND Ingredient12 IN (@SelectedIngredients) AND Ingredient13 IN (@SelectedIngredients) AND Ingredient14 IN (@SelectedIngredients)";
                sql14.Parameters.Add(new SQLiteParameter("@SelectedIngredients", SelectedIngredients));


                SQLiteCommand sql15 = cs104.CreateCommand();
                sql15.CommandText = "SELECT name FROM masterdrinks WHERE Ingredient1 IN (@SelectedIngredients) AND Ingredient2 IN (@SelectedIngredients) AND Ingredient3 IN(@SelectedIngredients) AND Ingredient4 IN (@SelectedIngredients) AND Ingredient5 IN (@SelectedIngredients) AND Ingredient6 IN (@SelectedIngredients) AND Ingredient7 IN (@SelectedIngredients) AND Ingredient8 IN (@SelectedIngredients) AND Ingredient9 IN (@SelectedIngredients) AND Ingredient10 IN (@SelectedIngredients) AND Ingredient11 IN (@SelectedIngredients) AND Ingredient12 IN (@SelectedIngredients) AND Ingredient13 IN (@SelectedIngredients) AND Ingredient14 IN (@SelectedIngredients) AND Ingredient15 IN (@SelectedIngredients)";
                sql15.Parameters.Add(new SQLiteParameter("@SelectedIngredients", SelectedIngredients));

                //Determine the number of items dragged into listBoxControl2
                int IngCount;
                IngCount = listBoxControl2.Items.Count;

                if (IngCount == 1)
                {
                    Form1.f1ListBox.Items.Clear();
                    
                    SQLiteDataReader reader1 = sql1.ExecuteReader();

                    while (reader1.Read())

                    {
                        string sName = reader1["name"].ToString();
                        Form1.f1ListBox.Items.Add(sName);
                    }

                }

                if (IngCount == 2)
                {
                    Form1.f1ListBox.Items.Clear();

                    SQLiteDataReader reader2 = sql2.ExecuteReader();

                    while (reader2.Read())

                    {
                        string sName = reader2["name"].ToString();
                        Form1.f1ListBox.Items.Add(sName);
                    }
                }

                if (IngCount == 3)
                {
                    Form1.f1ListBox.Items.Clear();
                    
                    SQLiteDataReader reader3 = sql3.ExecuteReader();

                    while (reader3.Read())

                    {
                        string sName = reader3["name"].ToString();
                        Form1.f1ListBox.Items.Add(sName);
                    }

                }

                if (IngCount == 4)
                {
                    Form1.f1ListBox.Items.Clear();

                    SQLiteDataReader reader4 = sql4.ExecuteReader();


                    while (reader4.Read())

                    {
                        string sName = reader4["name"].ToString();
                        Form1.f1ListBox.Items.Add(sName);
                    }

                }

                if (IngCount == 5)
                {
                    Form1.f1ListBox.Items.Clear();
                    
                    SQLiteDataReader reader5 = sql5.ExecuteReader();


                    while (reader5.Read())

                    {
                        string sName = reader5["name"].ToString();
                        Form1.f1ListBox.Items.Add(sName);
                    }

                }

                if (IngCount == 6)
                {
                    Form1.f1ListBox.Items.Clear();

                    SQLiteDataReader reader6 = sql6.ExecuteReader();



                    while (reader6.Read())

                    {
                        string sName = reader6["name"].ToString();
                        Form1.f1ListBox.Items.Add(sName);
                    }

                }

                if (IngCount == 7)
                {
                    Form1.f1ListBox.Items.Clear();

                    SQLiteDataReader reader7 = sql7.ExecuteReader();


                    while (reader7.Read())

                    {
                        string sName = reader7["name"].ToString();
                        Form1.f1ListBox.Items.Add(sName);
                    }

                }

                if (IngCount == 8)
                {
                    Form1.f1ListBox.Items.Clear();

                    SQLiteDataReader reader8 = sql8.ExecuteReader();


                    while (reader8.Read())

                    {
                        string sName = reader8["name"].ToString();
                        Form1.f1ListBox.Items.Add(sName);
                    }

                }

                if (IngCount == 9)
                {
                    Form1.f1ListBox.Items.Clear();

                    SQLiteDataReader reader9 = sql9.ExecuteReader();

                    while (reader9.Read())

                    {
                        string sName = reader9["name"].ToString();
                        Form1.f1ListBox.Items.Add(sName);
                    }

                }

                if (IngCount == 10)
                {
                    Form1.f1ListBox.Items.Clear();

                    SQLiteDataReader reader10 = sql10.ExecuteReader();

                    while (reader10.Read())

                    {
                        string sName = reader10["name"].ToString();
                        Form1.f1ListBox.Items.Add(sName);
                    }

                }

                if (IngCount == 11)
                {
                    Form1.f1ListBox.Items.Clear();

                    SQLiteDataReader reader11 = sql11.ExecuteReader();

                    while (reader11.Read())

                    {
                        string sName = reader11["name"].ToString();
                        Form1.f1ListBox.Items.Add(sName);
                    }

                }

                if (IngCount == 12)
                {
                    Form1.f1ListBox.Items.Clear();

                    SQLiteDataReader reader12 = sql12.ExecuteReader();

                    while (reader12.Read())

                    {
                        string sName = reader12["name"].ToString();
                        Form1.f1ListBox.Items.Add(sName);
                    }

                }

                if (IngCount == 13)
                {
                    Form1.f1ListBox.Items.Clear();

                    SQLiteDataReader reader13 = sql13.ExecuteReader();

                    while (reader13.Read())

                    {
                        string sName = reader13["name"].ToString();
                        Form1.f1ListBox.Items.Add(sName);
                    }

                }

                if (IngCount == 14)
                {
                    Form1.f1ListBox.Items.Clear();

                    SQLiteDataReader reader14 = sql14.ExecuteReader();

                    while (reader14.Read())

                    {
                        string sName = reader14["name"].ToString();
                        Form1.f1ListBox.Items.Add(sName);
                    }

                }

                if (IngCount == 15)
                {
                    Form1.f1ListBox.Items.Clear();

                    SQLiteDataReader reader15 = sql15.ExecuteReader();


                    while (reader15.Read())

                    {
                        string sName = reader15["name"].ToString();
                        Form1.f1ListBox.Items.Add(sName);
                    }

                }

                if (IngCount > 15)
                {
                    MessageBox.Show("Please limit to 15 or less ingredients!",
                                    "Maximum ingredients have been entered",
                                    MessageBoxButtons.OKCancel,
                                    MessageBoxIcon.Warning,
                                    MessageBoxDefaultButton.Button1,
                                    MessageBoxOptions.RightAlign,
                                    true);

                }

            }
        }

        private void DeleteItemButton_Click(object sender, EventArgs e)
        {
            int count = listBoxControl2.Items.Count;
            string selecteditem2 = listBoxControl2.SelectedItem.ToString();

            if (listBoxControl2.SelectedIndex == 0 && count == 1)
            {
                listBoxControl2.Items.Clear();
                Form1.f1ListBox.Items.Clear();
            }

            else 
            {
                listBoxControl2.Items.Remove(selecteditem2);
                DrinksfromIngredients();
            }
       

        }

        private void listBoxControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxControl2.SelectedIndex == -1)
            {
                DeleteItemButton.Enabled = false;
                ClearItemButton.Enabled = false;
                DeleteItemButton.Visible = false;
                ClearItemButton.Visible = false;
            }
            else
            {
                DeleteItemButton.Enabled = true;
                ClearItemButton.Enabled = true;
                DeleteItemButton.Visible = true;
                ClearItemButton.Visible = true;
            }
        }

        private void ClearItemButton_Click(object sender, EventArgs e)
        {
            if (listBoxControl2.SelectedIndex != -1)
            {
                listBoxControl2.Items.Clear();
                Form1.f1ListBox.Items.Clear();
            }
        }

        //private void CabinetSearchBox_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == (char)Keys.Enter)
        //    {
        //        this.listBoxControl1_DoubleClick(e.KeyChar, e);
        //        CabinetSearchBox.Focus();
        //    }
        //}

        private void CabinetSearchBox_TextChanged(object sender, EventArgs e)
        {
            CabinetSearchBox.Font = new Font("Default", 8, FontStyle.Regular);
            int index = listBoxControl1.FindString(CabinetSearchBox.Text);
            if (0 <= index)
            {
                listBoxControl1.SelectedIndex = index;
            }
        }
      }
    }

