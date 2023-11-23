using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeFinderGUI
{
    public partial class DeleteRecipe : Form
    {
        public DeleteRecipe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string query = "Delete from recipes where pk = 18";

            string result = DataAccess.ExecuteScalarQuery(query);

        }
    }
}
