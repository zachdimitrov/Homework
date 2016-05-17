using System;

class DecimalToBinary
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        PrintBunary(n);
    }

    private static void PrintBunary(long n)
    {
        string binary = string.Empty;
        if (n == 0)
        {
            Console.WriteLine("0");
            return;
        }
        while (n > 0)
        {
            if (n == 1)
            {
                binary += n;
                break;
            }
            binary += n % 2;
            n /= 2;
        }
        Console.WriteLine(ReverseString(binary));
    }

    public static string ReverseString(string s)
    {
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
}