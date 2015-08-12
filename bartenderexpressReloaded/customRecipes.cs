using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace bartenderexpressReloaded
{
    public partial class customRecipes : Form
    {
        string connectionString;

        public customRecipes()
        {
            InitializeComponent();
            connectionString = @"Data Source = |DataDirectory|\\XpressShots.db";    
        }

        private void Save_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn10 = new SQLiteConnection(connectionString))
            {
                conn10.Open();
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.CommandText = @"INSERT into myRecipes (DrinkName, Amt1) Values (@DrinkName,@Amt1) ";
                cmd.Connection = conn10;
                //cmd.Parameters.Add(new SQLiteParameter());

            }

        }
    }
}
