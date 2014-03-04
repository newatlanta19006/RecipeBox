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

            foreach (QuantityType type in Quantity.EnumToList<QuantityType>())
            {
                this.NewIngredientType.Items.Add(type.ToString());
            }

            this.IngredientsList.DataSource = NewRecipe.Ingredients.Ingredients;
            this.IngredientsList.Refresh();




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
            Ingredient ingredient = new Ingredient(this.NewIngredientName.Text, new Quantity((float)Convert.ToDouble(this.NewIngredientQnty.Text), Quantity.GetQuantityMeasurementFromString((string)this.NewIngredientType.SelectedItem)));
            NewRecipe.AddIngredient(ingredient);
            this.IngredientsList.DataSource = null;
            this.IngredientsList.DataSource = NewRecipe.Ingredients.Ingredients;
        }

        private void NewStepAdd_Click(object sender, EventArgs e)
        {
            RecipeStep step = new RecipeStep(this.NewStepText.Text);
            NewRecipe.AddRecipeStep(step);
            this.RecipeStepsList.DataSource = null;
            this.RecipeStepsList.DataSource = NewRecipe.RecipeSteps.RecipeSteps;
        }

        private void NewRecipeAdd_Click(object sender, EventArgs e)
        {
            NewRecipe.Name = this.NewRecipeName.Text;
            NewRecipe.CookingTime = (float)Convert.ToDouble(this.NewRecipeCookTime.Text);
            NewRecipe.PreparationTime = (float)Convert.ToDouble(this.NewRecipePrepTime.Text);
            NewRecipe.Description = this.NewRecipeDescription.Text;
            Program.RecipeBox.AddRecipe(NewRecipe);
            this.Close();
        }
    }
}
