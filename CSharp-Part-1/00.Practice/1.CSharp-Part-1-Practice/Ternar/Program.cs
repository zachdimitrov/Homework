using System;

class Program
{
    static void Main()
    {
        int number = Math.Abs(int.Parse(Console.ReadLine()));
        int n = number / 100;
        {
            Console.WriteLine(n % 10 == 7 ? "true " + n : "false {0} ", n % 10);
        }
    }
}