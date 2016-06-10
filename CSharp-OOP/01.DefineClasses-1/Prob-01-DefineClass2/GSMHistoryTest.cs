namespace GSMProgram
{
    using System;
    using System.Globalization;
    using System.Threading;

    public class GSMHistoryTest
    {
        // Problem 12.
        // class for testing Call History
        public static void Test()
        {
            Console.WriteLine("++++++ Test Call History ++++++");
            Console.WriteLine("===============================");
            GSM myPhone = new GSM("Moto G", "Motorola")
            {
                Price = 200.00M,
                Owner = "my wife",
                TypeBattery = BattType.LiPol,
                BatteryCapacity = 2200,
                IdleTime = 120,
                TalkTime = 11,
                BatteryModel = "MTR-221",
                DisplaySize = 4.0f,
                DisplayColors = 16000000
            };
            // add calls
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB"); //dd/MM/yyyy
            myPhone.AddCall(DateTime.ParseExact("09/04/2016 21:59:30", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                            DateTime.ParseExact("09/04/2016 22:02:10", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                            "0885 324 454");
            myPhone.AddCall(DateTime.ParseExact("11/04/2016 15:12:31", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                            DateTime.ParseExact("11/04/2016 15:16:03", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                            "0882 223 789");
            myPhone.AddCall(DateTime.ParseExact("01/05/2016 11:10:11", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                            DateTime.ParseExact("01/05/2016 11:24:44", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                            "0882 223 789");
            myPhone.AddCall(DateTime.ParseExact("23/05/2016 14:19:10", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                            DateTime.ParseExact("23/05/2016 14:24:31", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                            "0882 223 789");
            // display call history
            myPhone.History();
            // calculate price
            Console.WriteLine("My bill for all calls is: {0} lv.", myPhone.Bill(0.37M));
            Console.WriteLine();
            // remove the longest call
            myPhone.RemoveLongestCall();
            // calculate price again
            Console.WriteLine("My bill for all calls but the longest is: {0} lv.", myPhone.Bill(0.37M));
            Console.WriteLine();
            // clear call history
            myPhone.ClearHistory();
            //Print history after clear
            myPhone.History();
        }
    }
}
