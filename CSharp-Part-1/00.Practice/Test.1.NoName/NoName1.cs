using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1.NoName
{
    class NoName1
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int c = 12;
            int compare = 1000;
            string add = string.Empty;
            string result = string.Empty;
            while (true)
            {
                if (c < 0) { break; }
                switch (c)
                {
                    case 12: compare = 1000; add = "6"; break;
                    case 11: compare = 900; add = "46"; break;
                    case 10: compare = 500; add = "5"; break;
                    case 9: compare = 400; add = "45"; break;
                    case 8: compare = 100; add = "4"; break;
                    case 7: compare = 90; add = "24"; break;
                    case 6: compare = 50; add = "3"; break;
                    case 5: compare = 40; add = "23"; break;
                    case 4: compare = 10; add = "2"; break;
                    case 3: compare = 9; add = "02"; break;
                    case 2: compare = 5; add = "1"; break;
                    case 1: compare = 4; add = "01"; break;
                    case 0: compare = 1; add = "0"; break;
                }
                if (num >= compare)
                {
                    result += add;
                    num -= compare;
                }
                else
                {
                    c--;
                }
            }
            Console.WriteLine(result);
        }
    }
}
