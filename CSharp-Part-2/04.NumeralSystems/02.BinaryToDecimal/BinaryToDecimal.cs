using System;

class BinaryToDecimal
{
    static void Main()
    {
        string n = Console.ReadLine();
        DecimalFromBinary(n);
    }

    private static void DecimalFromBinary(string n)
    {
        long dec = 0;
        int index = n.Length - 1;
        long mul = 1;
        for (int i = 0; i < n.Length; i++)
        {
            dec += long.Parse(Convert.ToString(n[index])) * mul;
            index -= 1;
            mul *= 2;
        }
        Console.WriteLine(dec);
    }
}