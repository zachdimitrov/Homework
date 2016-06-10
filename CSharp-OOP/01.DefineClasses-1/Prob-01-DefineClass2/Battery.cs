namespace GSMProgram
{
    using System;

    public class Battery 
    {
        // class for battery of GSM
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
}
