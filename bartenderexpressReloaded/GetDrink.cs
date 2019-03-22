using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devart.Data.SQLite;

namespace bartenderexpressReloaded
{
    class GetDrink
    {
        public void getDrinkRecipe(string DrinkName, string tablename)
        {
            MessageBox.Show(DrinkName);
            MessageBox.Show(tablename);
            //DrinkName = DrinkName.Trim();
            string tablekey;

            if (tablename == "liqueurs")
            {
                tablekey = tablename.Remove(tablename.Length - 1) + "_key";
            }
            else if (tablename == "Punches")
            {
                tablekey = tablename.Remove(tablename.Length - 2) + "_key";
            }
            else if (tablename == "Cocktails")
            {
                tablekey = tablename.Remove(tablename.Length - 1) + "_key";
            }
            else if (tablename == "Beers")
            {
                tablekey = tablename.Remove(tablename.Length - 1) + "_key";
            }
            else { tablekey = tablename + "_key"; }


            //for drinks table
            if (tablename == "drinks")
            {
                using (SQLiteConnection cs = new SQLiteConnection("Data Source = |DataDirectory|\\bartenderExpress.db"))
                {
                    cs.Open();

                    //Get ID
                    SQLiteCommand cmd = new SQLiteCommand("SELECT id FROM recipes WHERE name='" + (DrinkName.Trim().Replace("'", "''")) + "'", cs);
                    //SQLiteCommand cmd = new SQLiteCommand("SELECT id FROM recipes WHERE name ='" + statusbarrecipe + "'", cs);
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        // Get Ingredients
                        SQLiteCommand cmding = new SQLiteCommand("SELECT name FROM ingredients INNER JOIN recipeingredients ON ingredients.id=recipeingredients.ingid WHERE recipeid=" + (reader["id"]) + "", cs);
                        SQLiteDataReader rdring = cmding.ExecuteReader();

                        while (rdring.Read())
                        {
                            //ListViewItem ingredients = new ListViewItem();
                            //ingredients.SubItems[0].Text = rdring[0].ToString();
                            //child.listView2.Items.Add(ingredients);

                            //List<string> ingredientslist = child.listView2.Items.Cast<ListViewItem>()
                            //     .Select(x => x.Text).ToList();

                            //string path = @"c:\temp\MyTest.txt";
                            //System.IO.File.WriteAllLines(path, ingredientslist);



                            //string Profanity = "Fuck you";
                            //string DrinkIngredients = "<html><body>" + Profanity + "</body></html>";

                            //string DrinkIngredients = "<html><head></head><body>" + path + "</body></html>";
                            //string DrinkIng = listOfIngredients[0];

                            //child2.webBrowser1.Navigate("about:blank");

                            //child2.webBrowser1.DocumentText = DrinkIngredients;
                            //child2.webBrowser1.Refresh();
                            //child2.textBox1.Text = Profanity;
                            //child2.webBrowser1.Navigate(path);
                            MessageBox.Show(rdring[0].ToString());

                        }

                        //Get Amounts
                        SQLiteCommand cmdamt = new SQLiteCommand("SELECT amount FROM recipeingredients INNER JOIN ingredients ON ingredients.id=recipeingredients.ingid WHERE recipeid=" + (reader["id"]) + "", cs);
                        SQLiteDataReader rdramt = cmdamt.ExecuteReader();

                        while (rdramt.Read())
                        {
                            //ListViewItem amount = new ListViewItem();
                            //amount.SubItems[0].Text = rdramt[0].ToString();
                            //child.listView1.Items.Add(amount);
                            //this.webBrowser1.DocumentText = rdramt[0].ToString();
                            MessageBox.Show(rdramt[0].ToString());
                        }

                        //Get Directions
                        SQLiteCommand cmddir = new SQLiteCommand("SELECT directions FROM recipes WHERE id = " + (reader["id"]) + "", cs);
                        SQLiteDataReader rdr = cmddir.ExecuteReader();
                        //this.webBrowser1.Font = new Font("Consolas", 14);

                        while (rdr.Read())
                        {

                            //this.webBrowser3.DocumentText = rdr[0].ToString();
                            MessageBox.Show(rdr[0].ToString());
                        }

                        //Get glasstype
                        //SQLiteCommand cmdglass = new SQLiteCommand("SELECT glasstype FROM recipes WHERE id = " + (reader["id"]) + "", cs);

                        SQLiteCommand cmdglass = new SQLiteCommand("SELECT pictures.picture FROM pictures INNER JOIN recipes ON pictures.id = recipes.id WHERE pictures.id IN (SELECT recipes.glasstype FROM recipes WHERE id = " + (reader["id"]) + ")", cs);



                        SQLiteDataReader rdrglass = cmdglass.ExecuteReader();
                        //MessageBox.Show(rdrglass["pictures.picture"].ToString());

                        while (rdrglass.Read())
                        {
                            //For Image inside a BLOB

                            //byte[] imagepic = (byte[])rdrglass[0];
                            //MemoryStream ms = new MemoryStream(imagepic);
                            //Clipboard.SetImage(Image.FromStream(ms, true));
                            //child.richTextBox1.Paste();
                            //this.webBrowser1. = Image.FromStream(ms, true);
                        }
                    }

                    cs.Close();
                }
            
        }

