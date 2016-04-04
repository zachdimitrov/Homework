using System;

class Rectangle
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("{0:F2} {1:F2}", a*b, 2*(a+b));
    }
}

/*
Rectangles
Description

Write an expression that calculates rectangle’s perimeter and area by 
given width and height. The width and height should be read from the console.

Input

The input will consist of 2 lines:
On the first line, you will receive a floating-point number that will 
represent the width of the rectangle.
On the second line, you will receive another floating-point number 
that will represent the height of the rectangle.
Output

Output a single line - the rectangle's perimeter and area, separated 
by a whitespace.
Print the perimeter and area values with exactly 2-digits precision 
after the floating point
Constraints

The width and height will always be valid floating-point numbers.
Time limit: 0.1s
Memory limit: 8MB
Sample tests

Input	Output
3
4	14.00 12.00
2.5
3	11.00 7.50
5
5	20.00 25.00
*/