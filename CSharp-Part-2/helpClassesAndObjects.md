#### class
*class* is a template for object instances in the program
```C#
class Person
{
  public string Name {get; set;} //field - pole promenlivi ili konstanti
  public int Age {get; set;} 
  public Person(string name, int age)
  {
    this.name = Name;
    this.age= Age;
  }
  public string GetName()
  {
    return this.name;
  }
  public int GetAge()
  {
    return this.age;
  }
}
class Program
{
 static void main()
 {
  Person Ivan = new Person();
 }
}
