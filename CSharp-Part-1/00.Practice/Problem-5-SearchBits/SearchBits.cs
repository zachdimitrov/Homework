using System;

class SearchBits
{
    static void Main()
    {
        uint s = uint.Parse(Console.ReadLine());
        uint n = uint.Parse(Console.ReadLine());
        uint count = 0;
        int test = 0;
        uint testNumber = 0;
        for (int i = 0; i < n; i++)
        {
            uint number = uint.Parse(Console.ReadLine());
            for (int j = 0; j < 27; j++)
			{
                testNumber = number >> j;
                for (int k = 0; k < 4; k++)
                {
                    uint mask = (s >> k) & 1;
                    if (((testNumber >> k) & 1) == mask) { test++; }
                }
                if (test == 4) { count++; }
                test = 0;
			}
        }
        Console.WriteLine(count);
    }
}