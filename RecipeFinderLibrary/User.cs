namespace RecipeFinderLibrary
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }

        //public List<string> SavedRecipes { get; set; }

        public static User CreateUser(string username, string password)
        {
            User user = new User();
            user.Username = username;
            user.Password = password;

            return user;
        }
    }
}