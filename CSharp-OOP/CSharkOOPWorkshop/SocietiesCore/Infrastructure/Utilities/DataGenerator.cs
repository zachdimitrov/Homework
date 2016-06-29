using System;
using System.Threading;

namespace SocietiesCore.Infrastructure.Utilities
{
    public static class DataGenerator
    {
        private static int counter;
        private static string[] maleNames;
        private static string[] femaleNames;
        private static Random random;

        static DataGenerator()
        {
            counter = 0;
            maleNames = new string[]
            {
                "Gosho",
                "Tosho",
                "Pesho",
                "Bobi",
                "Vanio",
                "Stoyan",
            };
            femaleNames = new string[]
            {
                "Ani",
                "Penka",
                "Ganka",
                "Tanq",
                "Vania",
                "Elena",
            };
            random = new Random();
        }

        public static int GenerateUniqueId()
        {
            return Interlocked.Increment(ref counter);
        }

        public static string GenerateMaleName()
        {
            var index = random.Next(0, maleNames.Length);
            return maleNames[index];
        }

        public static string GenerateFemaleName()
        {
            var index = random.Next(0, femaleNames.Length);
            return femaleNames[index];
        }

        public static int GenerateAge()
        {
            return random.Next(15, 95);
        }
    }
}
