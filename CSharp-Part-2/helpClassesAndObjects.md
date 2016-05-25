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
- **public**:
The type or member can be accessed by any other code in the same assembly or another assembly that references it.
- **private**:
The type or member can be accessed only by code in the same class or struct.
- **protected**:
The type or member can be accessed only by code in the same class or struct, or in a class that is derived from that class.
- **internal**:
The type or member can be accessed by any code in the same assembly, but not from another assembly.
- **protected internal**:
The type or member can be accessed by any code in the assembly in which it is declared, or from within a derived class in another assembly. Access from another assembly must take place within a class declaration that derives from the class in which the protected internal element is declared, and it must take place through an instance of the derived class type.
