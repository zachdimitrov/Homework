namespace Problem_2_BankAccounts.Utilities
{
    using System;

    public static class RegistrationNumberGenerator
    {
        private static int number = 0;

        public static int Rand(int min, int max)
        {
            Random rnd = new Random();
            return rnd.Next(min, max);
        }

        public static string Next()
        {
            int reg = System.Threading.Interlocked.Increment(ref number);
            return String.Format("{0}", number).PadLeft(8, '0');
        }
    }
}
