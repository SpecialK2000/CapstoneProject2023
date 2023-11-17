using RecipeFinderLibrary;

namespace RecipeFinderLibraryTest
{
    public class RecipeSearchTests
    {
        [Fact]
        public void CanSearchByDietaryRestrictions()
        {
            // Arrange
            RecipeSearch recipeSearch = new RecipeSearch();
            List<string> restrictions = new List<string> { "Vegetarian", "Gluten-Free" };

            // Act
            List<Recipe> result = recipeSearch.SearchByDietaryRestrictions(restrictions);

            // Assert
            Assert.NotNull(result);
            // Future: Add assertions to verify that the returned list of recipes contains recipes that match the given dietary restrictions.
        }

        [Fact]
        public void CanSearchByBudget()
        {
            // Arrange
            RecipeSearch recipeSearch = new RecipeSearch();
            double maxBudget = 10.0; // Example budget

            // Act
            List<Recipe> result = recipeSearch.SearchByBudget(maxBudget);

            // Assert
            Assert.NotNull(result);
            // Future: Add assertions to verify that the returned list of recipes contains recipes that fit within the given budget.
        }
    }
}