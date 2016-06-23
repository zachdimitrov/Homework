namespace ExtMethodsLambdaLINQ
{
    using System;

    /// <summary>
    /// Static class representing a single instance of the Random class
    /// </summary>
    public static class RandomGen
    {
        private static Random instance;

        /// <summary>
        /// The instance of the random class
        /// </summary>
        public static Random Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Random();
                }
                return instance;
            }
        }
    }
}
