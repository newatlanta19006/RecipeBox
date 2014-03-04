using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBox.Core
{
    public class Recipe
    {
        public string Name { get; set; } //Name of recipe
        public string Description { get; set; } //Description of the recipe
        public float PreparationTime { get; set; } //Prep time of recipe in minutes
        public float CookingTime { get; set; } //Cook time of recipe in minutes
        
        public IngredientList Ingredients { get; private set; } //List of ingredients for the recipe
        public RecipeStepsList RecipeSteps { get; private set; } //List of steps for the recipe


        public Recipe()
        {
            Name = "Default Recipe Name";
            Description = "";
            PreparationTime = 0.0f;
            CookingTime = 0.0f;
            Ingredients = new IngredientList();
            RecipeSteps = new RecipeStepsList();


        }

        public int AddIngredient(string name, Quantity quantity)
        {
            return Ingredients.AddIngredient(new Ingredient(name, quantity));
        }

        public int AddIngredient(Ingredient ingredient)
        {
            return Ingredients.AddIngredient(ingredient);
        }

        public bool RemoveIngredient(int index)
        {
            return Ingredients.RemoveIngredient(index);
        }

        public int AddRecipeStep(string text)
        {
            return AddRecipeStep(new RecipeStep(text));
        }

        public int AddRecipeStep(RecipeStep step)
        {
            return RecipeSteps.AddRecipeStep(step);
        }

        public bool RemoveRecipeStep(int index)
        {
            return RecipeSteps.RemoveRecipeStep(index);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
