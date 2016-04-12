﻿using System;

class QuadEquasion
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = (b * b) - (4 * a * c);
        if (d<0)
        {
            Console.WriteLine("no real roots");
        }
        else if (d==0)
        {
            Console.WriteLine("{0:0.00}", -b / (2 * a)); 
        }
        else if (d>0)
        {
            double x1 = (-b + Math.Sqrt(d)) / (2 * a);
            double x2 = (-b - Math.Sqrt(d)) / (2 * a);
            if (x1<x2)
            {
                Console.WriteLine("{0:0.00}", x1);
                Console.WriteLine("{0:0.00}", x2);
            }
            else
            {
                Console.WriteLine("{0:0.00}", x2);
                Console.WriteLine("{0:0.00}", x1);
            }
        }
    }
}

/*
Quadratic Equation
Description

Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).

Input

On the first three lines, you will receive the coefficients a, b, and c, each on a separate line in the same order
Output

If two different real roots exist, print them on two separate lines
Print the smaller root on the first line
If only one real root exists, print it on the only output line
If no real root exists, print the string "no real roots"
The roots, should they exist, must be printed with precision exactly two digits after the floating point
Constraints

The input will always consist of valid real numbers in the rande [-1000, 1000] and will follow the described format
Time limit: 0.1s
Memory limit: 8MB
*/
