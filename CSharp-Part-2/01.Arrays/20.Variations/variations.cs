using System;
using System.Collections.Generic;

class variations
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int k = int.Parse(Console.ReadLine());
        for (int i = 1; i <= arr.Length; i++)
        {
            arr[i - 1] = i;
        }
        List<List<int>> list = GetVariations(k, arr);
        foreach (List<int> sublist in list)
        {
            Console.WriteLine(String.Join(", ", sublist));
        }
    }

    private static List<List<int>> GetVariations(int k, int[] arr)
    {
        List<List<int>> result = new List<List<int>>();
        List<int> elements = new List<int>();
        if (k == 1)
	    {
		    for (int i = 0; i < arr.Length; i++)
			{
                elements.Add(arr[i]);
                result.Add(elements);
                elements.Clear();
			} 
	    }
        return result;
    }
}