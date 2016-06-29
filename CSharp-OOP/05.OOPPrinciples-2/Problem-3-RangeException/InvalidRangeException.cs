namespace Problem_3_RangeException
{
    using System;

    public class InvalidRangeException<T> : ArgumentOutOfRangeException
    {
        private T min;
        private T max;

        public InvalidRangeException(string msg, T min, T max) : base(msg)
        {
            this.Min = min;
            this.Max = max;
        }

        public InvalidRangeException(string msg) : base(msg)
        {
        }

        public T Min { get; private set; }
        public T Max { get; private set; }
    }
}
