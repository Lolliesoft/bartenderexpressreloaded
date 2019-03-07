using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Controls;
using System.Windows.Forms;
using Image = System.Drawing.Image;

namespace bartenderexpressReloaded
{
    public partial class emailDrink : Form
    {
        

        //public string DrinkIngredient { get; set; }
        

        public emailDrink(string DrinkName, string tablename)
        {
            InitializeComponent();
            MessageBox.Show(DrinkName);
            


            textBox2.Text = DrinkName + "  DRINK RECIPE";

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


                    }

                    //Get Amounts
                    SQLiteCommand cmdamt = new SQLiteCommand("SELECT amount FROM recipeingredients INNER JOIN ingredients ON ingredients.id=recipeingredients.ingid WHERE recipeid=" + (reader["id"]) + "", cs);
                    SQLiteDataReader rdramt = cmdamt.ExecuteReader();

                    while (rdramt.Read())
                    {
                        //ListViewItem amount = new ListViewItem();
                        //amount.SubItems[0].Text = rdramt[0].ToString();
                        //child.listView1.Items.Add(amount);
                        this.webBrowser1.DocumentText = rdramt[0].ToString();
                    }

                    //Get Directions
                    SQLiteCommand cmddir = new SQLiteCommand("SELECT directions FROM recipes WHERE id = " + (reader["id"]) + "", cs);
                    SQLiteDataReader rdr = cmddir.ExecuteReader();
                    this.webBrowser1.Font = new Font("Consolas", 14);

                    while (rdr.Read())
                    {
                        
                        this.webBrowser3.DocumentText = rdr[0].ToString();
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
                        //this.webBrowser1. = Image.FromStream(ms, true);
                    }
                }

                cs.Close();
            }
        }
    }
}


            //public string RecipeHtml (WebBrowser Browser, //object of method to get drink)
            //{
            //    webBrowser1.Refresh();
            //    var str = "<html><head></head><body>" + DrinkRecipe + "</body></html>";
            //    webBrowser1.DocumentText = str;

            //    return DrinkRecipe;
            //}

            //method that gets the drink info
            //public void GetDrinkInfo(string DrinkRecipeName)
            //{
            //    get the listview items in Form2
            //    ListViewItem[] items = new ListViewItem[listView1.Items.Count];
            //    listView1.Items.CopyTo(items, 0);
            //}

        

