using RecipeFinderLibrary;

namespace RecipeFinderLibraryTest
{
    public class RecipeDatabaseTests
    {
        [Fact]
        public void SaveRecipe_SavesRecipeToDatabase()
        {
            // Arrange
            RecipeDatabase recipeDatabase = new RecipeDatabase();
            Recipe recipeToSave = new Recipe { Name = "Test Recipe", Description = "Test Description" };

            // Act
            recipeDatabase.SaveRecipe(recipeToSave);

            // Assert
            // Add assertions to verify that the recipe was successfully saved to the database.
        }
    }
}