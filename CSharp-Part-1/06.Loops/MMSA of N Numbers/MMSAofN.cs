using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MMSAofN
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] numbers = new int[N];
        for (int i = 0; i < N; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("min={0}", numbers.Min());
        Console.WriteLine("max={0}", numbers.Max());
        Console.WriteLine("sum={0}", numbers.Sum());
        Console.WriteLine("avg={0:F2}", numbers.Average());
    }
}
