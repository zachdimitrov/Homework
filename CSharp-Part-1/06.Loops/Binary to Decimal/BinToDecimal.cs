using System;

class BinToDecimal
{
    static void Main()
    {
        string binString = Console.ReadLine();
        int result = 0;
        int k = 1;
        for (int i = binString.Length-1; i >= 0; i--)
        {
            if (binString[i] == '1')
            {
                result += k;
            }
            k *= 2;
        }
        Console.WriteLine(result);
    }
}
