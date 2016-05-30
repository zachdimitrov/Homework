using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Tron3D
{
    class Tron3D
    {
        static int oldx, oldy, oldz;
        static int x, y;
        static string redMoves, blueMoves;
        static bool[,] used;
        static int currentRedX;
        static int currentRedY;
        static int currentBlueX;
        static int currentBlueY;

        static int redDirection;
        static int blueDirection;
        // Directions: 0->Right, 1->Down, 2->Left, 3->Up

        static void MovePlayer(ref int currentX, ref int currentY, int direction)
        {
            if (direction == 0)
            {
                currentY++;
            }
            else if (direction == 1)
            {
                currentX++;
            }
            else if (direction == 2)
            {
                currentY--;
            }
            else if (direction == 3)
            {
                currentX--;
            }
        }

        static int RotateLeft(int directions)
        {
            int newDirection = directions - 1;
            if (newDirection == -1)
            {
                newDirection = 3;
            }
            return newDirection;
        }

        static int RotateRight(int directions)
        {
            int newDirection = directions + 1;
            if (newDirection == 4)
            {
                newDirection = 0;
            }
            return newDirection;
        }

        private static void ReadInput()
        {
            string xyzAsString = Console.ReadLine();
            var xyzStringPart = xyzAsString.Split(' ');
            oldx = int.Parse(xyzStringPart[0]);
            oldy = int.Parse(xyzStringPart[1]);
            oldz = int.Parse(xyzStringPart[2]);
            redMoves = Console.ReadLine();
            blueMoves = Console.ReadLine();
        }

        static void Main()
        {
            ReadInput();
            x = oldx;
            y = oldz * 2 + oldy * 2;
            used = new bool[x + 1, y];
            currentRedX = oldx / 2;
            currentRedY = oldy / 2;
            currentBlueX = oldx / 2;
            currentBlueY = oldy + oldz + oldy / 2;

            redDirection = 0;
            blueDirection = 2;

            var redIndex = 0;
            var blueIndex = 0;
            while (true)
            {
                
                int newRedX = currentRedX;
                int newRedY = currentRedY;
                int newBlueX = currentBlueX;
                int newBlueY = currentBlueY;

                //movered
                while (redMoves[redIndex] != 'M')
                {
                    if (redMoves[redIndex] == 'L')
                    {
                        redDirection = RotateLeft(redDirection);
                    }
                    else if (redMoves[redIndex] == 'R')
                    {
                        redDirection = RotateRight(redDirection);
                    }
                    redIndex++;
                }
                MovePlayer(ref newBlueX, ref newBlueY, blueDirection);
                redIndex++;
                // moveblue
                while (blueMoves[blueIndex] != 'M')
                {
                    if (blueMoves[blueIndex] == 'L')
                    {
                        blueDirection = RotateLeft(blueDirection);
                    }
                    else if (blueMoves[blueIndex] == 'R')
                    {
                        blueDirection = RotateRight(blueDirection);
                    }
                    blueIndex++;
                }
                MovePlayer(ref newBlueX, ref newBlueY, blueDirection);
                redIndex++;
            }
        }
    }
}
