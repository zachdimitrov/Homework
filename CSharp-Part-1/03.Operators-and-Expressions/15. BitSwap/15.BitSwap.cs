using System;

class BitSwap
{
    static void Main()
    {
        uint N = uint.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int q = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        for (int i = 0; i < k; i++)
        {
            N = findNth(q+i, N, p+i);
        }
        Console.WriteLine(N);
    }
    static uint findNth(int p, uint n, int r)
    {
        uint mask = (uint)1 << p;
        uint test = n & mask;
        uint v = test >> p;

        mask = (uint)1 << r;
        test = n & mask;
        uint w = test >> r;

        if (v != w)
        {
            if (v == 0)
            {
                uint mask1 = (uint)~(1 << r);
                n = n & mask1;
                mask1 = (uint)1 << p;
                return n | mask1;
            }
            else if (v == 1)
            {
                uint mask1 = (uint)1 << r;
                n = n | mask1;
                mask1 = (uint)~(1 << p);
                return n & mask1;
            }
            else { return n; }
        }
        else { return n; }
    }
}

/*
BitSwap
Description

Write a program first reads 3 numbers n, p, q and k and than 
swaps bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of n. 
Print the resulting integer on the console.

Input

On the only four lines of the input you will receive the 
integers n, p, q and k in this order.
Output

Output a single value - the value of n after the bit swaps.
Constraints

The first and the second sequence of bits will never overlap.
n will always be a valid 32-bit positive integer.
Time limit: 0.1s
Memory limit: 8MB
Sample tests

   Input			
1140867093
3
24
3
 * Binary representation
01000100 00000000 01000000 00010101
 * Binary representation after swaps
01000010 00000000 01000000 00100101	
 * Output
1107312677
*/