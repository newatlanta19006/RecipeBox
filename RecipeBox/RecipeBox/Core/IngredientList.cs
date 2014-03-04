using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBox.Core
{
    public class IngredientList
    {
        public List<Ingredient> Ingredients { get; private set; }

        public IngredientList()
        {
            Ingredients = new List<Ingredient>();
        }

        public int AddIngredient(Ingredient newIngredient)
        {
            Ingredients.Add(newIngredient);
            return Ingredients.Count;
        }

        public bool RemoveIngredient(int index)
        {
            Ingredients.RemoveAt(index);
            return true;
        }
    }
}
