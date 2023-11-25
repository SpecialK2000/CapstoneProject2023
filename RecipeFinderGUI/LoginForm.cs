using System.Data.SQLite;
using RecipeFinderLibrary;

namespace RecipeFinderGUI
{
    public partial class LoginForm : Form
    {

        private DashboardForm dashboardForm;
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
                var authenticatedUser = userAuthentication.Login(usernameTextBox.Text, passwordTextBox.Text);
                if (!string.IsNullOrEmpty(authenticatedUser.Username))
                {
                    ShowDashboard(authenticatedUser);
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
        }

        private void ShowDashboard(User authenticatedUser)
        {
            AuthenticatedUser.User = authenticatedUser;
            this.Hide();

            var dashboardForm = new DashboardForm();
            dashboardForm.ShowDialog();

            //this.Close();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            var database = new Database();
            var userRegistration = new UserRegistration(database);
            var authenticatedUser = userRegistration.RegisterUser(usernameTextBox.Text, passwordTextBox.Text);
            if (!string.IsNullOrEmpty(authenticatedUser.Username))
            {
                ShowDashboard(authenticatedUser);
            }
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}