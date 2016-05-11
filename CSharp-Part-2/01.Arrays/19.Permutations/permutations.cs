using System;

class permutations
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 1; i <= arr.Length; i++)
        {
            arr[i - 1] = i;
        }
        GetPer(arr, 0, arr.Length - 1);
    }

    private static void GetPer(int[] arr, int firstIndex, int lastIndex)
    {
        if (firstIndex == lastIndex)
        {
            Console.WriteLine(String.Join(", ", arr));
        }
        else
        {
            for (int i = firstIndex; i <= lastIndex; i++)
            {
                Swap(ref arr[firstIndex], ref arr[i]);
                GetPer(arr, firstIndex + 1, lastIndex);
                Swap(ref arr[firstIndex], ref arr[i]);
            }
        }
    }

    private static void Swap(ref int p1, ref int p2)
    {
        if (p1 == p2)
        {
            return;
        }
        int temp = p1;
        p1 = p2;
        p2 = temp;
    }
}