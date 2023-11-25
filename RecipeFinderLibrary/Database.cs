using System.Data.SqlClient;
using System.Collections.Generic;

namespace RecipeFinderLibrary
{
    //public partial class UserDatabase
    //{
    //    // Placeholder methods for database interactions
    //    public bool IsUsernameTaken(string username) { return false; }
    //    public void SaveUser(User user) { }
    //    public User QueryUserByUsername(string username) { return null; }
    //}

    //public partial class RecipeDatabase
    //{
        
    //    public void SaveRecipe(Recipe recipe) { }
    //    public void RemoveRecipe(Recipe recipe) { }
    //    public List<Recipe> QueryRecipesByDietaryRestrictions(List<string> restrictions) { return null; }
    //    public List<Recipe> QueryBudgetConsciousRecipes(double maxBudget) { return null; }
    //    public void SaveUserRecipe(User user, Recipe recipe) { }
    //    public void RemoveUserRecipe(User user, Recipe recipe) { }
    //    public List<Recipe> GetSavedRecipesForUser(User user) { return null; }
    //}





    public class Database
    {
        private SqlConnection conn;

        public Database()
        {

            conn = GetConnection();
        }

        public SqlConnection GetConnection()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "(local)\\SQLEXPRESS";
            builder.UserID = "capstone_user";
            builder.Password = "pass@word1";
            builder.InitialCatalog = "Recipe/UserDatabase";

            return new SqlConnection(builder.ConnectionString);
        }

        public User QueryByUsername(string username, string password)
        {
            var sqlQuery = "SELECT TOP 1 * FROM dbo.[user] WHERE Username = '" + @username + "' AND Password = '" + @password + "'";

            conn.Open();
            using (var cmd = new SqlCommand(sqlQuery, conn))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue ("@password", password);

                var user = new User();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        user.Username = username;
                        user.Password = password;
                        user.IsAdmin = (bool) reader[2];
                    }
                }
                
                conn.Close();
                
                return user;
            }
        }

        public void SaveUser(User user)
        {
            conn.Open();
            using (var cmd = new SqlCommand("INSERT INTO dbo.[user] (Username, Password) VALUES (@username, @password)", conn))
            {
                cmd.Parameters.AddWithValue("@username", user.Username);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void SaveRecipe(Recipe recipe)// Does this method save a recipe to the database or save to a user library? Ask Kevin.
        {
            conn.Open();
            using (var cmd = new SqlCommand("INSERT INTO dbo.recipes (Name, Ingredients, DietaryRestrictions, CookingTime, Instructions, Cost, Description) VALUES (@name, @ingredients, @dietaryrestrictions, @cookingTime, @instructions, @cost, @description)", conn))
            {
                cmd.Parameters.AddWithValue("@name", recipe.Name);
                cmd.Parameters.AddWithValue("@ingredients", recipe.Ingredients);
                cmd.Parameters.AddWithValue("@dietaryrestrictions", recipe.DietaryRestrictions);
                cmd.Parameters.AddWithValue("@cookingTime", recipe.CookingTime);
                cmd.Parameters.AddWithValue("@instructions", recipe.Instructions);
                cmd.Parameters.AddWithValue("@cost", recipe.Cost);
                cmd.Parameters.AddWithValue("@description", recipe.Description);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public List<Recipe> QueryByDietaryRestriction(string restriction)
        {
            List<Recipe> recipes = new List<Recipe>();
            conn.Open();
            using (var cmd = new SqlCommand($"SELECT * FROM Recipes WHERE DietaryRestriction = @restriction", conn))
            {
                cmd.Parameters.AddWithValue("@restriction", restriction);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        recipes.Add(new Recipe { /* initialize with data from reader */ });
                    }
                }
                conn.Close();
            }
            return recipes;
        }

        public List<Recipe> QueryByBudget(double budget)
        {
            List<Recipe> recipes = new List<Recipe>();
            conn.Open();
            using (var cmd = new SqlCommand($"SELECT * FROM Recipes WHERE Budget <= @budget", conn))
            {
                cmd.Parameters.AddWithValue("@budget", budget);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        recipes.Add(new Recipe { /* initialize with data from reader */ });
                    }
                }
                conn.Close();
            }
            return recipes;
        }
    }
    }