using RecipeFinderLibrary;

namespace RecipeFinderGUI
{
    public partial class DeleteRecipe : Form
    {
        public DeleteRecipe()
        {
            InitializeComponent();
            PreloadRestrictions();
        }

        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void PreloadRestrictions()
        {

            var myreturn = RecipeModel.GetDietaryRestrictionList();

            comboBox1.Items.Clear();
            foreach (var item in myreturn)
            {
                comboBox1.Items.Add(item.DietaryRestrictions);
            }
        }

        private void returnToDashboardButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var DashboardForm = new DashboardForm();
            DashboardForm.ShowDialog();
        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var myreturn = RecipeModel.GetDietaryRestrictions(comboBox1.Text);

            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "pk";
            comboBox2.DataSource = myreturn;

        }

        private void deleteRecipeButton_Click(object sender, EventArgs e)
        {
            string query = "Delete from recipes where pk =" + comboBox2.SelectedValue;

            string result = DataAccess.ExecuteScalarQuery(query);
        }
    }
}