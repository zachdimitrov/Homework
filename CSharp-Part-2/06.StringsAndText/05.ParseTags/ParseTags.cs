using System;
using System.Text;

namespace ToParseTags
{
    class ParseTags
    {
        static string RemoveTags(string toChange)
        {
            string changed = string.Empty;
            bool test = true;
            foreach (char c in toChange)
            {
                if (c == '<')
                {
                    test = false;
                }
                else if (c == '>')
                {
                        test = true;
                }
                if (test && c != '>')
                {
                    changed += c;
                }
            }
            return changed;
        }
        static void Main()
        {
            string text = Console.ReadLine();
            StringBuilder str = new StringBuilder(text);
            int index1 = 0;
            index1 = text.IndexOf("<upcase>");
            int index2 = 0;
            while (index2 != -1 && index1 != -1)
            {
                index2 = text.IndexOf("</upcase>", index1);
                string toChange = text.Substring(index1, index2 - index1 + 9);
                string changed = RemoveTags(toChange).ToUpper();
                str.Remove(index1, index2 - index1 + 9);
                str.Insert(index1, changed);
                text = str.ToString();
                index1 = text.IndexOf("<upcase>", index2 - 9);
            }
            Console.WriteLine(str);
        }
    }
}

// 00000000001111111111122222222223333333333
// 01234567890012345678901234567890123456789
// 012<4>67<9>12