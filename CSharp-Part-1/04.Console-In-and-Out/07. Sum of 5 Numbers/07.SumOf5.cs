using System;

class Sumof5Nums
{
    static void Main()
    {
        int n=0;
        double sum = 0;
        double x = 0;
        while (n<5)
        {
            x = double.Parse(Console.ReadLine());
            sum += x;
            n++;
        }
        Console.WriteLine(sum);
    }
}

/*
Sum of 5 numbers
Description

Write a program that reads 5 integer numbers from the console and prints their sum.

Input

You will receive 5 numbers on five separate lines.

Output

Your output should consist only of a single line - the sum of the 5 numbers.

Constraints

All 5 numbers will always be valid integer numbers between -1000 and 1000, inclusive
Time limit: 0.1s
Memory limit: 16MB
*/