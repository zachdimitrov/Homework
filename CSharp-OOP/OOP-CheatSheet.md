#### OOP shortcuts
https://msdn.microsoft.com/en-us/library/z41h7fat(v=vs.140).aspx

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

##### interpolated string 
```C#
Console.WriteLine($"The area of interest is bounded by ({p1.X},{p1.Y})") // izpolzva se stoinostta na tova koeto e v kydravite skobi
```
##### static class, property, method
```C#
public static class Printer
{
public static void PrintTime()
	{
		Console.WriteLine(new AlarmClock(20, 10));
	}
}
```

```C#
this.dog = obj as dog; // cast from object to type
```
##### enumeration
```C#
public enum CatColor  // syzdavane na enumeraciq, moje da se zadade stoinost, ako ne iskame defaultnata (0, 1, 2..)
{
	Black, White, Mixed, Brown
}
```

##### structures
- vinagi imat default constructor, izpolzva se kogato ne iskame da promenqme obekta, stava value type
- ```ref``` moje da se izpolzva i taka strukturata sht ese dyrji kato class
- ```out``` podava se v kraq na metoda

```C#
public struct Point3D // definira se po syshtiq nachin kato class, razlikata e che e value type promenliva
```

##### generic class
```C#
public stirng MyList<T> // syzdavame template class
where T : struct // ogranichenie na tipa koito moje da se izpolzva, izbroqvat se v opredelen red
```

##### generic method
```C#
public void walk<T>(T units)
{
	Console.WriteLine($"Walking {units.GetType().Name}); // tipa danni e neopredelen (izkarva imeto na tipa)
}
```

##### namespaces  
- slujat za podredba i grupirane na class-ovete po obshti kriterii

##### indexers  
```C#
public int this [int index] 
{
	get
	{
		if (index >= 0 && index <=31)
		{
		if ((value & (1 << index)) == 0)
		return 0;
		else
		return 1;
		}
	}
	set
	{
		name[i] = l;
	}
}
```

##### operators  
```C#
public static int operator +(Cat cat, Dog doge) {... }
```

##### attributes  
```C#
[Required]
[DllImport("user32.dll", EntryPoint = "MessageBox")]
public static extern int ShowMessageBox(int hWnd, string text, string Caption, int tupe);
...
ShowMessageBox(0, "text", "caption", 0); // DLL e importnat i se polzva
```

definirane na atribute
```C#
public class AuthorAttribute : Attribute
{
	public AuthorAttribute(string authorName)
	{
		this.AuthorName = authorName;
	}
	public string AuthorName { get; set; }
}
... // predi classa kydeto se izpolzwa pishem atributa
[author("Zahari Dimitrov")]
var assembly = Assembly.GetCallingAssembly();
var allTypeThatHaveAuthor = assembly.GetTypes().where(x => x.GetCustomAttributes(typeof(AuthorAttribute).Count>0.ToList()));
foreach (var myType in allTYpesThatHaveAuthor)
{ Console.WriteLine(myType); }
```

##### regex  

##### extention methods  
- добавят функционалност към съществуващи класове
- always static class - extention methods are inside this class
- use this keyword

```C#

public static class Extentions
{ 
	public static int WordCount(this string str) // extend string class
	{
		return str.Split(new[] {'', '.', '?'}, StringSplitOptions.RemoveEmptyEntities);
	}
	public static string ToString<T>(this IEnumerable<T>) // extend all INumerables
	{
		var result = new StringBuilder();
		result.Append("[ ");
		foreach (var item in enumeration)
		{
			result.Append(item);
			result.Append(" ");
		}
		result.Append("]");
		return result.ToString();
	}
	public static IncreaseWidth(this IList<int> list, int amount) // extend all <int> lists
	{
		for (int i = 0; i < list.Count; i++)
		{
			list[i] += amount;
		}
	}
}
```

##### class library
- create class library prom *new project*
- use class library to store classes, add refference to library before use

##### anonymous types  

```C#
var point = new { x = 3, y = 5 };  // ne se podava tip
```

##### Interface
```C#
public interface IMovable
{
	void move();
}
```
* Ne se polzvat accsess modifiers
* Moje da se napravi kolekciq ot interface List<IMovable>

##### Inheritance
```C#
public class Cat : Mammal
{
	public Cat(int age) : base(age) // age e property ot bazoviq klass Mammal i se nasledqva
	{
	}
}
```

##### HashSet
```C#
public override int GetHashCode() // metod za override na GetHashCode
    { 
        return x;
    } 
var ints = new HashSet<int>(); // pazi samo unikalni stoinosti, dobr e da implementirame GetHashCode
ints.Add(1);
```
##### Exceptions

```C#
public class InvalidNeshtoSiException : ApplicationException
{
 public InvalidNeshtoSiException(string msg, int minAge, int maxAge) : base(msg) // dopylnitelna informaciq
 {
  this.MinAge = minAge;
  this.MaxAge = maxAge;
 }
 public int MinAge { get; private set; }
 public int MaxAge { get; private set; }
}
```

