using System;

class HexToBinary
{
    static void Main()
    {
        string hex = Console.ReadLine();
        HexToBin(hex);
    }

    private static void HexToBin(string hex)
    {
        string bin = string.Empty;
        int index = hex.Length - 1;
        for (int i = 0; i < hex.Length; i++)
        {
            if (i == hex.Length - 1)
            {
                bin = ConvHexDigit(hex[index]) + bin;
            }
            else
            {
                bin = ConvHexDigit(hex[index]).PadLeft(4, '0') + bin;
            }
            index--;
        }
        Console.WriteLine(bin);
    }

    private static string ConvHexDigit(char v)
    {
        switch (v)
        {
            case '1': return "1";
            case '2': return "10";
            case '3': return "11";
            case '4': return "100";
            case '5': return "101";
            case '6': return "110";
            case '7': return "111";
            case '8': return "1000";
            case '9': return "1001";
            case 'A': return "1010";
            case 'B': return "1011";
            case 'C': return "1100";
            case 'D': return "1101";
            case 'E': return "1110";
            case 'F': return "1111";
            default: return "0";
        }
    }
}