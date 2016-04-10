﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class HexToDec
{
    static void Main()
    {
        string hexString = Console.ReadLine();
        char[] signs = hexString.ToCharArray();
        long hexNum = new long();
        long result = 0;
        long k = 1;
        Array.Reverse(signs);
        for (long i = 0; i < signs.Length; i++)
        {
            string hex = Char.ToString(signs[i]);
            switch (hex)
            {
                case "A": hexNum = 10;
                    break;
                case "B": hexNum = 11;
                    break;
                case "C": hexNum = 12;
                    break;
                case "D": hexNum = 13;
                    break;
                case "E": hexNum = 14;
                    break;
                case "F": hexNum = 15;
                    break;
                default: hexNum = long.Parse(hex);
                    break;
            }
            result += hexNum * k;
            k *= 16;
        }
        Console.WriteLine(result);
    }
}
