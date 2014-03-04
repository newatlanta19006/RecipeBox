using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBox.Core
{
    public class RecipeStepsList
    {
        public List<RecipeStep> RecipeSteps {get; private set; }

        public RecipeStepsList()
        {
            RecipeSteps = new List<RecipeStep>();
        }

        /*
         * Return new index of successfully added recipe step. -1 if unsuccessful.
         */
        public int AddRecipeStep(RecipeStep newRecipeStep)
        {
            RecipeSteps.Add(newRecipeStep);
            return RecipeSteps.Count;
        }

        /*
         * Return true/false if removal was successful.
         */
        public bool RemoveRecipeStep(int index)
        {
            RecipeSteps.RemoveAt(index);
            return true;
        }
    }
}
