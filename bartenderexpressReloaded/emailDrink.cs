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

            GetDrink GetDrinks = new GetDrink();
            GetDrinks.getDrinkRecipe(DrinkName, tablename);

            textBox2.Text = DrinkName + "  DRINK RECIPE";

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

        

