using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RecipeFinderLibrary;


namespace RecipeFinderGUI
{
    public partial class SearchForm : Form
    {
        private RecipeSearch recipeSearch;

        public SearchForm()
        {
            InitializeComponent();
            budgetRadioButton.Checked = true;
            SetVisibilityOfControls();
            PreloadRestrictions();
        }

        private void SetVisibilityOfControls()
        {
            var shouldShowBudget = (budgetRadioButton.Checked || bothRadioButton.Checked) ? true : false;
            var shouldShowDietaryRestrictions = (dietaryRestrictionRadioButton.Checked || bothRadioButton.Checked) ? true : false;
            priceRangeFromLabel.Visible = shouldShowBudget;
            priceRangeFromText.Visible = shouldShowBudget;
            priceRangeToLabel.Visible = shouldShowBudget;
            priceRangeToText.Visible = shouldShowBudget;
            dietaryRestrictionLabel.Visible = shouldShowDietaryRestrictions;
            DietaryRestrictionComboBox.Visible = shouldShowDietaryRestrictions;
        }
        private void PreloadRestrictions()
        {

            var myreturn = RecipeModel.GetDietaryRestrictionList();

            DietaryRestrictionComboBox.DataBindings.Clear();
            DietaryRestrictionComboBox.DataBindings.Add("Text",
                                myreturn,
                                "DietaryRestrictions",
                                false,
                                DataSourceUpdateMode.OnPropertyChanged);




        }


        private void RecipeSearchButton_Click(object sender, EventArgs e)
        {
            List<Recipe>? myreturn = null;

            if (budgetRadioButton.Checked)
            {
                int priceFrom = int.Parse(priceRangeFromText.Text);
                int priceTo = int.Parse(priceRangeToText.Text);

                myreturn = RecipeModel.GetByBudget(priceFrom, priceTo);
            }
            else if (dietaryRestrictionRadioButton.Checked)
            {
                myreturn = RecipeModel.GetDietaryRestrictions(DietaryRestrictionComboBox.Text);
            }
            else
            {
                int priceFrom = int.Parse(priceRangeFromText.Text);
                int priceTo = int.Parse(priceRangeToText.Text);

                myreturn = RecipeModel.GetByBoth(DietaryRestrictionComboBox.Text, priceFrom, priceTo);
            }

            recipeDataGrid.DataSource = myreturn;
            recipeDataGrid.AutoGenerateColumns = false;
            if (recipeDataGrid.Columns.Contains(nameof(Recipe.CookingTime)))
            {
                recipeDataGrid.Columns.Remove(nameof(Recipe.CookingTime));
                recipeDataGrid.Columns.Remove(nameof(Recipe.DietaryRestrictions));
                recipeDataGrid.Columns.Remove(nameof(Recipe.Ingredients));
                recipeDataGrid.Columns.Remove(nameof(Recipe.Instructions));
            }
        }

        private void budgetRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SetVisibilityOfControls();
        }

        private void dietaryRestrictionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SetVisibilityOfControls();
        }

        private void bothRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SetVisibilityOfControls();
        }

        private void priceRangeFromText_TextChanged(object sender, EventArgs e)
        {

            //var incoming = ((System.Windows.Forms.TextBox)sender).Text;
            //char[] characters = incoming.ToCharArray();

            //StringBuilder sb = new StringBuilder();

            //foreach (var item in characters)
            //{
            //    int x = Convert.ToInt32(item);
            //    if (x >= 48 && x <= 57)
            //    {
            //        sb.Append(x);
            //    }
            //}
            //priceRangeFromText.Text = sb.ToString();



        }

        private void recipeDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the double-clicked cell is not a header
            if (e.RowIndex >= 0)
            {
                // Retrieve the recipe data from the selected row
                var recipe = recipeDataGrid.Rows[e.RowIndex].DataBoundItem as Recipe;

                if (recipe != null)
                {
                    // Open the Recipe Details Form and pass the selected recipe
                    var ViewRecipeDetailsForm = new ViewRecipeDetailsForm();
                    ViewRecipeDetailsForm.Show();

                }
            }
        }

        private void DietaryRestrictionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void returnToDashboardFromSearchForm_Click(object sender, EventArgs e)
        {

        }

        
    }
}
