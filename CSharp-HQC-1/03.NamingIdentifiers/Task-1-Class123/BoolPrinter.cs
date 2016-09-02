namespace BoolConsoleWriter
{
    using System;

    internal class BoolPrinter
    {
        public void PrintToConsole(bool input)
        {
            string inputAsString = input.ToString();
            Console.WriteLine(inputAsString);
        }
    }
}
