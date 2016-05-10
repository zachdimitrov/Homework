using System;

class freqNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int count = 1;
        int finalCount = 1;
        int repeated = new int();
        int finalRepeated = new int();
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        for (int j = 0; j < arr.Length; j++)
        {
            repeated = arr[j];
            count = 1;
            for (int k = 0; k < arr.Length; k++)
            {
                if (k != j && arr[k] == repeated)
                {
                    count++;
                    if (count > finalCount)
                    {
                        finalCount = count;
                        finalRepeated = repeated;
                    }
                }
            }
        }
        Console.WriteLine("{0} ({1} times)", finalRepeated, finalCount);
    }
}