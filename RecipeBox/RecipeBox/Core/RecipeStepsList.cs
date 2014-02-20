using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBox.Core
{
    public class RecipeStepsList
    {
        private List<RecipeStep> _RecipeSteps;

        public RecipeStepsList()
        {
            _RecipeSteps = new List<RecipeStep>();
        }

        /*
         * Return new index of successfully added recipe step. -1 if unsuccessful.
         */
        public int AddRecipeStep(RecipeStep newRecipeStep)
        {
            _RecipeSteps.Add(newRecipeStep);
            return _RecipeSteps.Count;
        }

        /*
         * Return true/false if removal was successful.
         */
        public bool RemoveRecipeStep(int index)
        {
            _RecipeSteps.RemoveAt(index);
            return true;
        }
    }
}
