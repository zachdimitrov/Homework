using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace Prob_01_DefineClass
{
    public enum BattType // define battery types
    {
        LiIon, LiPol, NiMH, NiCd, NiZn
    }

    public class Battery // class for battery of GSM
    {
        public string Model { get; set; } // set by manifacturer - example: SR-123
        private ushort capacity; // example: 650mAh
        public double HoursIdle { get; set; } // hours without use - example: 150h
        public double HoursTalk { get; set; } // hours while talking - example: 6.5h
        public BattType BatteryType { get; set; }

        public Battery()  // default constructor
        {
            Model = "N/A";
        }

        public Battery(BattType batteryType) // default constructor
        {
            this.BatteryType = batteryType; // set only type
        }

        public Battery(string model, ushort capacity, BattType batteryType) // simple constructor
        {
            this.Model = model;
            this.Capacity = capacity;
            this.BatteryType = batteryType;
        }

        public Battery(string model, ushort capacity, double hoursIdle, double hoursTalk, BattType batteryType) // full constructor
        {
            this.Model = model;
            this.Capacity = capacity;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.BatteryType = batteryType;
        }

        public ushort Capacity
        {
            get { return this.capacity; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Capacity cannot be zero!");
                }
                this.capacity = value;
            }
        }

        public override string ToString() // override ToString() for correct info display
        {
            return string.Format("- Battery model: {0} \n - Battery type: {4} \n - Capacity: {1} \n - Idle time: {2} hours \n - Talking time: {3} hours", this.Model, this.Capacity, this.HoursIdle, this.HoursTalk, this.BatteryType);
        }
    }

    public class Display // class for Display
    {
        private float size; // diagonal of display - 5.5 in
        private int colors; // number of colors - 256 colors

        public Display() // default constructor
        {
        }

        public Display(float size, int colors) // full constructor
        {
            this.size = size;
            this.colors = colors;
        }

        public float Size // property
        {
            get { return size; }
            set { size = value; }
        }

        public int Colors // property
        {
            get { return colors; }
            set { colors = value; }
        }

        public override string ToString()
        {
            return string.Format("{0} inch, {1} colors.", this.Size, this.Colors);
        }
    }

    public class GSM // main GSM class
    {
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

    public class GSMTest // class for testing GSM
    {
        public static void Test()
        {
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

    public class GSMHistoryTest // class for testing GSM History
    {
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
            Console.WriteLine("My bill for all calls is: {0} lv.",myPhone.Bill(0.37M));
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

    public class Call // class for defining calls
    {
        // define fields
        private DateTime begin;
        private DateTime end;
        private string number;

        // define fields properties
        private DateTime Begin // set start time of call
        {
            set { this.begin = value; }
        }
        private DateTime End  // set end time of call
        {
            set { this.end = value; }
        }
        public string Number  // set number dialed or answered
        {
            get { return this.number; }
            set
            {
                this.number = value;
            }
        }
        // output properties
        public string Date
        {
            get
            {
                return begin.ToString("dd.mm.yyyy");
            }
        }
        public string Time
        {
            get
            {
                return begin.ToString("HH:mm");
            }
        }
        public uint Duration
        {
            get
            {
                return uint.Parse((this.end - this.begin).TotalSeconds.ToString("F0"));
            }
        }
        // constructors
        public Call()
        {
        }
        public Call(DateTime begin, DateTime end, string number)
        {
            this.Begin = begin;
            this.End = end;
            this.Number = number;
        }
        // methods
        public override string ToString()
        {
            return string.Format("{0}, {1}, duration: {2} sec, with number: {3}", this.Date, this.Time, this.Duration, this.Number);
        }
    }

    class DefiningClass // program start
    {
        static void Main()
        {
            GSMTest.Test();
            GSMHistoryTest.Test();
        }
    }
}
