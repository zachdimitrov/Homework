namespace CommonTypeSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public class Person
    {
        private int? age;
        private string name;

        public Person()
        {
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int? Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Age must be a positive number or null if not specified!");
                }
                age = value;
            }
        }

        public override string ToString()
        {
            var str = new StringBuilder();
            str.AppendLine("==========================");
            str.AppendLine($"Name: {this.Name}");
            if (age == null)
            {
                str.AppendLine($"Age is undefined!");
            }
            else
            {
                str.AppendLine($"Age: {this.Age}");
            }
            str.AppendLine("==========================");
            return str.ToString();
        }
    }
}
