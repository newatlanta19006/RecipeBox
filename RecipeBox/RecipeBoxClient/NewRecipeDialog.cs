using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RecipeBox.Core;

namespace RecipeBoxClient
{
    public partial class NewRecipeDialog : Form
    {
        public Recipe NewRecipe;

        public NewRecipeDialog()
        {
            InitializeComponent();
            NewRecipe = new Recipe();
        }

        private void NewRecipeDialog_Load(object sender, EventArgs e)
        {
            this.IngredientsList.DataSource = NewRecipe.Ingredients;
            this.IngredientsList.Refresh();



            foreach(QuantityType type in Quantity.EnumToList<QuantityType>())
            {
                this.NewIngredientType.(Quantity.GetEnumDescription(type));
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void NewIngredientAdd_Click(object sender, EventArgs e)
        {
            Ingredient ingredient = new Ingredient(this.NewIngredientName.Text, new Quantity((float)Convert.ToDouble(this.NewIngredientQnty.Text), (QuantityType)this.NewIngredientType.SelectedValue));
            NewRecipe.AddIngredient(ingredient);
        }
    }
}
