using System;
using System.Text;

namespace DefineClasses2
{
    /// <summary>
    /// exporting attributes
    /// </summary>

    public class TestAttribute
    {
        public static String PrintInfo(Type t)
        {
            // Using reflection.
            Attribute[] attrs = Attribute.GetCustomAttributes(t);  // Reflection.

            // Displaying output.

            StringBuilder str = new StringBuilder();
            foreach (Attribute attr in attrs)
            {
                str.AppendLine(attr.ToString());
            }
            return str.ToString();
        }
    }
}
