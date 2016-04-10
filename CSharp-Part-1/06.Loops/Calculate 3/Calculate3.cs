using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Calculate3
{
    static void Main()
    {
        double N = double.Parse(Console.ReadLine());
        double K = double.Parse(Console.ReadLine());
        double factN = 1;
        double factK = 1;
        double factSum = 1;
        double subs = N - K;
        double result = new double();
        if (K > 1 && N > K && N < 100)
        {
            while (true)
            {
                if (N == 1 && K == 1 && subs == 1)
                {
                    break;
                }
                if (N > 1)
                {
                    factN *= N;
                    N--;
                }
                if (K > 1)
                {
                    factK *= K;
                    K--;
                }
                if (subs > 1)
                {
                    factSum *= subs;
                    subs--;
                }
            }
            // Console.WriteLine(factN);
            // Console.WriteLine(factK);
            // Console.WriteLine(factSum);
            result = factN / (factK * (factSum));
            Console.WriteLine(result);
        }
    }
}
