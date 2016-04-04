using System;

class Trapezoid
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());
        double area = ((a + b)*0.5) * h;
        Console.WriteLine("{0:F7}", area);
    }
}

/*
Trapezoids
Description

Write an expression that calculates trapezoid's area by given
sides a and b and height h. The three values should be read from
the console in the order shown below. All three value will be 
floating-point numbers.

Input

The input will consist of exactly 3 lines:
The side a on the first line.
The side b on the second line.
The height h on the third line.
Output

Output a single line containing a single value - the area of the trapezoid. 
Output the area with exactly 7-digit precision after the floating point.
Constraints

All numbers will always be valid floating-point numbers in the range [-500, 500].
Time limit: 0.1s
Memory limit: 8MB
Sample tests

Input	Output
5
7
12	72.0000000
2
1
33	49.5000000
8.5
4.3
2.7	17.2800000
*/