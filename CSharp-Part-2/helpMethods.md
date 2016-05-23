###### deklarirane na metodi
```C#
static void PrintLogo()          // deklarirane na metoda
{
  Console.WriteLine("Logo");
}
statc void Main()
{
  PrintLogo();                   // izpylnqvane na metoda v main
}
```
###### printirane na znak
```C#
static void PrintSign(int number)
{
  switch(number>0)
  {
    case true: ConsoleWriteLine("+"); break;
    case fale: ConsoleWriteLine("-"); break;
    default: Console.WriteLIne("0"); break;
  }
}
```
###### generic method
```C#
static void Print<T>(T number)
{
  Console.WriteLine(number);
}
static void main()
{
  Print<String>("5");
}
```
###### nezadyljitelni parametri
```C#
static void PrintSum(int a, int b, int c = 0, int d = 0)
{
  Console.WriteLine(a+b+c)
}
static void main()
{
  PrintSum(5, 6);
  PrintSum(5, 6, 7);
  PrintSum(5, 6, 7, 8);
  PrintSum(5, 6, d: 8);
}
```
###### metodi koito vryshtat rezultat
```C#
static string FullName(string a, string b, string c = "")
{
  fullName = a+b+c;
  return fullName;
}
```
###### mnojestvo ot parametri
```C#
static int Sum(params int[] numbers)
{
int sum = 0;
foreach (var c in numbers)
{
  sum += c;
}
return sum;
}
```


