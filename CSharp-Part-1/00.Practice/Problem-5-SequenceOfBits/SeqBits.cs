using System;

class SeqBits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int zeroCount = 0;
        int maxZeroCount = 0;
        int oneCount = 0;
        int maxOneCount = 0;
        int last30bits = 0;
        string s = "";
        for (int j = 0; j < n; j++)
        {
            int num = int.Parse(Console.ReadLine());
            int mask = ~(-1 << 30);
            last30bits = num & mask;
            s += Convert.ToString(last30bits, 2).PadLeft(30, '0');
            last30bits = 0;
        }
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '1')
            {
                oneCount++;
                zeroCount = 0;
            }
            else
            {
                zeroCount++;
                oneCount = 0;
            }
            if (oneCount > maxOneCount)
            {
                maxOneCount = oneCount;
            }
            if (zeroCount > maxZeroCount)
            {
                maxZeroCount = zeroCount;
            }
        }
        Console.WriteLine(maxOneCount);
        Console.WriteLine(maxZeroCount);
    }
}