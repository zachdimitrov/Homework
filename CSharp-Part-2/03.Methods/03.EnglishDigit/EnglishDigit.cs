using System;

class EnglishDigit
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(EngDigit(n));
    }

    private static string EngDigit(int n)
    {
        int last = n % 10;
        string p = string.Empty;
        switch (last)
        {
            case 0: p = "zero";
                break;
            case 1: p = "one";
                break;
            case 2: p = "two";
                break;
            case 3: p = "three";
                break;
            case 4: p = "four";
                break;
            case 5: p = "five";
                break;
            case 6: p = "six";
                break;
            case 7: p = "seven";
                break;
            case 8: p = "eight";
                break;
            case 9: p = "nine";
                break;
        }
        return p;
    }
}