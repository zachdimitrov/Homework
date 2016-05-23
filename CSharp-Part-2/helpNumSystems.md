##### decimal system
401 = 4\*10<sup>2</sup> + 0\*10<sup>1</sup> + 1\*10<sup>0</sup> = 400 + 1 // umnojavame cifrata po bazata na stepen indeksa
###### binary to decimal
```C#
static int BinaryToDecimal(string binary)
{
  int sum = 0;
  foreach(char bit in binary)
  {
    sum = (bit - '0') + sum * 2;
  }
  return sum;
}
```
###### decimal to binary
```C#
static int DecToBinary(int decValue)
{
  string binary = "";
  do
  {
    int bit = decvalue % 2;
    binary = bit + binary;
    decvalue /= 2;
  } while (decvalue != 0)
  return binary;
}
```
###### pobitovo reshenie
```C#
do
{
  int bit = decValue  & 1;
  binary = bit + binary;
  decValue >>= 1;
} while (decValue != 0)
```
#### hexadecimal system
```C#
Console.WriteLine(0x123); // prevryshta v shestnaisetichna
```
##### convertions
###### from hex to decimal
```C#
static int HexDigitToDecimal(char hexDigit)
{
  if (char.IsDigit(hexDigit))
  {
    return hexDigit - '0';
  }
  return char.ToLower(hexDigit) - 'a' + 10;
}
static void main()
{
  char[] hexDigits = "0123456789ABCDEF".ToCharArray();
  foreach (char hex in hexDigits)
  {
    Console.WriteLine("{0} - {1}", hex, HexDigitToDecimal());
  }
}
```
###### from hex to binary
```C#
static Dictionary<char, string> HexBIn = new Dictionary<char, string>() 
{
  { '0', "0000" },
  { '1', "0001" },
  { '1', "0001" },
  { '1', "0001" },
  { '1', "0001" },
};
static string HexToBinary(string hex)
{
  return "";
}
