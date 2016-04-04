using System;

class Interval
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int M = int.Parse(Console.ReadLine());
        int result = 0;
        for (int i = N+1; i < M; i++)
        {
            if (i%5==0)
            {
                result++;
            }
        }
        Console.WriteLine(result);
    }
}

/*
Interval
Description

Write a program that reads two positive integer numbers N and M 
and prints how many numbers exist between them such that the reminder of the division by 5 is 0.
Input

On the first two lines you will receive two integers - N on the first and M on the second.
Output

Output a single value - the amount of numbers divisible by 5 without remainder.
Constraints

0 <= N <= M <= 2000
Time limit: 0.1s
Memory limit: 8MB
*/
