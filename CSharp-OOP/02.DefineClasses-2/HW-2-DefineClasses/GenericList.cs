namespace DefineClasses2
{
    using System;
    using System.Text;

    /// <summary>
    /// a generic list class with indexer methods
    /// </summary>
    /// <typeparam name="T"></typeparam>

    public class GenericList<T> 
        where T : IComparable, new()  // Problem 5. generic class
    {
        // fields
        const int defCapacity = 8;
        private T[] arr;
        private int index;
        // indexer
        public T this[int i]
        {
            get
            {
                if (i >= 0 && i < this.Count)
                {
                    return this.arr[i];
                }
                else
                {
                    throw new IndexOutOfRangeException("Index was out of range!");
                }
            }
            set
            {
                this.arr[i] = value;
            }
        }
        // properties
        // count property
        public int Count
        {
            get
            {
                return this.index;
            }
        }
        // capacity property
        public int Capacity
        {
            get
            {
                return arr.Length;
            }
        }
        // default constructor
        public GenericList()
        {
            this.arr = new T[defCapacity];
            this.index = 0;
        }
        // methods
        // add element - one element overload
        public void Add(T element)
        {
            if (index == arr.Length)
            {
                arr = DoubleCapacity(arr);
            }
            this.arr[this.index] = element;
            this.index++;
        }
        // add multiple elements
        public void Add(params T[] elements)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                if (index == arr.Length)
                {
                    arr = DoubleCapacity(arr);
                }
                this.arr[this.index] = elements[i];
                this.index++;
            }
        }
        // add element at position
        public void AddAt(T element, int position)
        {
            if (position >= this.Count)
            {
                throw new IndexOutOfRangeException("Index was out of range!");
            }
            else
            {
                for (int i = this.Count; i >= position ; i--)
                {
                    if (i == arr.Length)
                    {
                        arr = DoubleCapacity(arr);
                    }
                    arr[i] = arr[i - 1];
                }
                arr[position] = element;
                this.index++;
            }
        }
        // remove element at position
        public void RemoveAt(int position)
        {
            if (position >= this.Count)
            {
                throw new IndexOutOfRangeException("Index was out of range!");
            }
            else
            {
                for (int i = position; i < this.Count; i++)
                {
                    arr[i] = arr[i + 1];
                }
                this.index--;
            } 
        }
        // find element by value - returns -1 if not found, returns first index if found
        public int Find(T element)
        {
            int indexFound = -1;
            for (int i = 0; i < this.Count; i++)
            {
                if (this[i].CompareTo(element) == 0)
                {
                    indexFound = i;
                }
            }
            return indexFound;
        }
        // Problem 7. min and max
        // find max element
        public T Max()
        {
            T max = arr[0];
            for (int i = 1; i < this.Count; i++)
            {
                if (arr[i].CompareTo(max) > 0)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        // find min element
        public T Min()
        {
            T min = arr[0];
            for (int i = 1; i < this.Count; i++)
            {
                if (arr[i].CompareTo(min) < 0)
                {
                    min = arr[i];
                }
            }
            return min;
        }
        // clear list
        public void Clear()
        {
            this.arr = new T[defCapacity];
            this.index = 0;
        }
        // a method to double capacity
        private T[] DoubleCapacity(T[] arr)
        {
            T[] arr2 = new T[arr.Length * 2];
            int i = 0;
            foreach (var item in arr)
            {
                arr2[i] = arr[i];
                i++;
            }
            return arr2;
        }
        // override method
        public override string ToString()
        {
            if (this.Count == 0)
            {
                return "No elements in the list!";
            }
            else
            {
                StringBuilder str = new StringBuilder();
                for (int i = 0; i < this.Count - 1; i++)
                {
                    str.AppendFormat("{0}, ", arr[i].ToString());
                }
                str.Append(arr[this.Count - 1].ToString());
                return str.ToString();
            }
        }
    }
}
