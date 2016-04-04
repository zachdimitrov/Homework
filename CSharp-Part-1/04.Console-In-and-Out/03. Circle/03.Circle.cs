using System;

class Circle
{
    static void Main()
    {
        double radius = double.Parse(Console.ReadLine());
        double perimeter = 2 * Math.PI * radius;
        double area = Math.PI * radius * radius;
        Console.WriteLine("{0:F2} {1:F2}", perimeter, area);
    }
}

/*
Circle
Description

Write a program that reads from the console the radius r of a circle 
and prints its perimeter and area, rounded and formatted 
with 2 digits after the decimal point.

Input

On the only line of the input you will receive the radius of the 
circle - r
Output

You should print one line only: the perimeter and the area of 
the circle, separated by a whitespace, and with 2 digits precision
Constraints

The radius r will always be a valid and positiv real number
Time limit: 0.1s
Memory limit: 8MB
*/
