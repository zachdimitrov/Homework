using System;

class Program
{
    static void Main()
    {
        int tomSeed = int.Parse(Console.ReadLine());
        int tomArea = int.Parse(Console.ReadLine());
        int cucSeed = int.Parse(Console.ReadLine());
        int cucArea = int.Parse(Console.ReadLine());
        int potSeed = int.Parse(Console.ReadLine());
        int potArea = int.Parse(Console.ReadLine());
        int carSeed = int.Parse(Console.ReadLine());
        int carArea = int.Parse(Console.ReadLine());
        int cabSeed = int.Parse(Console.ReadLine());
        int cabArea = int.Parse(Console.ReadLine());
        int beanSeed = int.Parse(Console.ReadLine());

        int totalArea = 250;

        const double tomCost = 0.5;
        const double cucCost = 0.4;
        const double potCost = 0.25;
        const double carCost = 0.6;
        const double cabCost = 0.3;
        const double beanCost = 0.4;

        int beanArea = totalArea - (tomArea + cucArea + potArea + carArea + cabArea);
        double totalCost = tomSeed * tomCost + cucSeed * cucCost + potSeed * potCost + carSeed * carCost + cabSeed * cabCost + beanSeed * beanCost;
        if (beanArea < 0)
        { 
            Console.WriteLine("Total costs: {0:F2}", totalCost);
            Console.WriteLine("Insufficient area");
        }
        else if (beanArea == 0)
        {
            Console.WriteLine("Total costs: {0:F2}", totalCost);
            Console.WriteLine("No area for beans");
        }
        else
        {
            Console.WriteLine("Total costs: {0:F2}", totalCost);
            Console.WriteLine("Beans area: {0}", beanArea);
        }
    }
}