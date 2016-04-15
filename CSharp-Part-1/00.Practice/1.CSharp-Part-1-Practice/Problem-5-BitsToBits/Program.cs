using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        uint N = uint.Parse(Console.ReadLine());
        int last = 30;
        string lastBits = "";
        string zeroes = "0";
        int zeroNum = 0;
        string ones = "1";
        int oneNum = 0;
        for (int i = 0; i < N; i++)
        {
            uint A = uint.Parse(Console.ReadLine());
            uint number = (uint)(A & ((1 << last) - 1));
            lastBits += Convert.ToString(number, 2).PadLeft(30, '0');
        }
        for (int i = 1; i < lastBits.Length; i++)
        {
            if (lastBits[i] == lastBits[i - 1] && lastBits[i] == '0')
            {
                zeroes += lastBits[i];
            }
            else
            {
                zeroes = "0";
            }
            if (zeroes.Length > zeroNum)
            {
                zeroNum = zeroes.Length;
            }
            if (lastBits[i] == lastBits[i - 1] && lastBits[i] == '1')
            {
                ones += lastBits[i];
            }
            else
            {
                ones = "0";
            }
            if (ones.Length > oneNum)
            {
                oneNum = ones.Length;
            }
        }
        Console.WriteLine(zeroNum);
        Console.WriteLine(oneNum);
    }
}