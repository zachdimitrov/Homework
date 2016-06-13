##### class
```C# 
public class AlarmClock // class definition
public const double PI = 3.1415 // constant definition
public int Minutes { get; set; } //automatic property, no need for property setup
//fields, properties
private int hours;  //field
public int Hours    // full property setup
	{
		get { return this.hours; } // getter
		set // setter with validation
		{ 
		if (value > 0)
			{
				this.hours = value;
			}
		else 
			{
				return new ArgumentException("Wrong input!");
			}
		} 
	}
//constructors
public AlarmClock() // empty constructor
{ 
}
        
public AlarmClock(int hours = 5, int minutes) // full constructor hours is optional field
{
	this.hours = hours;
	this.minutes = minutes;
}
//methods
public override string ToString() // override method
        {
            return string.Format("Time: ({0} : {1})", Hours, Minutes);
        }
```
##### static class, property, method
```C#
public static class Printer
{
public static void PrintTime()
	{
		Console.WriteLine(new AlarmClock(20, 10))
	}
}
```
##### enumeration
```C#
public enum CatColor  // syzdavane na enumeraciq, moje da se zadade stoinost, ako ne iskame defaultnata (0, 1, 2..)
{
	Black, White, Mixed, Brown
}
```
##### structures
##### generics
##### namespaces
##### indexers
##### operators
##### attributes

