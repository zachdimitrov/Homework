using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

struct Rock
{
    public int x;
    public int y;
    public char c;
    public ConsoleColor color;
}

struct Dwarf
{
    public int x;
    public int y;
    public string s;
    public ConsoleColor color;
}

class FallingRocks
{
    static Random rand = new Random();
    private static ConsoleColor GetRandomColor()
    {
        var consoleColors = Enum.GetValues(typeof(ConsoleColor));
        return (ConsoleColor)consoleColors.GetValue(rand.Next(consoleColors.Length));
    }
    static void PrintString(int x, int y, object s, ConsoleColor sColor = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = sColor;
        Console.Write(s);
    } // prnts string on selected position
    static void PrintChar(int x, int y, char c, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(c);
    } // prnts char on selected position
    static void Main()
    {
        const int cw = 40;  // set wndow width
        const int ch = 30;  // set window height
        Console.WindowWidth = Console.BufferWidth = cw;
        Console.WindowHeight = Console.BufferHeight = ch;
        int Lives = 10;
        int Score = 0;
        Dwarf dwrf = new Dwarf();
        dwrf.x = cw / 4;    // dwarf default x value
        dwrf.y = ch - 2;    // dwarf default y value
        dwrf.s = "(O)";
        dwrf.color = ConsoleColor.White;
        char[] rockSymbol = new char[] {'^', '@', '*', '&', '+', '%', '$', '#', '!', '.' , ';' , '-'};
        string[] hit = new string[] {
            "YOU ARE HIT!",
            "WATCH YOUR HEAD!",
            "BE CAREFUL!",
            "BE MORE CAREFUL!",
            "CONCENTRATE!",
            "YOU ARE FUCKED!",
            "WHAT THE FUCK!"
        };
        List<Rock> obj = new List<Rock>();
        while (true)
        {
            bool hitted = false;
            Rock newRock = new Rock();
            newRock.x = rand.Next(0, cw / 2);
            newRock.y = 0;
            newRock.c = rockSymbol[(int)(rand.Next(0,12))];
            newRock.color = GetRandomColor();
            obj.Add(newRock);

            while (Console.KeyAvailable)
            {
                ConsoleKeyInfo PressedKey = Console.ReadKey(true);
                if (PressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (dwrf.x > 0)
                    {
                        //PrintString(dx, dy, "   ");
                        dwrf.x = dwrf.x - 1;
                    }
                }
                if (PressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (dwrf.x < (cw / 2)-2)
                    {
                        //PrintString(dx, dy, " ");
                        dwrf.x = dwrf.x + 1;
                    }
                }
            }
            List<Rock> Nobj = new List<Rock>();
            for (int i = 0; i < obj.Count; i++)
            {
                Rock oldRock = obj[i];
                Rock nextRock = new Rock();
                nextRock.x = oldRock.x;
                nextRock.y = oldRock.y + 1;
                nextRock.c = oldRock.c;
                nextRock.color = oldRock.color;
                if (nextRock.y < ch)
                {
                    Nobj.Add(nextRock);
                }
                if (nextRock.x>dwrf.x && nextRock.x<dwrf.x+2 && nextRock.y == dwrf.y)
                {
                    hitted = true;
                    Lives = Lives - 1;
                }
                else
                {
                    if (nextRock.y == ch)
                    {
                        Score = Score + 100;
                    }
                }
            }
            obj = Nobj;
            Console.Clear();
            if (hitted)
            {
                obj.Clear();
                PrintString(5, 10, hit[(int)(rand.Next(0, 7))], ConsoleColor.Red);
                Thread.Sleep(800);
                if (Lives == 0)
                {
                    Console.Clear();
                    PrintString(cw / 2 - 4, 6, "GAME OVER", ConsoleColor.Red);
                    break;
                }
            }
            else
            {
                PrintString(dwrf.x, dwrf.y, dwrf.s, dwrf.color);
            }
            foreach (Rock stone  in obj)
            {
                PrintChar(stone.x, stone.y, stone.c, stone.color);
            }
            for (int i = 0; i < ch; i++)
            {
                PrintChar(cw / 2 + 1, i, '|', ConsoleColor.Blue);
            }
            if (Score>1 && Score%10000 == 0)
            {
                Lives++;
            }
            PrintString(cw / 2 + 4, 0, "-------------", ConsoleColor.Green);
            PrintString(cw / 2 + 4, 1, "FALLING ROCKS", ConsoleColor.Yellow);
            PrintString(cw / 2 + 4, 2, "-------------", ConsoleColor.Green);
            PrintString(cw / 2 + 4, 4, "Score:");
            PrintString(cw / 2 + 11, 4, Score);
            PrintString(cw / 2 + 4, 6, "Lives:");
            PrintString(cw / 2 + 11, 6, Lives);
            PrintString(cw / 2 + 4, 8, "-------------", ConsoleColor.Green);
            PrintString(cw / 2 + 4, 10, "< move left");
            PrintString(cw / 2 + 4, 11, "> move right");
            PrintString(cw / 2 + 4, 13, "Try to avoid");
            PrintString(cw / 2 + 4, 14, "falling rocks!");
            Thread.Sleep(250);
        }
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
