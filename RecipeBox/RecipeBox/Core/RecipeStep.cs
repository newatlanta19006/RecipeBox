using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBox.Core
{
    public class RecipeStep
    {
        public string StepText { get; set; }

        public RecipeStep()
            : this("Default Step Text.")
        {
        }

        public RecipeStep(string stepText)
        {
            StepText = stepText;
        }

        public override string ToString()
        {
            return StepText;
        }
    }
}
