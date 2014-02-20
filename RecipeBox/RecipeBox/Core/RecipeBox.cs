using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBox.Core
{
    public class RecipeBox
    {
        List<Recipe> _Recipes;

        public RecipeBox()
        {
            _Recipes = new List<Recipe>();
        }

        public void AddRecipe(Recipe recipe)
        {
            _Recipes.Add(recipe);
        }

        public void RemoveRecipe(int index)
        {
            _Recipes.RemoveAt(index);
        }
    }
}
