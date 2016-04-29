using System;

class Printing
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int S = int.Parse(Console.ReadLine());
        double P = double.Parse(Console.ReadLine());
        int usedSheets = N * S;
        double savedMoney = Math.Round(((usedSheets*0.002) * P), 2);
        Console.WriteLine("{0:F2}", savedMoney);
    }
}
