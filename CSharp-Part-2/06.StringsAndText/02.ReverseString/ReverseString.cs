using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToReverseString
{
    class ReverseString
    {
        static void Main()
        {
            string str = Console.ReadLine();
            string rev = String.Empty;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev += Convert.ToString(str[i]);
            }
            Console.WriteLine(rev);
        }
    }
}
