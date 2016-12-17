namespace DSA
{
    using System.Collections.Generic;
    public static class Permutation
    {
        public static void Calculate(int n, List<int> isAvailable, List<int> permutation)
        {
            if (permutation.Count == n)
            {
                System.Console.WriteLine(string.Join(" ", permutation));
                return;
            }

            for (int i = 1; i <= isAvailable.Count; i++)
            {
                if (isAvailable[i - 1] == 0)
                {
                    continue;
                }

                permutation.Add(i);
                isAvailable[i - 1]--;
                Calculate(n, isAvailable, permutation);
                isAvailable[i - 1]++;
                permutation.RemoveAt(permutation.Count - 1);
            }
        }

        public static bool Iterate(int[] permutation)
        {
            int i = permutation.Length - 1;
            while (i > 0)
            {
                if (permutation[i - 1] < permutation[i])
                {
                    break;
                }
                i--;
            }

            if(i == 0)
            {
                return false;
            }

            for (int j = permutation.Length - 1; ; j--)
            {
                if (permutation[j] > permutation[i - 1])
                {
                    int k = permutation[j];
                    permutation[j] = permutation[i - 1];
                    permutation[i - 1] = k;
                    break;
                }
            }

            for (int j = permutation.Length - 1; i < j; j--, i++)
            {
                int k = permutation[j];
                permutation[j] = permutation[i];
                permutation[i] = k;
            }

            return true;
        }
    }
}