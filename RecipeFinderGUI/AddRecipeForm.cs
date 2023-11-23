namespace RecipeFinderGUI
{
    public partial class AddRecipeForm : Form
    {
        public AddRecipeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //insert into recipes (Name,Ingredients,DietaryRestrictions,CookingTime,Instructions,Cost,Description) values ('Pizza','great stuff','Vegan','20 minutes','Call Take Out',12,'best food ever invented')

            //DataAccess da = new DataAccess();


            string query = "insert into recipes(Name, Ingredients, DietaryRestrictions, CookingTime, Instructions, Cost, Description) values('" + recipeNameTextbox + "', '" + ingredientsTextbox + "', '" + dietaryRestrictionTextbox + "', '" + cookingTimeTextbox + "', '" + instructionsTextbox + "'," + costTextbox + ", '" + descriptionTextbox + "')";

            string result = DataAccess.ExecuteScalarQuery(query);



        }

        private void returnToDashboardButton_Click(object sender, EventArgs e)
        {
            // I want to close the current form and return to the DashboardForm
            // Something janky is going on right here and I need help.
            // copy and paste this into ReturnToDashboardButton on the SearchForm when it works properly.
            this.Close();
            this.Dispose();
            var DashboardForm = new DashboardForm();
            DashboardForm.ShowDialog();

            this.Close();

        }

        private void AddRecipeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
