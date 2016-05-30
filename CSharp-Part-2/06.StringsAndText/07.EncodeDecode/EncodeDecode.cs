using System;
using System.IO;
using System.Text;

namespace ToEncodeDecode
{
    class EncodeDecode
    {
        static void Main()
        {
            Console.Write("Enter key: ");
            string fileName = @"..\..\..\..\..\..\..\encoded.txt";
            string key = Console.ReadLine();
            string input = string.Empty;
            StreamReader reader = new StreamReader(fileName);
            using (reader)
            {
                input = reader.ReadToEnd();
            }
            Console.WriteLine("-------------- original text --------------");
            Console.WriteLine(input);
            char[] code = input.ToCharArray();
            int j = 0;
            int i = 0;
            while (j < code.Length)
            {
                code[j] ^= key[i];
                if (i == key.Length - 1)
                {
                    i = 0;
                }
                j++;
            }
            string output = String.Join("", code);
            Console.WriteLine("-------------- encoded text --------------");
            Console.WriteLine(output);
            Console.WriteLine("----------- text saved to file -----------");
            
            StreamWriter streamWriter = new StreamWriter(fileName, true, Encoding.UTF8);
            using (streamWriter)
            {
                streamWriter.WriteLine("");
                streamWriter.WriteLine("-------------- encoded text --------------");
                streamWriter.WriteLine(output);
            }
        }
    }
}
