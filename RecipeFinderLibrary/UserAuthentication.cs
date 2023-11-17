namespace RecipeFinderLibrary
{
    public class UserAuthentication
    {
        // Placeholder methods for user authentication
        //public string AuthenticateUser(string username, string password) { return ""; }

        private Database database;

        public UserAuthentication(Database db)
        {
            database = db;
        }

        public User Login(string username, string password)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("Username and password cannot be empty");
            }

            // Retrieve the user from the database
            User user = database.QueryByUsername(username,password);

            // Check if user exists and the password matches
            if (!string.IsNullOrEmpty(user.Username))
            {
                return user; // Login successful and open dashboard form
            }

            throw new UnauthorizedAccessException();
        }
    }
}