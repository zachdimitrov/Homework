namespace GSMProgram
{
    using System;

    public class GSMTest
    {
        public static void Test()
        {
            // Problem 7.
            // class for testing GSM
            Console.WriteLine("++++++ Testing GSMs +++++++++++");
            Console.WriteLine("===============================");
            GSM[] GSMs = new GSM[]
                {
                    new GSM("S3", "Jiayu"),
                   new GSM("Razor", "Motorola"),
                   new GSM("Mi4i", "Xiaomi"),
                   GSM.IPhone4s
                };

            foreach (var gsm in GSMs)
            {
                Console.WriteLine(gsm.ToString() + "\n");
            }
        }
    }
}
