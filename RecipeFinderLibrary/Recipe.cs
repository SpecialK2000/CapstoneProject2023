using RecipeFinderGUI;

namespace RecipeFinderLibrary
{
    public class Recipe
    {
        //public Recipe() 
        //{
        //DietaryRestrictions = new List<string>();
        //Ingredients = new List<string>();
        //Instructions = new List<string>();
        //}

 
        public string Name { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; }
        public string DietaryRestrictions { get; set; }
        public string CookingTime { get; set; }
        public int Cost { get; set; }
        public string Instructions { get; set; }

        
        
        // Method to get the recipe details
        public string GetRecipeDetails()
        {
            // Placeholder implementation
            return "Placeholder recipe details";
        }

    }
   
    public static class RecipeModel
    {
        public static Recipe GetRecipe()
        {
            string query = "SELECT Name, Ingredients, DietaryRestrictions, CookingTime, Instructions, Cost FROM Recipe;"; // Assuming User class has 'username' and 'password' properties

            Recipe recipe = DataAccess.ExecuteQuery<Recipe>(query);

            return recipe;
        }
        public static List<Recipe> GetDietaryRestrictionList()
        {
            DataAccess da = new DataAccess();

            string query = "select distinct DietaryRestrictions from recipes group by DietaryRestrictions";

            List<Recipe> recipes = da.ExecuteQueryList<Recipe>(query);

            return recipes;
        }
        public static List<Recipe> GetDietaryRestrictions(string restriction)
        {// select * from recipes where dietaryrestrictions = 'gluten-free';
            DataAccess da = new DataAccess();

            string query = "SELECT * FROM recipes WHERE dietaryrestrictions = '" + restriction + "'";

            List<Recipe> recipes = da.ExecuteQueryList<Recipe>(query);

            return recipes;
        }
        public static List<Recipe> GetByBudget(int from, int to)
        {
            // select * from recipes where cost >= 6 and <= 44
            DataAccess da = new DataAccess();

            string query = "SELECT * FROM recipes WHERE cost between " + from + " and " + to;
            List<Recipe> recipes = da.ExecuteQueryList<Recipe>(query);

            return recipes;
        }

        public static List<Recipe> GetByBoth(string restriction, int from, int to)
        {
            DataAccess da = new DataAccess();

            string query = "SELECT * FROM recipes WHERE dietaryrestrictions = '" + restriction + "' AND cost between " + from + " and " + to;

            List<Recipe> recipes = da.ExecuteQueryList<Recipe>(query);

            return recipes;
        }
    }
}