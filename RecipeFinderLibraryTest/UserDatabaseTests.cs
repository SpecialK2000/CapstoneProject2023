using RecipeFinderLibrary;

namespace RecipeFinderLibraryTest
{
    public class UserDatabaseTests
    {
        [Fact]
        public void IsUsernameTaken_ExistingUsername_ReturnsTrue()
        {
            // Arrange
            UserDatabase userDatabase = new UserDatabase();
            string existingUsername = "existingUser";


            // Act
            bool result = userDatabase.IsUsernameTaken(existingUsername);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsUsernameTaken_NonExistingUsername_ReturnsFalse()
        {
            // Arrange
            UserDatabase userDatabase = new UserDatabase();
            string nonExistingUsername = "nonExistingUser";

            // Act
            bool result = userDatabase.IsUsernameTaken(nonExistingUsername);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void SaveUser_SavesUserToDatabase()
        {
            // Arrange
            UserDatabase userDatabase = new UserDatabase();
            User userToSave = new User { Username = "newUser"};

            // Act
            userDatabase.SaveUser(userToSave);

            // Assert
            // Add assertions to verify that the user was successfully saved to the database.
        }

        [Fact]
        public void QueryUserByUsername_ExistingUsername_ReturnsUser()
        {
            // Arrange
            UserDatabase userDatabase = new UserDatabase();
            string existingUsername = "existingUser";

            // Act
            User result = userDatabase.QueryUserByUsername(existingUsername);

            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void QueryUserByUsername_NonExistingUsername_ReturnsNull()
        {
            // Arrange
            UserDatabase userDatabase = new UserDatabase();
            string nonExistingUsername = "nonExistingUser";

            // Act
            User result = userDatabase.QueryUserByUsername(nonExistingUsername);

            // Assert
            Assert.Null(result);
        }
    }
}