using System;

class DrunkenNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int vBeers = 0;
        int numOfChars = 0;
        int mBeers = 0;
        string drunkNum = "";
        for (int i = 0; i < n; i++)
        {
            drunkNum = Convert.ToString(Math.Abs(int.Parse(Console.ReadLine())));
            if (drunkNum == "")
            {
                drunkNum = "0";
            }
            numOfChars = drunkNum.Length / 2;
            if (drunkNum.Length % 2 != 0)
            {
                for (int j = 0; j <= numOfChars; j++)
                {
                    mBeers += int.Parse(drunkNum[j] + "");
                }
                for (int k = drunkNum.Length - 1; k > numOfChars - 1; k--)
                {
                    vBeers += int.Parse(drunkNum[k] + "");
                }
            }
            else
            {
                for (int j = 0; j < numOfChars; j++)
                {
                    mBeers += int.Parse(drunkNum[j] + "");
                }
                for (int k = drunkNum.Length - 1; k > numOfChars - 1; k--)
                {
                    vBeers += int.Parse(drunkNum[k] + "");
                }
            }
        }
        if (vBeers>mBeers)
        {
            Console.WriteLine("V {0}", vBeers-mBeers);
        }
        else if (mBeers>vBeers)
        {
            Console.WriteLine("M {0}", mBeers-vBeers);
        }
        else
        {
            Console.WriteLine("No {0}", mBeers*2);
        }
    }
}