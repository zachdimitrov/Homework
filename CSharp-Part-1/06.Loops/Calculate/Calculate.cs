﻿using System;
using System.Numerics;

class Calculate
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        double X = double.Parse(Console.ReadLine());
        double S = 1;
        int fac = 1;
        double mul = 1;
        for (int i = 1; i <= N; i++)
        {
            mul = mul * X;
            fac = (fac * i);
            S = S + fac / mul;
        }
        Console.WriteLine("{0:F5}", S);
    }
}