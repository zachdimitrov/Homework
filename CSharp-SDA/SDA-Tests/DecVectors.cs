namespace DSA
{
    using System;
    public static class DecVectors
    {
        public static void Output(int n, string vector = "")
        {
            if (n == 0)
            {
                Console.WriteLine(vector);
                return;
            }

            for (int i = 0; i < 10; i++)
            {
                if (String.IsNullOrEmpty(vector) && i == 0 && n != 1)
                {
                    Output(n - 1, "");
                }
                else
                {
                    Output(n - 1, vector + i);
                }
            }
        }
    }
}