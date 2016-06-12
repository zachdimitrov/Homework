##### class
```C# 
public class MyCustomClass // class definition
public const double PI = 3.1415 // constant definition
public int Number { get; set; } //automatic property, no need for property setup
//fields, properties
private int hours;  //field
public int Hours    // full property setup
	{
		get { return this.hours; } // getter
		set { this.hours = value; } // setter
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
```
##### static class
##### enumeration
##### structure
##### generic
##### indexer
##### attribute

