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
        private List<string> drinkingredientlist = new List<string>();
        public List<string> IngredientsList()
        {
            return drinkingredientlist;
        }

        private List<string> drinkamountlist = new List<string>();
        public List<string> AmountList()
        {
            return drinkamountlist;
        }

        private List<string> drinkdirectionlist = new List<string>();
        public List<string> DirectionList()
        {
            return drinkdirectionlist;
        }
        public void getDrinkRecipe(string DrinkName, string tablename)
        {
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
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        // Get Ingredients
                        SQLiteCommand cmding = new SQLiteCommand("SELECT name FROM ingredients INNER JOIN recipeingredients ON ingredients.id=recipeingredients.ingid WHERE recipeid=" + (reader["id"]) + "", cs);
                        SQLiteDataReader rdring = cmding.ExecuteReader();
                        

                        while (rdring.Read())
                        {                          
                            drinkingredientlist.Add(rdring[0].ToString());
                        }

                        //Get Amounts
                        SQLiteCommand cmdamt = new SQLiteCommand("SELECT amount FROM recipeingredients INNER JOIN ingredients ON ingredients.id=recipeingredients.ingid WHERE recipeid=" + (reader["id"]) + "", cs);
                        SQLiteDataReader rdramt = cmdamt.ExecuteReader();

                        while (rdramt.Read())
                        {
                            drinkamountlist.Add(rdramt[0].ToString());
                        }

                        //Get Directions
                        SQLiteCommand cmddir = new SQLiteCommand("SELECT directions FROM recipes WHERE id = " + (reader["id"]) + "", cs);
                        SQLiteDataReader rdr = cmddir.ExecuteReader();

                        while (rdr.Read())
                        {
                            drinkdirectionlist.Add(rdr[0].ToString());
                        }

                        //Get glasstype
                        
                        SQLiteCommand cmdglass = new SQLiteCommand("SELECT pictures.picture FROM pictures INNER JOIN recipes ON pictures.id = recipes.id WHERE pictures.id IN (SELECT recipes.glasstype FROM recipes WHERE id = " + (reader["id"]) + ")", cs);
                        SQLiteDataReader rdrglass = cmdglass.ExecuteReader();
                     

                        while (rdrglass.Read())
                        {
                        
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
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        // Get Ingredients
                        SQLiteCommand cmding = new SQLiteCommand("SELECT ingredient1, ingredient2, ingredient3, ingredient4, ingredient5, ingredient6, ingredient7, ingredient8, ingredient9, ingredient10, ingredient11, ingredient12, ingredient13, ingredient14, ingredient15 FROM " + tablename + " WHERE " + tablekey + "=" + (reader[tablekey]) + "", cs);
                        SQLiteDataReader rdring = cmding.ExecuteReader();

                        while (rdring.Read())
                        {
                            //Add ingredients into the drinkingredientlist
                            drinkingredientlist.Add(rdring[0].ToString());
                            drinkingredientlist.Add(rdring[1].ToString());
                            drinkingredientlist.Add(rdring[2].ToString());
                            drinkingredientlist.Add(rdring[3].ToString());
                            drinkingredientlist.Add(rdring[4].ToString());
                            drinkingredientlist.Add(rdring[5].ToString()); 
                            drinkingredientlist.Add(rdring[6].ToString());
                            drinkingredientlist.Add(rdring[7].ToString()); 
                            drinkingredientlist.Add(rdring[8].ToString());
                            drinkingredientlist.Add(rdring[9].ToString());
                            drinkingredientlist.Add(rdring[10].ToString());
                            drinkingredientlist.Add(rdring[11].ToString());
                            drinkingredientlist.Add(rdring[12].ToString());
                            drinkingredientlist.Add(rdring[13].ToString()); 
                            drinkingredientlist.Add(rdring[14].ToString());
                        }

                        //Get Amounts
                        SQLiteCommand cmdamt = new SQLiteCommand("SELECT amt1, amt2, amt3, amt4, amt5, amt6, amt7, amt8, amt9, amt10, amt11, amt12, amt13, amt14, amt15 FROM " + tablename + " WHERE " + tablekey + "=" + (reader[tablekey]) + "", cs);
                        SQLiteDataReader rdramt = cmdamt.ExecuteReader();

                        while (rdramt.Read())
                        {
                            drinkamountlist.Add(rdramt[0].ToString());
                            drinkamountlist.Add(rdramt[1].ToString());
                            drinkamountlist.Add(rdramt[2].ToString());
                            drinkamountlist.Add(rdramt[3].ToString());
                            drinkamountlist.Add(rdramt[4].ToString());
                            drinkamountlist.Add(rdramt[5].ToString());
                            drinkamountlist.Add(rdramt[6].ToString());
                            drinkamountlist.Add(rdramt[7].ToString());
                            drinkamountlist.Add(rdramt[8].ToString());
                            drinkamountlist.Add(rdramt[9].ToString());
                            drinkamountlist.Add(rdramt[10].ToString());
                            drinkamountlist.Add(rdramt[11].ToString());
                            drinkamountlist.Add(rdramt[12].ToString());
                            drinkamountlist.Add(rdramt[13].ToString());
                            drinkamountlist.Add(rdramt[14].ToString());
                        }

                        //Get Directions
                        SQLiteCommand cmddir = new SQLiteCommand("SELECT directions FROM " + tablename + " WHERE " + tablekey + "  = " + (reader[tablekey]) + "", cs);
                        SQLiteDataReader rdr = cmddir.ExecuteReader();

                        while (rdr.Read())
                        {
                            drinkdirectionlist.Add(rdr[0].ToString());
                        }
                    }
                    cs.Close();
                }
            }
        }
    }
}