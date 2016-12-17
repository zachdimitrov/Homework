namespace DSA
{
    using System;
    public static class BinVectors
    {
        public static void Output(int n, string vector = "")
        {
            if (n == 0)
            {
                Console.WriteLine(vector);
                return;
            }

            Output(n-1, vector + "0");
            Output(n-1, vector + "1");            
        }
    }
}