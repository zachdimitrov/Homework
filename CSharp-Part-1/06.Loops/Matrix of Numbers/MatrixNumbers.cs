using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MatrixNumbers
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        string line = "";
        for (int i = 1; i <= N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                line = line + (i + j);
            }
            Console.WriteLine(line);
            line = "";
        }
    }
}
