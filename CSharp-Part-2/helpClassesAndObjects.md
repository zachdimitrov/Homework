#### class
**class** is a template for object instances in the program  
[Example of simple Class ](https://github.com/zachdimitrov/Homework/blob/master/CSharp-Part-2/00.Practice/001.Classes/Program.cs)  
```C#
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
```
##### access modifiers
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

##### property
`p1.Name`, `p1.Age` tova e zadavane na properties
##### static methods
`Console.WriteLine("Gosho")` tova e statichen method
##### instance methods
`<object_name>.<met hod_name>(<parameters>` tova e sintaksisa za izvikvane na instance method  
`List<T>.Add(item`  
`DateTime.AddDays(Count)`  
`string.Substring(index, length)`  
`p1.AssignFakeName("Pesho")` e izvikvane na takyv metod ako predi tova sme syzdali obekt p1 ot class Person  
`"aaaaaa".ToUpper()` tova pak e instance method - vryshta AAAAAA  
##### DateTime (ne e class, a structure)
`DateTime now = DateTime.Now;` tova e vzimane na static property  
`DateTime later = now.AddHours(8);` tova e method  
