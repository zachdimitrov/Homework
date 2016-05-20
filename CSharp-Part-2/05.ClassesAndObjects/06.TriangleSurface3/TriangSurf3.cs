using System;

class TriangSurf3
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double ang = double.Parse(Console.ReadLine());
        double rad = ang * (Math.PI / 180);
        Console.WriteLine("{0:F2}", (a*b)*Math.Sin(rad)/2);
    }
}