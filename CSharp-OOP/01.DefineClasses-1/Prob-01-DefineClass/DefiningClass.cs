using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    public class Display
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

    public class GSM
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

        public override string ToString()
        {
            return string.Format("----- Mobile Phone ----- \n Manufacturer: {1} \n Model: {0} \n Price: {2} \n Owner: {3} \n Battery: \n {4} \n Display: {5}", this.Model, this.Manifacturer, this.Price, this.Owner, this.battery.ToString(), this.display.ToString());
        }

    }

    public class GSMTest
    {
        public static void Test()
        {
            Console.WriteLine("------Testing GSMs------");
            Console.WriteLine("------------------------");
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

    public class Call
    {
        // define fields
        private DateTime date;
        private DateTime time;
        public uint Duration { get; set; }
        private string number;

        // define properties of fields
        public string Date
        {
            get
            {
                return date.ToString("dd.mm.yyyy");
            }
            set
            {
                if (DateTime.TryParse(value, out date))
                {
                    this.date = DateTime.Parse(value, System.Globalization.CultureInfo.InvariantCulture);
                }
                else
                {
                    throw new ArgumentException("Date input is not the correct format!");
                }
            }
        }      
        public string Time
        {
            get
            {
                return time.ToString("hh.mm");
            }
            set
            {
                if (DateTime.TryParse(value, out time))
                {
                    this.time = DateTime.Parse(value, System.Globalization.CultureInfo.InvariantCulture);
                }
                else
                {
                    throw new ArgumentException("Time input is not the correct format!");
                }
            }
        }
        private string Number
        {
            get { return this.number; }
            set
            {
                this.number = value;
            }
        }

        // constructor

    }
    class DefiningClass
    {
        static void Main()
        {
            GSMTest.Test();
        }
    }
}
