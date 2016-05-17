using System;

class BinaryToHex
{
    static void Main()
    {
        string bin = Console.ReadLine();
        BinToHex(bin);
    }

    private static void BinToHex(string bin)
    {
        string hex = string.Empty;
        string part = string.Empty;
        while (true)
        {
            if (bin.Length <= 4)
            {
                hex = ConvBinToXexDigit(bin.PadLeft(4, '0')) + hex;
                break;
            }
            part = bin.Substring(bin.Length - 4);
            hex = ConvBinToXexDigit(part) + hex;
            bin = bin.Remove(bin.Length - 4);
        }
        Console.WriteLine(hex);
    }

    private static string ConvBinToXexDigit(string part)
    {
        switch (part)
        {
            case "0001": return "1";
            case "0010": return "2";
            case "0011": return "3";
            case "0100": return "4";
            case "0101": return "5";
            case "0110": return "6";
            case "0111": return "7";
            case "1000": return "8";
            case "1001": return "9";
            case "1010": return "A";
            case "1011": return "B";
            case "1100": return "C";
            case "1101": return "D";
            case "1110": return "E";
            case "1111": return "F";
            default: return "0";
        }
    }
}