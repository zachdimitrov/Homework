using System;

class ReverseNumber
{
    static void Main()
    {
        string n = Console.ReadLine();
        Console.WriteLine(ReverseString(n));
    }

    private static string ReverseString(string s)
    {
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
}