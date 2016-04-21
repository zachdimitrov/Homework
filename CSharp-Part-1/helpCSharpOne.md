#### primitive data types
###### integer numbers

*type* | *range* | *literal*
---|---|---
**byte**|0 .. 255| ```C# byte b = 42; ```
**sbyte**|-128 .. 127| ```sbyte sb = 5; ```
**short**|-32,768 .. 32,767| ```short sh = 12; ```
**ushort**|0 .. 65,535| ```ushort ush = 15; ```
**int**|-2,147,483,648 .. 2,147,483,647| ```int i = 23; ```
**uint**|0 .. 4,294,967,295| ```uint ui = 122U; ```
**long**|-9,223,372,036,854,775,808 .. 9,223,372,036,854,775,807| ```long l = 22L; ```
**ulong**|0 .. 18,446,744,073,709,551,615| ```ulong ul = 33UL; ```
**BigInteger**|unlimited to memory size| ``` BigInteger bi = 21; ```

###### floating point numbers

*type*| *range*| *literal*
---|--- |---
**float**|-3.402823 e 38 .. 3.402823 e 38| ```float fl = 1.5f; ```
**double**|-1.79769313486232 e 308 .. 1.79769313486232 e 308| ```double 2.4d; ```
**decimal**|-79228162514264337593543950335 .. +#| ```decimal 4.5m; ```

###### other non number types

*type*| *range* | *literal*
---|---|---
**char**|A Unicode character.| ```char a = 'a'; ```
**string**|A string of Unicode characters.| ```string s = "string"; ```
**bool**|True or False.| ```bool b = True; ```
**object**|An object.| ```object o; ```

##### char
```C#
char a = 'a'; char b = 'b'; char someChar = 'a' + 'b';  // perform operations like int
char a = \u0064;                                        // this will return '@'
char a = (char) 64                                      // this will also return '@'
```
##### string
```C#
string test = @"this is "special" \ test \ string"      // use @ to escape everything
string more = "this is \"test\" \\string\\"             // use \ to escape special characters \n for new line
string fullName = firstName + " " + lastName;                 // concatenate strings
string fullName = "my name is {0} {1}.", firstName, lastName; // use placeholders
int l = fullName.Length;                                      // find length of string
string s = Convert.ToString(number);                          // convert anything to string
Console.WriteLine(new string('c', 5);                         // write character c  five times as a string
```
##### variables declarating
```C#
int num = new int(); int firstValue = 5; int secondValue = firstValue;
int? num = Null;                                             // use Null value with non nullable types
```
#### operators and expressions
**category**|**operators**
---|---
aritmetic| *  -  *  /  %  ++  --
logical|&&  \|\|  ^  !
binary|& \| ^  ~  <<  >>
comparison| ==  !=  <  >  <=  >=
assignment|=  +=  -+  *=  /=  %=  &=  \|=  ^=  <<=  >>=
concatenation|+
type convertion|is  as  typeof
other|.  []  ()  ?:  new

##### logical operators *\\\ represents ||*

operation | \\\ | \\\ | \\\ | \\\ | && | && | && | && | ^ | ^ | ^ | ^ 
---       |---   |---   |---   |---   |--- |--- |--- |--- |---|---|---|---
operand 1 |0     |0     |1     |1     |0   |0   |1   |1   |0  |0  |1  |1
operand 2 |0|1|0|1|0|1|0|1|0|1|0|1
result    |0|1|1|1|0|0|0|1|0|1|1|0

###### ! turns *true* to *false* and reverse
##### bitwise operations *\\ represents |*

operation | \ | \ | \ | \ | & | & | & | & | ^ | ^ | ^ | ^ 
---|---|---|---|---|---|---|---|---|---|---|---|---
operand 1 |0|0|1|1|0|0|1|1|0|0|1|1
operand 2 |0|1|0|1|0|1|0|1|0|1|0|1
result    |0|1|1|1|0|0|0|1|0|1|1|0

##### Math.class
Sin, Cos, Log, Ln, POw, Min, Max, Sqrt and other functions

##### console in and out

