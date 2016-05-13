using System;

class GetLargest
{
    static void Main()
    {
        string[] numbs = Console.ReadLine().Split(' ');
        int a = int.Parse(numbs[0]);
        int b = int.Parse(numbs[1]);
        int c = int.Parse(numbs[2]);
        int n = GetMax(a, b);
        int largest = GetMax(n, c);
        Console.WriteLine(largest);
    }

    static int GetMax(int i, int j)
    {
        if (i > j)
        {
            return i;
        }
        else
        {
            return j;
        }
    }
}
