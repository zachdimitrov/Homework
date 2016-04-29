using System;

class ThreeNumbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int biggest = 0;
        int smallest = 0;
        if (a >= b && a >= c && b >= c)
        {
            biggest = a;
            smallest = c;
        }
        else if (a >= b && a >= c && c >= b)
        {
            biggest = a;
            smallest = b;
        }
        else if (b >= a && b >= c && c >= a)
        {
            biggest = b;
            smallest = a;
        }
        else if (b >= a && b >= c && a >= c)
        {
            biggest = b;
            smallest = c;
        }
        else if (c >= a && c >= b && a >= b)
        {
            biggest = c;
            smallest = b;
        }
        else if (c >= a && c >= b && b >= a)
        {
            biggest = c;
            smallest = a;
        }
        Console.WriteLine(biggest);
        Console.WriteLine(smallest);
        Console.WriteLine("{0:F2}", (double)(a+b+c)/3);
    }
}
