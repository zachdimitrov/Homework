namespace GSMProgram
{
    using System;
    using System.Collections.Generic;

    public class GSM
    {
         /* Problems 1, 2, 4, 5, 6, 9, 10, 11
            this is the main class for our program, it does several 
            things and uses classes - Call, Display, Battery, BattType
         1. Define and display GSMs
         2. Create and manipulate Call History
            - add Calls
            - delete Calls
            - delete Longest Call
            - calculates price
         3. Display information on console
         */
        // Static Fields
        private static GSM iPhone4S = new GSM("iPhone 4S", "Apple")
        {
            Price = 1000.00M,
            Owner = "mama",
            TypeBattery = BattType.LiPol,
            BatteryCapacity = 1432,
            IdleTime = 160,
            TalkTime = 8,
            BatteryModel = "Non Removable",
            DisplaySize = 3.5f,
            DisplayColors = 16000000
        };
        // Instance Fields
        public string Model { get; set; }
        public string Manifacturer { get; set; }
        public decimal Price { get; set; }
        public string Owner { get; set; }
        private Battery battery;
        private Display display;
        private List<Call> callHistory = new List<Call>();

        // Properties for display
        public float DisplaySize
        {
            get { return this.display.Size; }
            set { this.display.Size = value; }
        }
        public int DisplayColors
        {
            get { return this.display.Colors; }
            set { this.display.Colors = value; }
        }

        // Properties of battery
        public string BatteryModel
        {
            get { return this.battery.Model; }
            set { this.battery.Model = value; }
        }
        public ushort BatteryCapacity
        {
            get { return this.battery.Capacity; }
            set { this.battery.Capacity = value; }
        }
        public double IdleTime
        {
            get { return this.battery.HoursIdle; }
            set { this.battery.HoursIdle = value; }
        }
        public double TalkTime
        {
            get { return this.battery.HoursTalk; }
            set { this.battery.HoursTalk = value; }
        }
        public BattType TypeBattery
        {
            get { return this.battery.BatteryType; }
            set { this.battery.BatteryType = value; }
        }

        // static property ot IPhone

        public static GSM IPhone4s
        {
            get { return iPhone4S; }
        }


        // call history
        public List<Call> CallHistory
        {
            get { return this.callHistory; }
        }


        // default constructor
        public GSM()
        {
        }

        // simple constructor
        public GSM(string model, string manifacturer)
        {
            this.Model = model;
            this.Manifacturer = manifacturer;
            this.battery = new Battery();
            this.display = new Display();
        }

        // full constructor
        public GSM(string model, string manifacturer, decimal price, string owner, string batteryModel, ushort batteryCapacity, double idleTime, double talkTime, BattType typeBattery, float displaySize,
            int displayColors)
        {
            this.Model = model;
            this.Manifacturer = manifacturer;
            this.Price = price;
            this.Owner = owner;
            this.BatteryModel = batteryModel;
            this.BatteryCapacity = batteryCapacity;
            this.IdleTime = idleTime;
            this.TalkTime = talkTime;
            this.TypeBattery = typeBattery;
            this.DisplaySize = displaySize;
            this.DisplayColors = displayColors;
        }

        public GSM IPhone4S
        {
            get { return iPhone4S; }
        }
        // methods
        public override string ToString()
        {
            return string.Format("------ Mobile Phone Info ------ \n Manufacturer: {1} \n Model: {0} \n Price: {2} \n Owner: {3} \n Battery: \n {4} \n Display: {5}", this.Model, this.Manifacturer, this.Price, this.Owner, this.battery.ToString(), this.display.ToString());
        }
        public void AddCall(DateTime begin, DateTime end, string number) // add new call to history
        {
            this.callHistory.Add(new Call(begin, end, number));
        }
        public void History() // display call history
        {
            Console.WriteLine("------ Call History -----------");
            Console.WriteLine("===============================");
            if (CallHistory.Count > 0)
            {
                for (int i = 1; i <= CallHistory.Count; i++)
                {
                    Console.WriteLine("{0}. {1}", i, CallHistory[i - 1]);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No records!");
                Console.WriteLine();
            }
        }
        public void DeleteCall(int index) // delete a call using number
        {
            callHistory.RemoveAt(index - 1);
            Console.WriteLine("Call number {0} was deleted!", index);
            Console.WriteLine();
        }
        public void ClearHistory() // create a new call history List
        {
            this.callHistory = new List<Call>();
            Console.WriteLine("Entire call history was deleted!");
            Console.WriteLine();
        }
        public void RemoveLongestCall() // remove longest call
        {
            uint seconds = uint.MinValue;
            int index = 0;
            for (int i = 1; i <= this.callHistory.Count; i++)
            {
                if (this.callHistory[i - 1].Duration > seconds)
                {
                    seconds = this.callHistory[i - 1].Duration;
                    index = i;
                }
            }
            this.callHistory.RemoveAt(index);
            Console.WriteLine("Longest call is {0:F0} seconds", seconds);
            Console.WriteLine();
        }
        public decimal Bill(decimal cost) // calculate total cost for all calls
        {
            decimal bill = 0.0M;
            foreach (var call in this.CallHistory)
            {
                bill += (call.Duration / 60) * cost;
            }
            return bill;
        }
    }
}
