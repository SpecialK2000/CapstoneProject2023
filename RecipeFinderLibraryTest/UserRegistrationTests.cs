using RecipeFinderLibrary;

namespace RecipeFinderLibraryTest
{
    public class UserRegistrationTests
    {
        [Fact]
        public void CanRegisterUser()
        {
            // Arrange
            UserRegistration userRegistration = new UserRegistration();
            string username = "testusername";
            string password = "test123";

            // Act
            string result = userRegistration.RegisterUser(username, password);

            // Assert
            //Assert.Equal("User registered successfully", result);
            //Assert.NotNull(result);
            Assert.NotEmpty(result);
        }
    }
}