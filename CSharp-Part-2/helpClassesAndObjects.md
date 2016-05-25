#### class
*class* is a template for object instances in the program
```C#
using System;

namespace TestClasses
{
    class Person
    {
        public string Name { get; private set; }
        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 0)
                {
                    age = value;
                }
            }
        }
        public Person()
        {
            Name = "Unnamed";
            Age = 0;
        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void AssignFakeName(string newName)
        {
            Name = newName;
        }
    }
    class ProgramToTestClasses
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Pesho", 0);
            p1.Age++;
            p1.AssignFakeName("Gosho");
            Console.WriteLine(p1.Name + " " + p1.Age);
        }
    }
}
```
