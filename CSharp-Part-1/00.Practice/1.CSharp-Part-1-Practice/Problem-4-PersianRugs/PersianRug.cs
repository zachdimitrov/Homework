using System;

class PersianRug
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.Write(new string('#', i));
            Console.Write('\\');
            if (d <= n - 2 && 2 * n - 2 * d - 2 * i - 3 > 0)
            {
                Console.Write(new string(' ', d));
                Console.Write('\\');
                Console.Write(new string('.', 2 * n - 2 * d - 2 * i - 3));
                Console.Write('/');
                Console.Write(new string(' ', d));
            }
            else
            {
                Console.Write(new string(' ', 2 * n - 2 * i - 1));
            }
            Console.Write('/');
            Console.WriteLine(new string('#', i));
        }
        Console.Write(new string('#', n));
        Console.Write('X');
        Console.WriteLine(new string('#', n));
        for (int i = n-1; i >= 0; i--)
        {
            Console.Write(new string('#', i));
            Console.Write('/');
            if (d <= n - 2 && 2 * n - 2 * d - 2 * i - 3 > 0)
            {
                Console.Write(new string(' ', d));
                Console.Write('/');
                Console.Write(new string('.', 2 * n - 2 * d - 2 * i - 3));
                Console.Write('\\');
                Console.Write(new string(' ', d));
            }
            else
            {
                Console.Write(new string(' ', 2 * n - 2 * i - 1));
            }
            Console.Write('\\');
            Console.WriteLine(new string('#', i));
        }
    }
}