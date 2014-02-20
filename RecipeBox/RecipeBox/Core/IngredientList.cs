using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBox.Core
{
    public class IngredientList
    {
        private List<Ingredient> _Ingredients;

        public IngredientList()
        {
            _Ingredients = new List<Ingredient>();
        }

        public int AddIngredient(Ingredient newIngredient)
        {
            _Ingredients.Add(newIngredient);
            return _Ingredients.Count;
        }

        public bool RemoveIngredient(int index)
        {
            _Ingredients.RemoveAt(index);
            return true;
        }
    }
}
