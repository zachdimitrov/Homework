using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToReadAllContent
{
    class ReadContent
    {
        static void Main()
        {
            Console.WriteLine("Enter File Path");
            string fileName = Console.ReadLine();
            try
            {
                string fileText = File.ReadAllText(fileName);
                Console.WriteLine(fileText);
            }
            catch (Exception)
            {
                Console.WriteLine("File not found!");
            }
        }
    }
}
