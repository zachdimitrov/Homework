namespace DSA
{
    public static class Fibonacci
    {
        // memoisation
        public static decimal[] FibMemo;
        public static decimal WithRecursion(int n)
        {
            if ((n == 1) || (n == 2))
            {
                return 1;
            }

            if (FibMemo[n] > 0)
            {
                return FibMemo[n];
            }
            
            FibMemo[n] = WithRecursion(n-1) + WithRecursion(n-2);
            return FibMemo[n];
        }
    }
}