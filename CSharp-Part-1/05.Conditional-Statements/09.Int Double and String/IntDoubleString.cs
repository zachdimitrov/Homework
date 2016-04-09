using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class IntDoubleString
{
    static void Main()
    {
        string type = Console.ReadLine();
        string value = Console.ReadLine();
        switch (type)
        {
            case "integer": { int A = int.Parse(value); Console.WriteLine(A + 1); }
                break;
            case "real": { double B = double.Parse(value); Console.WriteLine("{0:F2}", B + 1); }
                break;
            case "text": { Console.WriteLine(value+"*"); }
                break;
            default: Console.WriteLine("not a valid type");
                break;
        }
    }
}
