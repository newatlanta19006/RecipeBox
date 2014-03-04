using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Reflection;

namespace RecipeBox.Core
{
    public enum QuantityType
    {
        Piece,
        Cup,
        Tablespoon,
        Teaspoon,
        Pound
    }

    public class Quantity
    {
        public float Amount { get; set; }
        public QuantityMeasurement Measurement { get; set; }

        public Quantity(float amount, QuantityMeasurement measurement)
        {
            Amount = amount;
            Measurement = measurement;
        }

        // TODO: Find a better way to do this
        public static QuantityMeasurement GetQuantityMeasurementFromQuantityType(QuantityType type)
        {
            QuantityMeasurement measure = new QuantityMeasurement(type, "Default");
            switch(type)
            {
                case QuantityType.Cup:
                    measure.Text = "Cup";
                    break;
                case QuantityType.Piece:
                    measure.Text = "Piece";
                    break;
                case QuantityType.Pound:
                    measure.Text = "Pound";
                    break;
                case QuantityType.Tablespoon:
                    measure.Text = "Tablespoon";
                    break;
                case QuantityType.Teaspoon:
                    measure.Text = "Teaspoon";
                    break;
                default:
                    break;
            }
            return measure;
        }

        public static QuantityMeasurement GetQuantityMeasurementFromString(string text)
        {
            QuantityMeasurement measure = new QuantityMeasurement(QuantityType.Piece, "default");
            if (text == "Cup")
            {
                measure = GetQuantityMeasurementFromQuantityType(QuantityType.Cup);
            }
            else if (text == "Piece")
            {
                measure = GetQuantityMeasurementFromQuantityType(QuantityType.Piece);
            }
            else if (text == "Pound")
            {
                measure = GetQuantityMeasurementFromQuantityType(QuantityType.Pound);
            }
            else if (text == "Tablespoon")
            {
                measure = GetQuantityMeasurementFromQuantityType(QuantityType.Tablespoon);
            }
            else if (text == "Teaspoon")
            {
                measure = GetQuantityMeasurementFromQuantityType(QuantityType.Teaspoon);
            }
            return measure;
        }

        public static IEnumerable<T> EnumToList<T>()
        {
            Type enumType = typeof(T);

            // Can't use generic type constraints on value types,
            // so have to do check like this
            if (enumType.BaseType != typeof(Enum))
                throw new ArgumentException("T must be of type System.Enum");

            Array enumValArray = Enum.GetValues(enumType);
            List<T> enumValList = new List<T>(enumValArray.Length);

            foreach (int val in enumValArray)
            {
                enumValList.Add((T)Enum.Parse(enumType, val.ToString()));
            }

            return enumValList;
        }
    }
}
