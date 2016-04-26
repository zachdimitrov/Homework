using System;

class Money
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int s = int.Parse(Console.ReadLine());
        double p = double.Parse(Console.ReadLine());
        double price = (n * s) * (p / 400);
        Console.WriteLine("{0:F3}", price);
    }
}
