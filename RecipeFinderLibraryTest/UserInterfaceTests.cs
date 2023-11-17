using RecipeFinderLibrary;

namespace RecipeFinderLibraryTest
{
    public class UserInterfaceTests
    {
        [Fact]
        public void CanDisplayMainMenu()
        {
            // Arrange
            UserInterface userInterface = new UserInterface();

            // Act
            // Since this method is a display method, we cannot easily test its output.
            // Instead, we'll just verify that it does not throw any exceptions.
            userInterface.DisplayMainMenu();
        }

        [Fact]
        public void CanGetUserInput()
        {
            // Arrange
            UserInterface userInterface = new UserInterface();
            string expectedInput = "user_input";
            StringReader stringReader = new StringReader(expectedInput);
            Console.SetIn(stringReader);

            // Act
            string userInput = userInterface.GetUserInput();

            // Clean up
            stringReader.Dispose();
            Console.SetIn(Console.In);

            // Assert
            Assert.Equal(expectedInput, userInput);
        }

        [Fact]
        public void CanDisplayRegistrationForm()
        {
            // Arrange
            UserInterface userInterface = new UserInterface();

            // Act
            // Similar to CanDisplayMainMenu, just checking for exceptions here.
            userInterface.DisplayRegistrationForm();
        }

        [Fact]
        public void CanGetRegistrationInput()
        {
            // Arrange
            UserInterface userInterface = new UserInterface();
            string expectedUsername = "testusername";
            string expectedPassword = "test123";
            StringReader stringReader = new StringReader($"{expectedUsername}\n{expectedPassword}");
            Console.SetIn(stringReader);

            // Act
            (string username, string password) = userInterface.GetRegistrationInput();

            // Clean up
            stringReader.Dispose();
            Console.SetIn(Console.In);

            // Assert
            Assert.Equal(expectedUsername, username);
            Assert.Equal(expectedPassword, password);
        }

        [Fact]
        public void CanDisplayLoginForm()
        {
            // Arrange
            UserInterface userInterface = new UserInterface();

            // Act
            userInterface.DisplayLoginForm();
        }

        [Fact]
        public void CanGetLoginInput()
        {
            // Arrange
            UserInterface userInterface = new UserInterface();
            string expectedUsername = "testusername";
            string expectedPassword = "test123";
            StringReader stringReader = new StringReader($"{expectedUsername}\n{expectedPassword}");
            Console.SetIn(stringReader);

            // Act
            (string username, string password) = userInterface.GetLoginInput();

            // Clean up
            stringReader.Dispose();
            Console.SetIn(Console.In);

            // Assert
            Assert.Equal(expectedUsername, username);
            Assert.Equal(expectedPassword, password);
        }

        [Fact]
        public void CanDisplaySearchOptions()
        {
            // Arrange
            UserInterface userInterface = new UserInterface();

            // Act
            userInterface.DisplaySearchOptions();
        }

        [Fact]
        public void CanRetrieveSearchCriteria()
        {
            // Arrange
            UserInterface userInterface = new UserInterface();
            string expectedSearchType = "dietary restriction";
            string expectedSearchValue = "gluten free";
            StringReader stringReader = new StringReader($"{expectedSearchType}\n{expectedSearchValue}");
            Console.SetIn(stringReader);

            // Act
            (string searchType, string searchValue) = userInterface.GetSearchCriteria();

            // Clean up
            stringReader.Dispose();
            Console.SetIn(Console.In);

            // Assert
            Assert.Equal(expectedSearchType, searchType);
            Assert.Equal(expectedSearchValue, searchValue);
        }

        [Fact]
        public void CanDisplaySearchResults()
        {
            // Arrange
            UserInterface userInterface = new UserInterface();
            List<Recipe> recipes = new List<Recipe>
        {
            new Recipe { Name = "Recipe 1", Description = "Description 1" },
            new Recipe { Name = "Recipe 2", Description = "Description 2" },
            new Recipe { Name = "Recipe 3", Description = "Description 3" }
        };

            // Act
            userInterface.DisplaySearchResults(recipes);
        }

        [Fact]
        public void DisplayRecipeDetails_ShouldNotThrowException()
        {
            // Arrange
            UserInterface userInterface = new UserInterface();
            Recipe recipe = new Recipe { Name = "Test Recipe", Description = "Test Description" };

            // Act
            userInterface.DisplayRecipeDetails(recipe);

            // No explicit assertion needed, we're checking for exceptions.
        }

        [Fact]
        public void CanDisplayUserDashboard()
        {
            // Arrange
            UserInterface userInterface = new UserInterface();
            User user = new User { Username = "testusername"};

            // Act
            userInterface.DisplayUserDashboard(user);
        }
    }
}