using System;

class DecimalToHex
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        DecToHex(n);
    }

    private static void DecToHex(long n)
    {
        string hex = string.Empty;
        while (n > 0)
        {
            string digit = string.Empty;
            if (n < 16)
            {
                digit = Convert.ToString(n);
            }
            else
            {

                digit = Convert.ToString(n % 16);
            }
            digit = CheckDigit(digit);
            hex = digit + hex;
            n = n / 16;
        }
        Console.WriteLine(hex);
    }

    private static string CheckDigit(string digit)
    {
        switch (digit)
        {
            case "10": digit = "A"; break;
            case "11": digit = "B"; break;
            case "12": digit = "C"; break;
            case "13": digit = "D"; break;
            case "14": digit = "E"; break;
            case "15": digit = "F"; break;
            default: return digit;
        }
        return digit;
    }
}