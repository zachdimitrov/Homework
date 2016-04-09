using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DigitAsWord
{
    static void Main()
    {
        string digit = Console.ReadLine();
        string text = "";
        switch (digit)
        {
            case "0": text = "zero";
                break;
            case "1": text = "one";
                break;
            case "2": text = "two";
                break;
            case "3": text = "three";
                break;
            case "4": text = "four";
                break;
            case "5": text = "five";
                break;
            case "6": text = "six";
                break;
            case "7": text = "seven";
                break;
            case "8": text = "eight";
                break;
            case "9": text = "nine";
                break;
            default: text = "not a digit";
                break;
        }
        Console.WriteLine(text);
    }
}
