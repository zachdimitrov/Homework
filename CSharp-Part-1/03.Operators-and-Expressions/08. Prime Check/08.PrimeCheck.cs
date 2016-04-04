using System;

class PrimeCheck
{
    static void Main()
    {
        sbyte N = sbyte.Parse(Console.ReadLine());
        string prime = "true";
        if (N <= 0)
        {
            prime = "false";
        }
        else
        {
            for (int i = 2; i <= Math.Sqrt(N); i++)
            {
                if (N % i == 0)
                {
                    prime = "false";
                }
            }
        }
        Console.WriteLine(prime);
    }
}

/*
Prime check
Description

Write a program that reads an integer N (which will always be less 
than 100 or equal) and uses an expression to check if 
given N is prime (i.e. it is divisible without remainder 
only to itself and 1).

Note: You should check if the number is positive
Input

On the only input line you will receive the number N.
Output

Output true if the number is prime and false otherwise.
Constraints

N will always be a valid 32-bit integer number, 
which will be less than 100 or equal.
Time limit: 0.1s
Memory limit: 8MB
Sample tests

Input	Output
1	false
2	true
23	true
-3	false
0	false
*/