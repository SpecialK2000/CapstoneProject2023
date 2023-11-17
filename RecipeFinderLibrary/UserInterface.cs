namespace RecipeFinderLibrary
{
    public class UserInterface
    {
        public void DisplayMainMenu() { }
        public string GetUserInput() { return ""; }
        public void DisplayRegistrationForm() { }
        public (string, string) GetRegistrationInput() { return ("", ""); }
        public void DisplayLoginForm() { }
        public (string, string) GetLoginInput() { return ("", ""); }
        public void DisplaySearchOptions() { }
        public (string, string) GetSearchCriteria() { return ("", ""); }
        public void DisplaySearchResults(List<Recipe> recipes) { }
        public void DisplayRecipeDetails(Recipe recipe) { }
        public void DisplayUserDashboard(User user) { }
    }
}