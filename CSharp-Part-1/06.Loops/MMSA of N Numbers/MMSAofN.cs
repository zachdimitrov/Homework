using System;
using System.Linq;

class MMSAofN
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        double[] numbers = new double[N];
        for (int i = 0; i < N; i++)
        {
            numbers[i] = double.Parse(Console.ReadLine());
        }
        Console.WriteLine("min={0:F2}", numbers.Min());
        Console.WriteLine("max={0:F2}", numbers.Max());
        Console.WriteLine("sum={0:F2}", numbers.Sum());
        Console.WriteLine("avg={0:F2}", numbers.Average());
    }
}
