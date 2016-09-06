using System;

namespace HomeworkTasks
{
    class Task_3_Loop
    {
        public const int TheNumberOfTheBeast = 666;
        public int[] array = new int[1000];

        public void Loop()
        {
            int index = 0;

            for (index = 0; index < array.Length;)
            {
                if (index % 10 == 0)
                {
                    Print(index);

                    var expectedValue = array[array.Length - 1];
                    if (array[index] == expectedValue)
                    {
                        index = TheNumberOfTheBeast;
                        Console.WriteLine("Value Found");
                    }
                    index++;
                }
                else
                {
                    Console.WriteLine(array[index]);
                    index++;
                }
            }
        }

        private void Print(int i)
        {
            Console.WriteLine(array[i]);
        }
    }
}
