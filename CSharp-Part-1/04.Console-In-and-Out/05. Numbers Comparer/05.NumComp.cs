using System;

class NumComp
{
    static void Main()
    {
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
        bool greater = A >= B;
        Console.WriteLine(greater?A:B);
    }
}

/*
Number Comparer
Description

Write a program that gets two numbers from the console and prints 
the greater of them.

Input

On the first two lines you will receive the two numbers, A and B
Output

On the only line print the larger of the two numbers
*Try implementing it without using if-statements ## Constraints
The input will always be valid and in the described format.
The numbers A and B will always be valid real number
Time limit: 0.1s
Memory limit: 8MB
*/
