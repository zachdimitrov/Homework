using System.Collections.Generic;

namespace DSA
{
    public static class Combination
    {
        public static void Calculate(int n, int k, List<int> combination)
        {
            if (combination.Count == k)
            {
                System.Console.WriteLine(string.Join(" ", combination));
                return;
            }

            int first = 1;
            if (combination.Count > 0)
            {
                first = combination[combination.Count-1] + 1;
            }

            for (int i = first; i <= n; i++)
            {
                combination.Add(i);
                Calculate(n, k, combination);
                combination.RemoveAt(combination.Count - 1);
            }
        }
    }
}