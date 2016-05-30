using System;
using System.IO;
using System.Net;

namespace ToDownloadFile
{
    class DownloadFile
    {
        static void Main()
        {
            Console.WriteLine("Enter full path to image: ");
            string path = Console.ReadLine();
            int slash = path.LastIndexOf('/');
            int fileNameLenght = path.Length - slash - 1;
            string fileName = path.Substring(slash + 1, fileNameLenght);
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    webClient.DownloadFile(path, fileName);
                }
                Console.WriteLine("File downloaded to:\n {0}", Path.GetFullPath(fileName));
            }
            catch (Exception)
            {
                Console.WriteLine("Sorry, something went wrong! :(");
            }
        }
    }
}