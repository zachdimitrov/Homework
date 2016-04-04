using System;

class ThirdBit
{
    static void Main()
    {
        uint N = uint.Parse(Console.ReadLine());
        uint M = (uint)(Math.Floor(N * 0.01));
        uint thirdDigit = M % 10;
        if (thirdDigit==7)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false {0}", thirdDigit);
        }
    }
}

/*
Third digit
Description

Write a program that reads an integer N from the console and prints true
if the third digit of the N is 7, or "false THIRD_DIGIT", 
where you should print the third digits of N.

The counting is done from right to left, meaning 123456's third digit is 4.
Input

The input will always consist of exactly one line, containing the number N.
Output

The output should be a single line - print whether the third digit is 7, 
following the format described above.
Constraints

N will always be valid non-negativ integer number.
Time limit: 0.1s
Memory limit: 8MB
Sample tests

Input	Output
5	false 0
701	true
9703	true
877	false 8
777877	false 8
9999799	true
*/