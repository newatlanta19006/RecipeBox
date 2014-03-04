using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBox.Core
{
    public class RecipeBox
    {
        public List<Recipe> Recipes { get; private set; }

        public RecipeBox()
        {
            Recipes = new List<Recipe>();
        }

        public void AddRecipe(Recipe recipe)
        {
            Recipes.Add(recipe);
        }

        public void RemoveRecipe(int index)
        {
            Recipes.RemoveAt(index);
        }
    }
}
