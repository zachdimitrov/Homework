namespace CommonTypeSystem
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public class BitArray64 : IEnumerable<int>
    {
        private const int size = 64;
        private int[] bits = new int[size];

        public BitArray64(ulong number)
        {
            string binary = DecTRoBinary(number);
            bits = crateArray(binary);
        }

        public static bool operator ==(BitArray64 left, BitArray64 right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(BitArray64 left, BitArray64 right)
        {
            return !left.Equals(right);
        }

        public override int GetHashCode()
        {
            return this.bits.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            var other = (BitArray64)obj;
            for (int i = 0; i < size; i++)
            {
                if (!other.bits[i].Equals(this.bits[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index > size - 1)
                {
                    throw new ArgumentOutOfRangeException("Index should be between 0 and 63!");
                }
                return this.bits[index];
            }
        }

        private int[] crateArray(string binary)
        {
            int[] bits = new int[64];
            for (int i = 0; i < 64; i++)
            {
                bits[i] = int.Parse(binary[i].ToString());
            }
            return bits;
         }

        private string DecTRoBinary(ulong number)
        {
            int toBase = 2;
            string binary = String.Empty;
            while (number > 0)
            {
                ulong rem = number % (ulong)toBase;
                number /= (ulong)toBase;
                binary = rem.ToString() + binary;
            }
            return binary.ToString().PadLeft(64, '0');
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < size; i++)
            {
                yield return this.bits[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override string ToString()
        {
            var str = new StringBuilder();
            str.AppendLine("---------------------------");
            str.AppendLine(string.Join("|", this.bits));
            str.Append("---------------------------");
            return str.ToString();
        }
    }
}
