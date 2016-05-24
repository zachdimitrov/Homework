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
0 - 3 | 4 - 7 | 8 - B | C - F
--- | --- | --- | ---
0x0 = 0000 | 0x4 = 0100 | 0x8 = 1000 | 0xC = 1100
0x1 = 0001 | 0x5 = 0101 | 0x9 = 1001 | 0xD = 1101
0x2 = 0010 | 0x6 = 0110 | 0xA = 1010 | 0xE = 1110
0x3 = 0011 | 0x7 = 0111 | 0xB = 1011 | 0xF = 1111

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
###### from decimal to hex
```C#
static string DecimalToHex(int decValue)
{
  string result = "";
  string hexDigits = "0123456789ABCDEF";
  do
  {
    int value = decvalue % 16;
    result = hexDigits[value] + result;
    decvalue /= 16;
  } while (decValue != 0);
  return result;
}
```
###### from hex to binary
```C#
static Dictionary<char, string> HexBin = new Dictionary<char, string>() 
{
  { '0', "0000" },
  { '1', "0001" },
  { '2', "0010" },
  { '3', "0011" },
  { '4', "0100" },
  { '5', "0101" },
  { '6', "0110" },
  { '7', "0111" },
  { '8', "1000" },
  { '9', "1001" },
  { 'A', "1010" },
  { 'B', "1011" },
  { 'C', "1100" },
  { 'D', "1101" },
  { 'E', "1110" },
  { 'F', "1111" }
};
static string HexToBinary(string hex)
{
  string result = "";
  foreach (char hexDigit in hex)
  {
    result += HexBin[hexDigit];
  }
  return result;
}
```
#### binary representation
32 bit integers  
unsigned - 2<sup>32</sup>  
00000000 00000000 00000000 00000001 - smallest number  
11111111 11111111 11111111 11111111 - largest numberr  
signed - -2<sup>16</sup> to +2<sup>16</sup>-1 and 0  
00000000 00000000 00000000 00000001 - smallest positive number (1)  
01111111 11111111 11111111 11111111 - largest positive number  
11111111 11111111 11111111 11111111 - largest negative number (-1)  
10000000 00000000 00000000 00000000 - smallest negative number  
