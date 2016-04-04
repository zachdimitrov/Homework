using System;

class PointCircTriang
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        string circleTest = "inside circle";
        string rectTest = "inside rectangle";
        double r = Math.Sqrt((x-1) * (x-1) + (y-1) * (y-1));
        if (r>1.5)
        {
            circleTest = "outside circle";
        }
        if (x<-1||x>5||y<-1||y>1)
        {
            rectTest = "outside rectangle";
        }
        Console.WriteLine(circleTest+" "+rectTest);
    }
}

/*
Point, Circle, Rectangle
Description

Write a program that reads a pair of coordinates x and y 
and uses an expression to checks for given point (x, y) 
if it is within the circle K({1, 1}, 1.5) and out of the 
rectangle R(top=1, left=-1, width=6, height=2).

Input

You will receive the pair of coordinates on the two lines of 
the input - on the first line you will find x, and on the second - y.
Output

Print inside circle if the point is inside the circle and outside 
circle if it's outside. Then print a single whitespace followed by 
inside rectangle if the point is inside the rectangle and outside 
rectangle otherwise. See the sample tests for a visual description.
Constraints

The coordinates x and y will always be valid floating-point numbers
in the range [-1000, 1000].
Time limit: 0.1s
Memory limit: 8MB
Sample tests

Input	Output
1
2	yes
2.5
2	no
0
1	no
2.5
1	no
*/