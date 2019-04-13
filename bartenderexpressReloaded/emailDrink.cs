using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Controls;
using System.Windows.Forms;
using Image = System.Drawing.Image;


namespace bartenderexpressReloaded
{
    public partial class emailDrink : Form
    {    
        [DllImport("Shell32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern IntPtr ShellExecute(IntPtr hwnd, string lpOperation, string lpFile, string lpParameters, string lpDirectory, int nShowCmd);
        //public string amountEmail { get; set; }

        public emailDrink(string DrinkName, string tablename, string emailAmountsTxt, string emailIngredientsTxt, string emailDirectionsTxt, string emailAmtIng)
        {
            InitializeComponent();

            textBox2.Text = DrinkName + "  DRINK RECIPE";
            amountBox.Text = emailAmountsTxt;
            ingredientsBox.Text = emailIngredientsTxt;
            directionsBox.Text = emailDirectionsTxt;
    }

        public void SendEmail_Click(object sender, EventArgs e)
        {
            //Opens a URL in the default browser
            //IntPtr result = ShellExecute(IntPtr.Zero, "open", "https://mail.google.com/mail/u/0/#inbox?compose=new", null, null, 1);

            string command = "mailto:" + textBox1.Text + "?subject=" + textBox2.Text + "&body=" + Regex.Replace(amountBox.Text, "&", "and") + "%0D%0A%0D%0A" + directionsBox.Text;
            Process.Start(command);
        }
    }
}