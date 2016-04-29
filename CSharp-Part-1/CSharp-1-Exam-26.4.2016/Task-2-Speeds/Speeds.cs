using System;

class Speeds
{
    static void Main()
    {
        int c = int.Parse(Console.ReadLine());
        int count = 1;
        bool first = true;
        int finalSpeedSum = 0;
        int finalCount = 1;
        int frontSpeed = 0;
        int nextSpeed = 0;
        int speedSum = 0;

        for (int i = 0; i < c; i++)
        {
            int speed = int.Parse(Console.ReadLine());
            nextSpeed = speed;
            if (first)
            {
                frontSpeed = speed;
                speedSum = frontSpeed;
                finalSpeedSum = speedSum;
                first = false;
            }
            else
            {
                if (nextSpeed > frontSpeed)
                {
                    speedSum += nextSpeed;
                    count++;
                }
                else
                {
                    speedSum = nextSpeed;
                    count = 1;
                    frontSpeed = nextSpeed;
                }
            }
            if (count > finalCount)
            {
                finalCount = count;
                finalSpeedSum = speedSum;
            }
            else if (count == finalCount)
            {
                if (speedSum > finalSpeedSum)
                {
                    finalSpeedSum = speedSum;
                }
            }
        }
        Console.WriteLine(finalSpeedSum);
    }
}
