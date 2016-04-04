using System;

class NthBit
{
    static void Main()
    {
        int P = int.Parse(Console.ReadLine());
        byte N = byte.Parse(Console.ReadLine());
        int mask = 1 << N;
        int test = (P & mask);
        int result = test >> N;
        Console.WriteLine(result);
    }
}

/*
N-th Bit
Description

Write a program that reads from the console two integer numbers P 
and N and prints on the console the value of P's N-th bit.

Input

On the first line you will receive the number P. On the second 
line you will receive the number N.
Output

Output a single value - the value of the N-th bit in P.
Constraints

N will be a positiv integer and always smaller than 55.
P will always be in the range [0, 2<sup>55</sup>).
Time limit: 0.1s
Memory limit: 8MB
Sample tests

Input	Binary representation	Output
5
2	00000000 00000101	1
0
9	00000000 00000000	0
15
1	00000000 00001111	1
5343
7	00010100 11011111	1
62241
11	11110011 00100001	0
*/