//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.Data.SQLite;

using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SQLite;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;


namespace bartenderexpressReloaded
{
    public partial class customRecipes : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        string connectionString;
        string connectionString2;

        public customRecipes()
        {
            InitializeComponent();
            connectionString = @"Data Source = |DataDirectory|\\Custom.db";
            connectionString2 = @"Data Source = |DataDirectory|\\XpressShots.db";

        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                using (SQLiteConnection conn10 = new SQLiteConnection(connectionString))
                {


                    SQLiteCommand cmd = new SQLiteCommand();
                    cmd.CommandText =
                        @"INSERT into myRecipes (name, amt1, amt2, amt3, amt4, amt5, amt6, amt7, amt8, amt9, amt10, amt11, amt12, amt13, amt14, amt15, directions,
                                                                ingredient1, ingredient2, ingredient3, ingredient4, ingredient5, ingredient6, ingredient7, ingredient8, ingredient9,
                                                                ingredient10, ingredient11, ingredient12, ingredient13, ingredient14, ingredient15) 
                    Values (@DrinkName,@Amt1,@Amt2,@Amt3,@Amt4,@Amt5,@Amt6,@Amt7,@Amt8,@Amt9,@Amt10,@Amt11,@Amt12,@Amt13,@Amt14,@Amt15,@Directions,
                                                                @Ing1,@Ing2,@Ing3,@Ing4,@Ing5,@Ing6,@Ing7,@Ing8,@Ing9,@Ing10,@Ing11,@Ing12,@Ing13,@Ing14,@Ing15)";
                    cmd.Connection = conn10;
                    cmd.Parameters.Add(new SQLiteParameter("@DrinkName", txtDrinkName.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Amt1", txtAmt1.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Amt2", txtAmt2.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Amt3", txtAmt3.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Amt4", txtAmt4.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Amt5", txtAmt5.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Amt6", txtAmt6.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Amt7", txtAmt7.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Amt8", txtAmt8.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Amt9", txtAmt9.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Amt10", txtAmt10.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Amt11", txtAmt11.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Amt12", txtAmt12.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Amt13", txtAmt13.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Amt14", txtAmt14.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Amt15", txtAmt15.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@directions", txtDirections.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Ing1", Ing1.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Ing2", Ing2.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Ing3", Ing3.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Ing4", Ing4.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Ing5", Ing5.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Ing6", Ing6.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Ing7", Ing7.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Ing8", Ing8.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Ing9", Ing9.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Ing10", Ing10.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Ing11", Ing11.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Ing12", Ing12.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Ing13", Ing13.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Ing14", Ing14.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Ing15", Ing15.Text));


                    conn10.Open();
                    cmd.ExecuteNonQuery();

                    conn10.Close();

                    MessageBox.Show("Custom Recipe Saved", "MyRecipe Added", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    //Refresh database

                }

                //copy to xpress

                using (SQLiteConnection conn1000 = new SQLiteConnection(connectionString2))
                {


                    SQLiteCommand cmd = new SQLiteCommand();
                    cmd.CommandText =
                        @"INSERT into myRecipes (name, amt1, amt2, amt3, amt4, amt5, amt6, amt7, amt8, amt9, amt10, amt11, amt12, amt13, amt14, amt15, directions,
                                                            ingredient1, ingredient2, ingredient3, ingredient4, ingredient5, ingredient6, ingredient7, ingredient8, ingredient9,
                                                            ingredient10, ingredient11, ingredient12, ingredient13, ingredient14, ingredient15) 
                Values (@DrinkName,@Amt1,@Amt2,@Amt3,@Amt4,@Amt5,@Amt6,@Amt7,@Amt8,@Amt9,@Amt10,@Amt11,@Amt12,@Amt13,@Amt14,@Amt15,@Directions,
                                                            @Ing1,@Ing2,@Ing3,@Ing4,@Ing5,@Ing6,@Ing7,@Ing8,@Ing9,@Ing10,@Ing11,@Ing12,@Ing13,@Ing14,@Ing15)";
                    cmd.Connection = conn1000;
                    cmd.Parameters.Add(new SQLiteParameter("@DrinkName", txtDrinkName.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Amt1", txtAmt1.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Amt2", txtAmt2.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Amt3", txtAmt3.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Amt4", txtAmt4.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Amt5", txtAmt5.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Amt6", txtAmt6.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Amt7", txtAmt7.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Amt8", txtAmt8.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Amt9", txtAmt9.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Amt10", txtAmt10.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Amt11", txtAmt11.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Amt12", txtAmt12.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Amt13", txtAmt13.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Amt14", txtAmt14.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Amt15", txtAmt15.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@directions", txtDirections.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Ing1", Ing1.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Ing2", Ing2.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Ing3", Ing3.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Ing4", Ing4.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Ing5", Ing5.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Ing6", Ing6.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Ing7", Ing7.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Ing8", Ing8.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Ing9", Ing9.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Ing10", Ing10.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Ing11", Ing11.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Ing12", Ing12.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Ing13", Ing13.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Ing14", Ing14.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Ing15", Ing15.Text));


                    conn1000.Open();
                    cmd.ExecuteNonQuery();

                    conn1000.Close();

                    //MessageBox.Show("Custom Recipe Saved", "MyRecipe Added", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //Refresh database
                    ClearControls(this);

                }
            }
            else
                {
                    MessageBox.Show("Drink Name must not be blank!");
                }
        }

        private void txtDrinkName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDrinkName.Text))
            {
                e.Cancel = true;
                txtDrinkName.Focus();
                errorProvider.SetError(txtDrinkName, "Please enter a Drink Name!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtDrinkName, "");
            }
        }
        private void ClearControls(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else if (c is RadioButton)
                    ((RadioButton)c).Checked = false;
                else if (c is ComboBox)
                    ((ComboBox)c).SelectedIndex = -1;

                if (c.HasChildren)
                    ClearControls(c);
            }
        }
    }
}
