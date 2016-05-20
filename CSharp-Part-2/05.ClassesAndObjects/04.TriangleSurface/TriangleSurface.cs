using System;

class TriangleSurface
{
    static void Main()
    {
        double side = double.Parse(Console.ReadLine());
        double alt = double.Parse(Console.ReadLine());
        Console.WriteLine("{0:F2}", side*alt*0.5);
    }
}