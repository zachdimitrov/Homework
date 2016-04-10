using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinToDecimal
{
    static void Main()
    {
        string binString = Console.ReadLine();
        char[] signs = binString.ToCharArray();
        int result = 0;
        int k = 1;
        Array.Reverse(signs);
        for (int i = 0; i < signs.Length; i++)
        {
            if (signs[i] == '1')
            {
                result += k;
            }
            k *= 2;
        }
        Console.WriteLine(result);
    }
}
