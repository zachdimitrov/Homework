using System;
using System.Collections.Generic;

namespace _002.StringsAndText
{
    class StringsText
    {
        static string[] OrderLex(string left, string right, bool ignorecase = true)
        {
            if (ignorecase)
            {
                left = left.ToLower();
                right = right.ToLower();
            }
            string[] result = new string[2];
            int length = Math.Min(left.Length, right.Length);
            for (int i = 0; i < length; i++)
            {
                if (left[i] < right[i])
                {
                    result[0] = left;
                    result[1] = right;
                    return result;
                }
                else
                {
                    result[0] = right;
                    result[1] = left;
                    return result;
                }
            }
            result[0] = left.Length < right.Length ? left : right;
            result[1] = left.Length > right.Length ? left : right;
            return result;
        }
        static List<int> FindOccurances (string text, string word)
        {
            var indices = new List<int>();
            int indexOfNextBacon = text.IndexOf("bacon");
            while (indexOfNextBacon != -1)
            {
                indices.Add(indexOfNextBacon);
                indexOfNextBacon = text.IndexOf("bacon", indexOfNextBacon + 1);
            }
            return indices;
        }
        static void Main()
        {
            string s1 = "aaAaaa";
            string s2 = "Abbb";
            string[] result = OrderLex(s1, s2, false);
            Console.WriteLine(result[0] + ", " + result[1]);
            string text = @"bacon ipsum dolor amet tongue short ribs frankfurter cow leberkas tenderloin
short loin kevin shank meatball turducken swine. Sausage jerky bacon alcatra turkey venison meatloaf. 
Tenderloin pastrami bacon strip steak leberkas cow, picanha ground round ribeye landjaeger flank jowl chuck
ham turkey. Picanha jowl alcatra tongue. Pork bacon loin doner kevin turducken shankle chuck corned beef.";
            Console.WriteLine(text.IndexOf("bacon"));
            Console.WriteLine(text.IndexOf("bacon", 6));
            var indices = FindOccurances(text, "bacon");
            Console.WriteLine(String.Join(", ", indices));
        }
    }
}
