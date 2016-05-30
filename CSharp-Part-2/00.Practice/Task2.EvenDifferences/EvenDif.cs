using System;
using System.Linq;
using System.Numerics;

namespace EvenDifferences
{
    class EvenDif
    {
        static void Main()
        {
            long[] seq = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long absDif = 0;
            BigInteger absSum = 0;
            int i = 0;
            while (i <= seq.Length - 2)
            {
                absDif = AbsoluteDifference(seq[i + 1], seq[i]);
                if (absDif % 2 == 0)
                {
                    i = i + 2;
                    absSum += absDif;
                }
                else
                {
                    i++;
                }
            }
            Console.WriteLine(absSum);
        }

        private static long AbsoluteDifference(long v1, long v2)
        {
            long div = 0;
            if (v1 > v2)
            {
                div = v1 - v2;
            }
            else if (v1 < v2)
            {
                div = v2 - v1;
            }
            else
            {
                div = 0;
            }
            return div;
        }
    }
}
