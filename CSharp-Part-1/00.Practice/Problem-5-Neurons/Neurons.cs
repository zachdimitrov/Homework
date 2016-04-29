using System;

class Neurons
{
    static void Main()
    {
        uint[] n = new uint[32];
        uint[] nNew = new uint[32];
        int i = 0;
        while (true)
        {
            long number = long.Parse(Console.ReadLine());
            if (number == -1)
            {
                break;
            }
            n[i] = (uint)(number);
            if (n[i] > 0)
            {
                int ones = 0;
                int leftPos = 0;
                int rightPos = 0;
                for (int bit = 0; bit < 32; ++bit)
                {
                    uint test = n[i] >> bit & 1;
                    if (test == 1)
                    {
                        if (ones == 0)
                        {
                            rightPos = bit;
                        }
                        ones++;
                        leftPos = bit;
                    }
                }
                if (leftPos - rightPos + 1 == ones)
                {
                    nNew[i] = 0;
                }
                else
                {
                    uint temp = n[i];
                    for (int p = rightPos; p <= leftPos; p++)
                    {
                        int mask = 1 << p;
                        temp = temp ^ (uint)mask;
                    }
                    nNew[i] = temp;
                }
            }
            i++;
        }
        for (int j = 0; j < i; j++)
        {
            Console.WriteLine(nNew[j]);
        }
        //Console.WriteLine(new string('_', 32));
        //for (int d = 0; d < i - 1; d++)
        //{
        //    Console.WriteLine(Convert.ToString(n[d], 2).PadLeft(32, '0'));
        //}
        //Console.WriteLine(new string('_', 32));
        //for (int k = 0; k < i - 1; k++)
        //{
        //    Console.WriteLine(Convert.ToString(nNew[k], 2).PadLeft(32, '0'));
        //}
    }
}
