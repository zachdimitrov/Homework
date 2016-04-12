using System;

class CalcAgain
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int K = int.Parse(Console.ReadLine());
        int factN = 1;
        int factK = 1;
        while (true)
        {
            if (N==1 && K==1)
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
        }
        Console.WriteLine(factN / factK);
    }
}
