using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBox.Core
{
    public class QuantityMeasurement
    {
        public QuantityType Type { get; set; }
        public string Text { get; set; }

        public QuantityMeasurement(QuantityType type, string text)
        {
            this.Type = type;
            this.Text = text;
        }

        public override string ToString()
        {
            return this.Text;
        }
    }
}
