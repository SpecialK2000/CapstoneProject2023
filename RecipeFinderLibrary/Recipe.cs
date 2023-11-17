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
        //public string MealType { get; set; }
        public string Ingredients { get; set; }
        public string DietaryRestrictions { get; set; }
        public int CookingTime { get; set; }
        public double Cost { get; set; }
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
    }
}