__Console.Read(...)__      - reads single character
__Console.ReadKey(...)__   - reads a combinations of keys
__Console.ReadLine(...)__*  - reads a single line of characters

---

__Console.Write(...)__       - output the specified argument
__Console.WriteLine(...)__ - outputs the data and moves to next line

---

##### set culture
```C#
using System.Threading;
using System.Globalisation;
Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
```
###### string formatting
```C#
Console.WriteLine("{0} and {1} are primes.", 7, 13);   // 7 and 13 are primes.
Console.WriteLine("The price is {0:C2}", 2.34)         // The price is 2,34 лв  (if culture is Bulgaria)
Console.WriteLine("It is now {0:d} at {0:t}", DateTime.Now); // It is now 4/22/2016 at 11:25 PM
Console.WriteLine("{0,6} {1, 15:N0}", year, population);     //     2013      1,233,345 ( use -6 to left align)
```
C2 - valuta, E3 - ecsponent format, F4 - number of decimals,
N3 - seperated number with decimals, P2 - percent with decimals,
D6 - number of digits, X6 - number of digits for 16 base, 
0,000.00 - format of number (ako e 0.00 - otpred ne se ogranichava),
{{ string }} - escape format brackets

#### conditional statements
if statement
```C#
if (a == b)
  {
    a++;
  }
  else  // or else if
  {
    b = a + 1;
  }
```
switch statement
```C#
switch (day)
{
  case 1: Console.WriteLine("Monday"); break;
  case 2: Console.WriteLine("Tuesday"); break;
  case 3: Console.WriteLine("Wednesday"); break;
  default: Console.WriteLine("Error"); break;
}
```
#### loops
while
```C#
while (a < 5)
{
  Console.WriteLine(a);
}
```
do-while
```C#
do
{
  Consle.WriteLine(b)
}
while (b < 5);
```
for loop
```C#
for (initialisation; test; update)
{ statements; }
```
foreach loop
```C#
foreach (Type element in collection)
{ statements; }
```
jump statements (break, continue, goto) avoid using it

### algoritms
#### useful code
##### get all characters of a string
```C#
string text = “some text”;
for (int i = 0; i < text.Length; i++)
{
	char currentChar = text[i];
	Console.WriteLine(currentChar);
} 
```
##### find biggest element
```C#
int max = int.MinValue;
if (max < someNumber)
{
	max = someNumber;
}
```
##### sum and oriduct of N numbers
```C#
int sum = 0; int product = 1;
for (int i = 0; i < N; i++)
{
   int number = int.Parse(Console.ReadLine());
   sum += number; product *= number;
}
```
##### print all digits of a number
```C#
int number = 1234;
while (number > 0)
{
	int remainder = number % 10;
	number /= 10;
	Console.WriteLine(remainder);
}
```
##### N^M
```C#
int number = 10; int power = 3; int result = 1;
for (int i = 0; i < power; i++)
{
	result *= number;
}
```
##### Fibonacci
```C#
int a = 0; int b = 1;
For (int i = 0; i < 20; i++;)
{
	int sum = a + b;
	a = b; b = sum;
	Console.WriteLine(sum);
} 
```
##### N factorial
```C#
using System.Numerics;
static void Main()
{
    int n = 1000;
    BigInteger factorial = 1;
    do
    {
        factorial *= n;
        n--;
    }
    while (n > 0);
    Console.WriteLine("n! = " + factorial);
}
```
##### find all prime factors
```C#
int number, factor;
number = int.Parse(Console.ReadLine());
for (factor = 2; number > 1; factor ++)
    if (number % b == 0)
    {
        int counter = 0;
        while (number % factor == 0)
        {
            number /= factor;
            counter++;
        }
        Console.WriteLine("{0} -> {1}", 
            factor, counter);
    }
```
#### arrays 
```C#
int[] array = new int [N];              // declare
int num = array[0]; int sec = array[1]; // get first and second value
array[0] = 10; array[1] = 15;           // set values
```
##### using for loops to iterate array
```C#
int[] array = new int[10];
For(int i = 0; i < array.Length; i++)
{
    array[i] = int.Parse(Console.ReadLine());
    Console.WriteLine(array[i]);
}
```







