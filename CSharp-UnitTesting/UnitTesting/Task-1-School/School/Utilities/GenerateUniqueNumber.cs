using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Utilities
{
    internal static class GenerateUniqueNumber
    {
        static int counter = Constants.MinIDNumber;
        public static int GetUniqueNumber()
        {
            if (counter < Constants.MaxIDNumber)
            {    
                return counter++;
            }
            else
            {
                counter = Constants.MinIDNumber;
                return counter;
            }
        }
    }
}
