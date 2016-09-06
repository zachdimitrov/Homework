namespace Squirrels
{
    using System;

    class Squirrels
    {
        static void Main()
        {
            const int evenMultiplier = 376439;
            const int oddMultiplier = 7;

            double trees = double.Parse(Console.ReadLine());
            double branches = double.Parse(Console.ReadLine());
            double squirrels = double.Parse(Console.ReadLine());
            double tails = double.Parse(Console.ReadLine());
            double result = 0;

            double totalTails = trees * branches * squirrels * tails;

            if (tails % 2 == 0)
            {
                result = (double)totalTails * evenMultiplier;
            }
            else
            {
                result = ((double)totalTails / oddMultiplier);
            }

            Console.WriteLine("{0:F3}", result);
        }
    }
}