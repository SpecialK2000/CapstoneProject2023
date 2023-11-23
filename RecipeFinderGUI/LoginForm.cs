using System.Data.SQLite;
using RecipeFinderLibrary;

namespace RecipeFinderGUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            SetVisibility();
        }

        private void SetVisibility()
        {
            usernameLabel1.Visible = true;
            passwordLabel1.Visible = true;
        }


        private void usernameLabel1_Click(object sender, EventArgs e)
        {

        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            var database = new Database();
            var userAuthentication = new UserAuthentication(database);
            try
            {
                //todo remove this before you turn it in!!!!!!!!!!!!!!!!!!!!!!!!!!!
                //usernameTextBox.Text = "Test652";
                //passwordTextBox.Text = "Test652";

                var authenticatedUser = userAuthentication.Login(usernameTextBox.Text, passwordTextBox.Text);
                if (!string.IsNullOrEmpty(authenticatedUser.Username))
                {
                    AuthenticatedUser.User = authenticatedUser;
                    this.Hide();

                    var dashboardForm = new DashboardForm();
                    dashboardForm.ShowDialog();

                    this.Close();
                }
                

            }
            catch (UnauthorizedAccessException loginFailed)
            {
                usernameLabel1.Visible = true;
                usernameLabel1.Text = "Your Username and/or Password is invalid. Please try again";
            }
            catch (Exception ex)
            {
                //ToDo display message within ex.Message
            }

            

            //new DashboardForm().ShowDialog(); Modal way, keeps both forms open.

            // homeowrk 1 - figure out how to close the original login form.
            // This way hides the current form, opens the dashboard form and then closes after
            // the dashboard form is closed.

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

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}