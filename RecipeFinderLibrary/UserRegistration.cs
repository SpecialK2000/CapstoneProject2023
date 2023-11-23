namespace RecipeFinderLibrary
{
    public class UserRegistration
    {
        // Placeholder methods for user registration
        //public string RegisterUser(string username, string password) { return ""; } //dont need

        private Database database;

        public UserRegistration(Database db)
        {
            database = db;
        }

        public bool RegisterUser(string username, string password)
        {
            // Validate username and password (basic validation for example purposes)
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("Username and password cannot be empty");
            }

            // Check if username already exists
            var user = database.QueryByUsername(username, password);
            if (!string.IsNullOrEmpty(user.Username))
            {
                return false; // Username already exists
            }
            // Username lookup, return error if exists
            // select count (*) from table where username = User input
            // if count > 0 throw error, else...



            //else
            //{
            // Create a new User object with plain password
            User newUser = new User
            {
                Username = username,
                Password = password // Storing the password as plain text
            };

            // Save the user to the database
            database.SaveUser(newUser);
            //}
            return true;
        }
    }
}