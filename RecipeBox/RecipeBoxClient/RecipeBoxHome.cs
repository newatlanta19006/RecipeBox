using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeBoxClient
{
    public partial class RecipeBoxHome : Form
    {
        public RecipeBoxHome()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddNewRecipeButton_Click(object sender, EventArgs e)
        {
            NewRecipeDialog form = new NewRecipeDialog();
            form.Show();
        }
    }
}
