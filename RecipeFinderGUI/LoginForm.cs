using System.Data.SQLite;
using RecipeFinderLibrary;

namespace RecipeFinderGUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }



        private void usernameLabel1_Click(object sender, EventArgs e)
        {

        }

        private void LogIn_SignUp_Click(object sender, EventArgs e)
        {
            var database = new Database();
            var userAuthentication = new UserAuthentication(database);
            try
            {
                var authenticatedUser = userAuthentication.Login(usernameTextBox.Text, passwordTextBox.Text);
                //ToDo navigate to User Dashboard with Authenticated User

            }
            catch(UnauthorizedAccessException loginFailed)
            {
                //ToDo display message to user, that says login failed
            }
            catch(Exception ex)
            {
                //ToDo display message within ex.Message
            }
            
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            var database = new Database();
            var userRegistration = new UserRegistration(database);
            userRegistration.RegisterUser(usernameTextBox.Text, passwordTextBox.Text);
        }

        private void passwordLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}