##### decimal system
401 = 4\*10<sup>2</sup> + 0\*10<sup>1</sup> + 1\*10<sup>0</sup> = 400 + 1
###### binary to decimal
```C#
static int BinaryToDecimal()
{
  int sum = 0;
  foreach(char bit in binary)
  {
    sum = (bit - '0') + sum * 2;
  }
  return sum;
}
```
