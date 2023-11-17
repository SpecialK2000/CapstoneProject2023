using RecipeFinderLibrary;

namespace RecipeFinderLibraryTest
{
    public class UserDataHandlerTests
    {
        [Fact]
        public void CanAddSavedRecipeToUserProfile()
        {
            // Arrange
            UserDataHandler userDataHandler = new UserDataHandler();
            User user = new User();
            string recipe = "Recipe 1";

            // Act add
            User updatedUser = userDataHandler.AddSavedRecipeToUser(recipe, user);

            // Assert check addition
            Assert.Contains(recipe, updatedUser.SavedRecipes);
        }

        [Fact]
        public void CanRemoveSavedRecipeFromUser()
        {
            // Arrange
            UserDataHandler userDataHandler = new UserDataHandler();
            string recipe = "Recipe 1";
            User user = new User();
            user.SavedRecipes.Add(recipe);

            // Act remove
            User updatedUser = userDataHandler.RemoveSavedRecipeFromUser(recipe, user);

            // Assert checking removed
            Assert.DoesNotContain(recipe, updatedUser.SavedRecipes);
        }
    }
}