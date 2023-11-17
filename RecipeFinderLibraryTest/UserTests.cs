using RecipeFinderLibrary;

namespace RecipeFinderLibraryTest
{
    public class UserTests
    {
        [Fact]
        public void CanGenerateUsername()
        {
            var testUser = new User();
            Assert.False(string.IsNullOrWhiteSpace(testUser.Username));
        }

        [Fact]
        public void CanGeneratePassword()
        {
            var testUser = new User();
            Assert.False(string.IsNullOrWhiteSpace(testUser.Password));
        }

        [Fact]
        public void CanCreateUserSavedRecipesList()
        {
            var testUser = new User();
            Assert.NotEmpty(testUser.SavedRecipes);
        }
    }
}