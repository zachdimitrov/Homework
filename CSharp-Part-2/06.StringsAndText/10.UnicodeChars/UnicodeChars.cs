using System;
using System.Text;

namespace ForUnicodeChars
{
    class UnicodeChars
    {
        static void Main()
        {
            string chars = Console.ReadLine();
            string output = string.Empty;
            StringBuilder str = new StringBuilder(output);
            foreach (char c in chars)
            {
                int charValue = (int)c;
                string toAdd = string.Format("\\u{0:0000}", Convert.ToString(charValue, 16).PadLeft(4, '0'));
                str.Append(toAdd);
            }
            Console.WriteLine(str);
        }
    }
}
