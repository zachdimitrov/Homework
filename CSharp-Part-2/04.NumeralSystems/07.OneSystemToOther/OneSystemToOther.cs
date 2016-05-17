using System;

class OneSystemToOther
{
    static void Main()
    {
        int s = int.Parse(Console.ReadLine());
        string sNum = Console.ReadLine();
        int d = int.Parse(Console.ReadLine());
        Console.WriteLine(BaseConvert(s, sNum, d));
    }

    private static string BaseConvert(int s, string sNum, int d)
    {
        string dNum = string.Empty;
        long dec = 0;
        int index = sNum.Length - 1;
        long mul = 1;
        for (int i = 0; i < sNum.Length; i++)
        {
            int digit = ConvHexDigit(sNum[index]);
            dec += digit * mul;
            mul *= s;
            index--;
        }
        while (dec > 0)
        {
            string digit = string.Empty;
            if (dec < d)
            {
                digit = Convert.ToString(dec);
            }
            else
            {

                digit = Convert.ToString(dec % d);
            }
            digit = CheckDigit(digit);
            dNum = digit + dNum;
            dec = dec / d;
        }
        return dNum;
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
