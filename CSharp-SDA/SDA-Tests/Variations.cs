namespace DSA
{
    public static class Variations
    {
        // calculate number of variations
        public static long Calculate(int k, int n)
        {
            long total = 1;
            for (int i = 0; i < k; i++)
            {
                total*=n;
            }
            return total;
        }

        // generate variations
        public static long Generate(int k, int n)
        {
            if (k == 0)
            {
                return 1;
            }

            long total = 0;
            for (int i = 0; i < n; i++)
            {
                total += Calculate(k - 1, n);
            }

            return total;
        }
    }
}