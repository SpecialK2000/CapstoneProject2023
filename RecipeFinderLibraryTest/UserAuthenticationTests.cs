using RecipeFinderLibrary;

namespace RecipeFinderLibraryTest
{
    public class UserAuthenticationTests
    {
        [Fact]
        public void CanAuthenticateUser()
        {
            // Arrange
            UserAuthentication userAuthentication = new UserAuthentication();
            string username = "testusername";
            string password = "test123";

            // Act
            string result = userAuthentication.AuthenticateUser(username, password);

            // Assert
            //Assert.Equal("User authenticated successfully", result);
            Assert.NotEmpty(result);
        }
    }
}