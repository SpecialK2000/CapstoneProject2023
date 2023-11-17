using RecipeFinderLibrary;

namespace RecipeFinderLibraryTest
{
    public class RecipeTests
    {
        [Fact]
        public void CanMakeRecipe()
        {
            var testRecipe = new Recipe();
            Assert.NotNull(testRecipe);
            Assert.False(string.IsNullOrWhiteSpace(testRecipe.Name));
            //Assert.NotEqual(MealType.None, testRecipe.MealType);

        }

        [Fact]
        public void CanCreateRecipeWithDietaryRestrictions() 
        {
            var testRecipe = new Recipe();
            Assert.NotEmpty(testRecipe.DietaryRestrictions);
        }

        [Fact]
        public void CanCreateRecipeWithIngredients()
        {
            var testRecipe = new Recipe();
            Assert.NotEmpty(testRecipe.Ingredients);
        }

        [Fact]
        public void CanCreateRecipeWithInstructions()
        {
            var testRecipe = new Recipe();
            Assert.NotEmpty(testRecipe.Instructions);
        }
    }
}