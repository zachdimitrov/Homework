using System;

class BinaryShort
{
    static void Main()
    {
        short n = short.Parse(Console.ReadLine());
        FindShortBinary(n);
    }

    private static void FindShortBinary(short num)
    {
        short n = 0;
        string binary = string.Empty;
        if (num < 0 && num > -32768)
        {
            n = Convert.ToInt16(num + 32768);
        }
        else
        {
            n = num;
        }
        if (n == 0)
        {
            Console.WriteLine("0000000000000000");
            return;
        }
        if (n == -32768)
        {
            Console.WriteLine("1000000000000000");
            return;
        }
        while (n > 0)
        {
            if (n == 1)
            {
                binary = n + binary;
                break;
            }
            binary = n % 2 + binary;
            n /= 2;
        }
        binary = binary.PadLeft(16, '0');
        if (num > 0)
        {
            Console.WriteLine(binary);
        }
        else
        {
            char[] binArr = binary.ToCharArray();
            binArr[0] = '1';
            Console.WriteLine(String.Join("", binArr));
        }
    }

    public static string ReverseString(string s)
    {
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
}