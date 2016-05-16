using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class SolveTasks
{
    static void Main()
    {
        ReadUserInput();
    }

    private static void ReadUserInput()
    {
        Console.Clear();
        Menu();
        ConsoleKeyInfo key = Console.ReadKey();
        switch (key.Key)
        {
            case ConsoleKey.N: ReverseDigits();
                break;
            case ConsoleKey.A: Average();
                break;
            case ConsoleKey.E: SolveEquation();
                break;
            default: ReadUserInput();
                break;
        }
    }
    private static void Menu()
    {
        Console.Title = "Solve Compex Tasks";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("------------------------------------------------");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("        (: Solve Very Complex Tasks :)");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("------------------------------------------------");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write(" To reverse digits of a number press       ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("< N >");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write(" To calculate average of a sequence press  ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("< A >");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write(" To solve the equation a * x + b = 0 press ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("< E >");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("------------------------------------------------");
        Console.ForegroundColor = ConsoleColor.Gray;
    }
    private static void PrintMessage(string key, string mess)
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write(" Press");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(" < {0} >", key);
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine(" {0}...", mess);
    }
    private static void SolveEquation()
    {
        // Prepare Interfase
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("------------------------------------------------");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("    (: Solve equation a * X + b = 0, X = ? :)");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("------------------------------------------------");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write(" Please enter <a> and <b> separated by single space: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        // Validate Input
        string[] arr = Console.ReadLine().Split(' ');
        if (arr.Length != 2)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" Please enter valid numbers for <a> and <b>!");
            PrintMessage("SPACE", "to try again or any key to return to menu");
            if (Console.ReadKey().Key == ConsoleKey.Spacebar)
            {
                SolveEquation();
            }
            else
            {
                ReadUserInput();
            }
        }
        decimal a = new decimal();
        decimal b = new decimal();
        bool testA = decimal.TryParse(arr[0], out a);
        bool testB = decimal.TryParse(arr[1], out b);
        if (testA == false || testB == false || a == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" Please enter valid numbers for <a> and <b>!");
            PrintMessage("SPACE", "to try again or any key to return to menu");
            if (Console.ReadKey().Key == ConsoleKey.Spacebar)
            {
                SolveEquation();
            }
            else
            {
                ReadUserInput();
            }
        }
        // Solve Equation
        decimal x = -b / a;
        // Print Result
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("------------------------------------------------");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write(" The result for X is: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("{0:F4}", x);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("------------------------------------------------");
        PrintMessage("SPACE", "to try again or any key to return to menu");
        // Perform Other Actions
        Console.ForegroundColor = ConsoleColor.Gray;
        if (Console.ReadKey().Key == ConsoleKey.Spacebar)
        {
            SolveEquation();
        }
        else
        {
            ReadUserInput();
        }
    }
    private static void Average()
    {
        // Prepare Interfase
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("------------------------------------------------");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("   (: Find the average of integer sequence :)");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("------------------------------------------------");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write(" Please enter sequence values separated by single space: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        // Validate Input
        string inputS = Console.ReadLine();
        string[] input = inputS.Split(' ');
        bool[] tests = new bool[input.Length];
        decimal [] arr = new decimal[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            tests[i] = decimal.TryParse(input[i], out arr[i]);
            if (tests[i] == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" Please enter a valid sequence!");
                PrintMessage("SPACE", "to try again or any key to return to menu");
                if (Console.ReadKey().Key == ConsoleKey.Spacebar)
                {
                    Average();
                }
                else
                {
                    ReadUserInput();
                }
                break;
            }
        }
        // arr = inputS.Split(' ').Select(int.Parse).ToArray();
        if (arr.Length == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" Please enter a valid sequence!");
            PrintMessage("SPACE", "to try again or any key to return to menu");
            if (Console.ReadKey().Key == ConsoleKey.Spacebar)
            {
                Average();
            }
            else
            {
                ReadUserInput();
            }
        }
        // Find average
        decimal sum = new decimal();
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        decimal average = sum/arr.Length;
        // Print Result
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("------------------------------------------------");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write(" The average of the given sequence \n {0} \n is: ", String.Join(", ", arr));
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("{0:F4}", average);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("------------------------------------------------");
        // Perform Other Actions
        Console.ForegroundColor = ConsoleColor.Gray;
        PrintMessage("SPACE", "to try again or any key to return to menu");
        if (Console.ReadKey().Key == ConsoleKey.Spacebar)
        {
            Average();
        }
        else
        {
            ReadUserInput();
        }
    }
    private static void ReverseDigits()
    {
        // Prepare Interfase
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("------------------------------------------------");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("        (: Reverse Digits of a Number :)");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("------------------------------------------------");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write(" Please Write a non-negative decimal number: ");
        Console.ForegroundColor = ConsoleColor.Yellow;  
        // Receive Input
        decimal n = 0.0m;
        bool test = decimal.TryParse(Console.ReadLine(), out n);
        // Validate Input
        if (!test || n<0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" Please enter again a valid number!");
            PrintMessage("SPACE", "to try again or any key to return to menu");
            if (Console.ReadKey().Key == ConsoleKey.Spacebar)
            {
                ReverseDigits();
            }
            else
            {
                ReadUserInput();
            }
        }
        // Reverse digits
        string number = Convert.ToString(n);
        char[] arr = number.ToCharArray();
        Array.Reverse(arr);
        string reversed = new string(arr);
        // Print Result
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("------------------------------------------------");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write(" Reversed number is: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(decimal.Parse(reversed));
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("------------------------------------------------");
        // Perform Other Actions
        Console.ForegroundColor = ConsoleColor.Gray;
        PrintMessage("SPACE", "to try again or any key to return to menu");
        if (Console.ReadKey().Key == ConsoleKey.Spacebar)
        {
            ReverseDigits();
        }
        else
        {
            ReadUserInput();
        }
    }
}