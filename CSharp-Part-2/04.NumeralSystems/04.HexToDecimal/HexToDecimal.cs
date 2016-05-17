using System;

class HexToDecimal
{
    static void Main()
    {
        string hex = Console.ReadLine();
        HexToDec(hex);
    }

    private static void HexToDec(string hex)
    {
        long dec = 0;

        int index = hex.Length - 1;
        long mul = 1;
        for (int i = 0; i < hex.Length; i++)
        {
            int digit = ConvHexDigit(hex[index]);
            dec += digit * mul;
            mul *= 16;
            index--;
        }
        Console.WriteLine(dec);
    }

    private static int ConvHexDigit(char v)
    {
        switch (v)
        {
            case 'A': return 10;
            case 'B': return 11;
            case 'C': return 12;
            case 'D': return 13;
            case 'E': return 14;
            case 'F': return 15;
            default: return int.Parse(Convert.ToString(v));
        }
    }
}