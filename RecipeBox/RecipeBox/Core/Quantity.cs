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
        [Description("Piece")]
        Piece,
        [Description("Cup")]
        Cup,
        [Description("Tablespoon")]
        Tablespoon,
        [Description("Teaspoon")]
        Teaspoon,
        [Description("Pound")]
        Pound
    }

    public class Quantity
    {
        public float Amount { get; set; }
        public QuantityType Type { get; set; }

        public Quantity(float amount, QuantityType type)
        {
            Amount = amount;
            Type = type;
        }

        public static string GetEnumDescription(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes =
                (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0)
                return attributes[0].Description;
            else
                return value.ToString();
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
