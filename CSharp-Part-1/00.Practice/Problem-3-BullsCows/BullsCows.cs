using System;

class BullsCows
{
    static void Main()
    {
        string s = Console.ReadLine();
        int bulls = int.Parse(Console.ReadLine());
        int cows = int.Parse(Console.ReadLine());
        int bullsTest = 0;
        int cowTest = 0;
        string result = "";
        char[] secret = new char[4];
        char[] guess = new char[4];
        for (int i = 1111; i <= 9999; i++)
        {
            string g = Convert.ToString(i);
            for (int z = 0; z < 4; z++)
            {
                secret[z] = s[z];
                guess[z] = g[z];
            }
            for (int w = 0; w < 4; w++)
            {
                if (guess[w] == secret[w])
                {
                    bullsTest++; guess[w] = '@'; secret[w] = '#';
                }
            }
            for (int j = 0; j < 4; j++)
            {
                for (int h = 0; h < 4; h++)
                {
                    if (guess[j] == secret[h]) { cowTest++; secret[h] = '%'; guess[j] = '^'; }
                }
            }
            if (cowTest == cows && bullsTest == bulls && guess[0] != '0' && guess[1] != '0' && guess[2] != '0' && guess[3] != '0')
            {
                result += Convert.ToString(i) + " ";
            }
            cowTest = 0;
            bullsTest = 0;
        }
        if (result != "")
        {
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}