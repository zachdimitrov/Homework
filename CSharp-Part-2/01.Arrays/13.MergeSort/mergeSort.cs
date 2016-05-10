using System;
using System.Collections.Generic;
using System.Linq;

class mergeSort
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        int[] sortedArr = MergeSort(arr);
        for (int j = 0; j < arr.Length; j++)
        {
            Console.WriteLine(sortedArr[j]);
        }
    }

    private static int[] MergeSort(int[] arr)
    {
        if (arr.Length <= 1)
        {
            return arr;
        }
        int mid = arr.Length / 2;
        int[] left = new int[mid];
        int[] right = new int[arr.Length - mid];
        Array.Copy(arr, left, mid);
        Array.Copy(arr, mid, right, 0, right.Length);

        left = MergeSort(left);
        right = MergeSort(right);

        return Merge(left, right);
    }

    private static int[] Merge(int[] left, int[] right)
    {
        List<int> leftList = left.OfType<int>().ToList();
        List<int> rightList = right.OfType<int>().ToList();
        List<int> resultList = new List<int>();

        while (leftList.Count > 0 || rightList.Count > 0)
        {
            if (leftList.Count > 0 && rightList.Count > 0)
            {
                if (leftList[0] <= rightList[0])
                {
                    resultList.Add(leftList[0]);
                    leftList.RemoveAt(0);
                }
                else
                {
                    resultList.Add(rightList[0]);
                    rightList.RemoveAt(0);
                }
            }
            else if (leftList.Count > 0)
            {
                resultList.Add(leftList[0]);
                leftList.RemoveAt(0);
            }
            else if (rightList.Count > 0)
            {
                resultList.Add(rightList[0]);
                rightList.RemoveAt(0);
            }
        }
        int[] result = resultList.ToArray();
        return result;
    }
}