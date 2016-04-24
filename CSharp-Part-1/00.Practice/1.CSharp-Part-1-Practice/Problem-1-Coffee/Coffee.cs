using System;
using System.Globalization;

class Coffee
{
    static void Main()
    {
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int n3 = int.Parse(Console.ReadLine());
        int n4 = int.Parse(Console.ReadLine());
        int n5 = int.Parse(Console.ReadLine());
        double insert = double.Parse(Console.ReadLine());
        double price = double.Parse(Console.ReadLine());

        double moneyInMachine = n1 * 0.05 + n2 * 0.1 + n3 * 0.2 + n4 * 0.5 + n5;
        if (insert==price)
        {
            Console.WriteLine("Yes {0:F2}", moneyInMachine);
        }
        if (insert > price)
        {
            if ((insert - price) <= moneyInMachine)
            {
                Console.WriteLine("Yes {0:F2}", moneyInMachine - insert + price );
            }
            else
            {
                Console.WriteLine("No {0:F2}", insert - price - moneyInMachine);
            }
        }
        if (insert < price)
        {
            Console.WriteLine("More {0:F2}", price - insert);
        }
    }
}