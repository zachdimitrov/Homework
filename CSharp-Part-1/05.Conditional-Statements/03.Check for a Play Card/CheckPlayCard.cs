using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CheckPlayCard
{
    static void Main()
    {
        string[] card = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        string input = Console.ReadLine();
        string test = "no";
        for (int i = 0; i < card.Length; i++)
        {
            if (input == card[i])
            {
                test = "yes";
            }
        }
        Console.WriteLine(test + " " + input);
    }
}