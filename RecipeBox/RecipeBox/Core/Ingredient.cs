using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBox.Core
{
    public class Ingredient
    {
        public string Name { get; set; }
        public Quantity Amount { get; set; } //Amount of ingredient required for recipe (currently in

        public Ingredient()
            : this("Default Ingredient Name")
        {
        }

        public Ingredient(string name)
            : this(name, new Quantity(1, Quantity.GetQuantityMeasurementFromQuantityType(QuantityType.Piece)))
        {
        }

        public Ingredient(string name, Quantity quantity)
        {
            Name = name;
            Amount = quantity;
        }

        public override string ToString()
        {
            return Amount.Amount + " " + Amount.Measurement.Text + "  " + Name;
        }
    }
}
