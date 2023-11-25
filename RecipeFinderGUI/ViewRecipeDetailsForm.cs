using RecipeFinderLibrary;

namespace RecipeFinderGUI
{
    public partial class ViewRecipeDetailsForm : Form
    {
        public ViewRecipeDetailsForm(Recipe recipe)
        {
            InitializeComponent();
            var myreturn = RecipeModel.GetRecipe(recipe.pk);

            lblDisplayName.Text = myreturn.Name;
            displayCookingTime.Text = myreturn.CookingTime;
            displayDietaryRestriction.Text = myreturn.DietaryRestrictions;
            displayCost.Text = myreturn.Cost.ToString();
            displayIngredients.Text = myreturn.Ingredients;
            displayInstructions.Text = myreturn.Instructions;
        }

        private void saveRecipeToLibraryButton_Click(object sender, EventArgs e)
        {

        }

        private void closeFormButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void recipeNameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ingredientsListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void instructionsListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblDisplayName_Click(object sender, EventArgs e)
        {

        }
    }
}