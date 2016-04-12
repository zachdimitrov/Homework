using System;

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
