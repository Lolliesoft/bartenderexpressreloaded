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
                

                SQLiteCommand cmd = new SQLiteCommand();
                cmd.CommandText = @"INSERT into myRecipes (name, amt1) Values (@DrinkName,@Amt1) ";
                cmd.Connection = conn10;
                cmd.Parameters.Add(new SQLiteParameter("@DrinkName", txtDrinkName.Text));
                cmd.Parameters.Add(new SQLiteParameter("@Amt1", txtAmt1.Text));

                conn10.Open();
                cmd.ExecuteNonQuery();

                conn10.Close();
            }

        }
    }
}
