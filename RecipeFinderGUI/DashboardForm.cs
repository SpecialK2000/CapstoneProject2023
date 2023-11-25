namespace RecipeFinderGUI
{
    public partial class DashboardForm : Form
    {
        private SearchForm searchForm;
        public DashboardForm()
        {
            InitializeComponent();
            SetVisibilityOfAdminControls();
        }

        private void SetVisibilityOfAdminControls()
        {
            adminAddRecipeButton.Visible = false;
            adminDeleteRecipeButton.Visible = false;
            if (AuthenticatedUser.User!.IsAdmin)
            {
                adminAddRecipeButton.Visible = true;
                adminDeleteRecipeButton.Visible = true;
            }
        }

        private void SearchForRecipesButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            var SearchForm = new SearchForm();
            SearchForm.ShowDialog();

            //this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            var myform = new AddRecipeForm();
            myform.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var myform = new DeleteRecipe();
            myform.ShowDialog();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            var LoginForm = new LoginForm();
            LoginForm.ShowDialog();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }
    }
}