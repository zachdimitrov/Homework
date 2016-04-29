using System;

class Conductor
{
    static void Main()
    {
        int p = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int ticket = 0;
        int test = 0;
        int testTicket = 0;
        int dig = Convert.ToString(p, 2).Length;
        for (int i = 0; i < m; i++)
        {
            ticket = int.Parse(Console.ReadLine());
            for (int j = 0; j < 32 - dig; j++)
            {
                testTicket = ticket >> j;
                for (int k = 0; k < dig; k++)
                {
                    int mask = (p >> k) & 1;
                    if (((testTicket >> k) & 1) == mask) { test++; }
                }
                if (test == dig)
                {
                    for (int pp = j; pp < j + dig; pp++)
                    {
                        int zero = ~(1 << pp);
                        ticket = (int)(ticket & zero);
                    }
                }
                test = 0;
            }
            Console.WriteLine(ticket);
        }
    }
}
