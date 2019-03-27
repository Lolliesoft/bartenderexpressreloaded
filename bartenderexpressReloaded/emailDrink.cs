using System;
using System.Collections.Generic;
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

       public emailDrink(string DrinkName, string tablename)
        {
            InitializeComponent();

            textBox2.Text = DrinkName + "  DRINK RECIPE";
        }
    }
}