namespace CommonTypeSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class GenerateID
    {
        private static int id = 1000;

        public static int Next()
        {
            return id++;
        }
    }
}
