using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NotDivNumb
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        string print = "";
        for (int i = 1; i <= N; i++)
        {
            if (i % 3 != 0 && i % 7 != 0)
            {
                print = print + i + " ";
            }
        }
        Console.WriteLine(print);
    }
}
