﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class From1ToN
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        string print = "";
        for (int i = 1; i <=N; i++)
        {
            print = print + i + " ";
        }
        Console.WriteLine(print);
    }
}
