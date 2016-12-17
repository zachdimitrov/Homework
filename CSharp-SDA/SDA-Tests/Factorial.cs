namespace DSA
{
    public static class Factorial
    {
        // Factorial using recursion

        public static long WithRecursion(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * WithRecursion(n - 1);
        }

        // Factorial using loops

        public static long WithLoop(int n)
        {
            long f = 1;
            for (int i = 1; i <= n; i++)
            {
                f *= i;
            }
            return f;
        }
    }
}