using System;

class Squirrels
{
    static void Main()
    {
        double t = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double s = double.Parse(Console.ReadLine());
        double n = double.Parse(Console.ReadLine());
        double result = 0;

        double tails = t * b * s * n;
        if (tails % 2 == 0)
        {
            result = (double)tails * 376439;
        }
        else
        {
            result = ((double)tails / 7);
        }
        Console.WriteLine("{0:F3}", result);
    }
}