using System;

class BitXchange
{
    static void Main()
    {
        uint N = uint.Parse(Console.ReadLine());
        N = findNth(24, N, 3);
        N = findNth(25, N, 4);
        N = findNth(26, N, 5);
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
BitExchange
Description

Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 
of given 32-bit unsigned integer(read from the console).

Input

On the only input line you will receive the unsigned integer 
number whose bits you must exchange.
Output

On the only output line print the value of the integer 
with the exchanged bits.
Constraints

N will always be a valid 32-bit unsigned integer.
Time limit: 0.1s
Memory limit: 8MB
Sample tests

  Input			
1140867093	
  Binary representation
01000100 00000000 01000000 00010101	
  Binary representation after exchange
01000010 00000000 01000000 00100101	
  Output
1107312677
*/