            else if (tablename != "drinks")
            {
                using (SQLiteConnection cs = new SQLiteConnection("Data Source = |DataDirectory|\\XpressShots.db"))
                {
                    cs.Open();

                    //Get ID

                    SQLiteCommand cmd = new SQLiteCommand("SELECT " + tablekey + " FROM " + tablename + " WHERE name = '" + (DrinkName.Replace("'", "''")) + "'", cs);
                    //SQLiteCommand cmd = new SQLiteCommand("SELECT id FROM recipes WHERE name ='" + statusbarrecipe + "'", cs);
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    //MessageBox.Show(reader[0].ToString());

                    while (reader.Read())
                    {
                        // Get Ingredients
                        SQLiteCommand cmding = new SQLiteCommand("SELECT ingredient1, ingredient2, ingredient3, ingredient4, ingredient5, ingredient6, ingredient7, ingredient8, ingredient9, ingredient10, ingredient11, ingredient12, ingredient13, ingredient14, ingredient15 FROM " + tablename + " WHERE " + tablekey + "=" + (reader[tablekey]) + "", cs);
                        SQLiteDataReader rdring = cmding.ExecuteReader();

                        while (rdring.Read())
                        {
                            //ListViewItem ingredients = new ListViewItem();
                            //ingredients.SubItems[0].Text = rdring[0].ToString();
                            //child.listView2.Items.Add(ingredients);

                            //List<string> ingredientslist = child.listView2.Items.Cast<ListViewItem>()
                            //     .Select(x => x.Text).ToList();

                            //string path = @"c:\temp\MyTest.txt";
                            //System.IO.File.WriteAllLines(path, ingredientslist);



                            //string Profanity = "Fuck you";
                            //string DrinkIngredients = "<html><body>" + Profanity + "</body></html>";

                            //string DrinkIngredients = "<html><head></head><body>" + path + "</body></html>";
                            //string DrinkIng = listOfIngredients[0];

                            //child2.webBrowser1.Navigate("about:blank");

                            //child2.webBrowser1.DocumentText = DrinkIngredients;
                            //child2.webBrowser1.Refresh();
                            //child2.textBox1.Text = Profanity;
                            //child2.webBrowser1.Navigate(path);
                            MessageBox.Show(rdring[0].ToString());


                        }

                        //Get Amounts
                        SQLiteCommand cmdamt = new SQLiteCommand("SELECT amt1, amt2, amt3, amt4, amt5, amt6, amt7, amt8, amt9, amt10, amt11, amt12, amt13, amt14, amt15 FROM " + tablename + " WHERE " + tablekey + "=" + (reader[tablekey]) + "", cs);
                        SQLiteDataReader rdramt = cmdamt.ExecuteReader();

                        while (rdramt.Read())
                        {
                            //ListViewItem amount = new ListViewItem();
                            //amount.SubItems[0].Text = rdramt[0].ToString();
                            //child.listView1.Items.Add(amount);
                            //this.webBrowser1.DocumentText = rdramt[0].ToString();
                            MessageBox.Show(rdramt[0].ToString());
                        }

                        //Get Directions
                        SQLiteCommand cmddir = new SQLiteCommand("SELECT directions FROM " + tablename + " WHERE " + tablekey + "  = " + (reader[tablekey]) + "", cs);
                        SQLiteDataReader rdr = cmddir.ExecuteReader();
                        //this.webBrowser1.Font = new Font("Consolas", 14);

                        while (rdr.Read())
                        {
                            MessageBox.Show(rdr[0].ToString());
                            //this.webBrowser3.DocumentText = rdr[0].ToString();
                        }

                        //Get glasstype
                        //SQLiteCommand cmdglass = new SQLiteCommand("SELECT glasstype FROM recipes WHERE id = " + (reader["id"]) + "", cs);

                        //SQLiteCommand cmdglass = new SQLiteCommand("SELECT pictures.picture FROM pictures INNER JOIN recipes ON pictures.id = recipes.id WHERE pictures.id IN (SELECT recipes.glasstype FROM recipes WHERE id = " + (reader["id"]) + ")", cs);



                        //SQLiteDataReader rdrglass = cmdglass.ExecuteReader();
                        //MessageBox.Show(rdrglass["pictures.picture"].ToString());

                        //while (rdrglass.Read())
                        //{
                        //For Image inside a BLOB

                        //byte[] imagepic = (byte[])rdrglass[0];
                        //MemoryStream ms = new MemoryStream(imagepic);
                        //Clipboard.SetImage(Image.FromStream(ms, true));
                        //child.richTextBox1.Paste();
                        //this.webBrowser1. = Image.FromStream(ms, true);
                        //}
                    }

                    cs.Close();
                }
            }
        }
    }
}