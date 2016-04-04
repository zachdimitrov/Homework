using System;

class Sumof3Nums
{
    static void Main()
    {
        float a = float.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());
        float c = float.Parse(Console.ReadLine());
        Console.WriteLine("{0}",a+b+c);
    }
}

/*
Input

On the first line, you will receive the number a
On the second line, you will receive the number b
On the third line, you will receive the number c
Output

Your output should consist only of a single line - 
the sum of the three numbers.

Constraints

a, b and c will always be valid real numbers between -1000 and 1000, 
inclusive
Time limit: 0.1s
Memory limit: 8MB
*/