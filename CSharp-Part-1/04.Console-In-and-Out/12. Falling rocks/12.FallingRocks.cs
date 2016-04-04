using System;
using System.Threading;
using System.Text;

class FallingRocks
{
    static int dpos;
    static char[] rocks = new char[] { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';' };
    static int maxRocks = 4;
    static Random randomN = new Random();
    static int rockY = 1;

    static void Main()
    {
        Console.CursorVisible = false;
        Console.BackgroundColor = ConsoleColor.White;
        Console.BufferHeight = Console.WindowHeight;
        Console.BufferWidth = Console.WindowWidth;
        ConsoleKeyInfo keyInfo;
        resetDwarf();
        while (true)
        {
            if (Console.KeyAvailable)
            {
                keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.LeftArrow)
                {
                    if (dpos > 1)
                    {
                        dpos--;
                    }
                }
                if (keyInfo.Key == ConsoleKey.RightArrow)
                {
                    if (dpos < Console.WindowWidth - 15)
                    {
                        dpos++;
                    }
                }
            }
            Console.Clear();
            drawRocks();
            if (rockY < Console.WindowHeight - 1)
            {
                rockY++;
            }
            drawDworf();
            Thread.Sleep(100);
        }
    }

    private static void drawRocks()
    {
        for (int i = 0; i < maxRocks; i++)
        {
            Console.ForegroundColor = GetRandomColor();
            Console.SetCursorPosition(randomX(), rockY);
            Console.Write(rocks[randomN.Next(0, rocks.Length)]);
        }
    }
    private static int randomX()
    {
        int x = randomN.Next(1, Console.WindowWidth - 1);
        return x;
    }
    private static void resetDwarf()
    {
        Console.ForegroundColor = ConsoleColor.Black;
        dpos = (Console.WindowWidth - 12) / 2;
        Console.SetCursorPosition(dpos, Console.WindowHeight - 1);
        Console.Write("(O)");
    }
    private static void drawDworf()
    {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.SetCursorPosition(dpos, Console.WindowHeight - 1);
        Console.Write("(O)");
    }
    private static ConsoleColor GetRandomColor()
    {
        var consoleColors = Enum.GetValues(typeof(ConsoleColor));
        return (ConsoleColor)consoleColors.GetValue(randomN.Next(consoleColors.Length));
    }
}

/*
Falling Rocks
Description

Implement the "Falling Rocks" game in the text console.
A small dwarf stays at the bottom of the screen and 
can move left and right (by the arrows keys).
A number of rocks of different sizes and forms constantly 
fall down and you need to avoid a crash.
Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, 
- distributed with appropriate density. The dwarf is (O).
Ensure a constant game speed by Thread.Sleep(150).
Implement collision detection and scoring system.
*/
