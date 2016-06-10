namespace GSMProgram
{
    using System;

    public class Call
    {
        // Problem 8.
        // this class defines each call that is later saved in Call History
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
}
