using System;
using System.Text;

namespace ToParseURL
{
    class ParseURL
    {
        static void Main()
        {
            string url = Console.ReadLine();
            Console.WriteLine(UrlParser(url));
        }
        private static string UrlParser(string url)
        {
            Uri uri = new Uri(url);
            string server = uri.Host;
            string prot = uri.Scheme;
            string resource = uri.LocalPath;
            StringBuilder result = new StringBuilder();
            result.Append("[protocol] = ").Append(prot + "\n")
                  .Append("[server] = ").Append(server + "\n")
                  .Append("[resource] = ").Append(resource + "\n");
            return result.ToString();
        }
    }
}