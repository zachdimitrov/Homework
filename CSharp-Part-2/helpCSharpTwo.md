#### one-dimentional arrays
###### declare arrays
```C#
int[] arr = new int[5]; // new array with 5 elements (cannot be changed)
string[] text = {"one", "two", "three"}; // setting values of array
int length = text.Length; // shows length of array (int)
```
###### reverse array
```C#
int[] array = new int[] {1, 2, 3, 4, 5, 6};
int[] reversed = new int[array.Length];
for (int i=o; i<array.Length; i++) { reversed[array.Length - i - 1] = array[i]; }
```
###### reading and writing array to console
```C#
int[] arr = new int[5];
for (int i = 0; i < 5; i++) { arr[i] = int.Parse(Console.ReadLine()); }
string[] input = Console.ReadLine().Split(' ');  // taka vyvejdame chisla ot tipa - 1 2 3 5 7 8
```
###### symmetry check
```C#
bool isSymetric = true;
for (int i = 0; i < array.Length / 2; i++)
{
  if (array[i] != array[n - i - 1]) { isSymetric = false; }
}
```
###### print array to console
```C#
string[] array = {"one", "two", "three"};
for (int index = 0; index < array.Length; index++) // Process all elements of the array
{
    Console.WriteLine("element[{0}] = {1}", index, array[index]); // Print each element on a separate line
}
```
###### resizable arrays List<>
```C#
List<int> intList = new List<int>();
for (int i = 0; i < 5; i++) { intList.Add(i); }
int Length = intList.Count;      // shows length of used list
int Capacity = intList.Capacity; // shows current capacity
```
###### copy arrays - array is a refference type so we do not use simple =
```C#
int[] array = new [5] { 1, 2, 3, 4, 5 };
int[] copyArray = (int[])array.Clone();
```
#### multi-dimentional arrays
```C#
int[,] matrix = new int[3, 4];
string[,,] stringCube = new string[5, 5, 5];
matrix =                 // The matrix size is 2 x 4 (2 rows, 4 cols)
{
      { 1, 2, 3, 4 }, // row 0 values
      { 5, 6, 7, 8 }, // row 1 values
}; 
int element11 = matrix[1, 1]; // element11 = 1
for (int row = 0; row < 2; row++)               //reading a matrix
{
    for (int column = 0; column < 4; column++)
    {
          Console.Write("matrix[{0},{1}] = ", row, column);
          matrix[row, column] = int.Parse(Console.ReadLine());
    }
}
for (int row = 0; row < matrix.GetLength(0); row++)       //printing a matrix
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        Console.Write("{0, 4}", matrix[row, col]);
    }
    Console.WriteLine();
}
```
###### find maximal platform
```C#
int[,] matrix =
{
    {7, 1, 3, 3, 2, 1},
    {1, 3, 9, 8, 5, 6},
    {4, 6, 7, 9, 1, 0}
};
int bestSum = int.MinValue;
for (int row = 0; row < matrix.GetLength(0) - 1; row++)
{
    for (int col = 0; col < matrix.GetLength(1) - 1; col++)
    {
        int sum = matrix[row, col] + matrix[row, col + 1] +
                  matrix[row + 1, col] +
                  matrix[row + 1, col + 1];
        if (sum > bestSum)
            bestSum = sum;
    }
}
```
##### jagged arrays
```C#
int[][] jagged = new int[3][]; // vytreshnite izmereniq ne se zadavat
jagged[0] = new int[3];
jagged[1] = new int[2];
jagged[2] = new int[5];
````
###### reading jagged arrays
```C#
for(int i=0; i<jagged.Length; i++)
{
  string[] input = Console.ReadLine().Split(' '); 
  for(int j=0; j<jagged[i].Length; j++;)
  {
    jagged[i][j] = int.Parse(input[j]);
  }
}
```
###### group numbers by remainder of dividing by 3 - 0, 1, 2
```C#
int[] input = Console.RadLine().Split(' ').Select(int.Parse).ToArray(); // another way to input
int[] count = {0, 0, 0};              // broqch za vynshnite masivi
foreach(int number in input)          // namirame broq na elementite vyv vseki ot vynshnite masivi
{                                     // i gi zapazvame v masiva 'count'
  count[number % 3]++;                // ako ostatyka e 0,1,2 uvelichavame syotvetnoto chislo v count
}
int[][] answer = { new int[count[0]], new int[count[1]], new int[count[2]] };
count = new int[] {0, 0, 0};  //nulirame broqcha
foreach(int number in input)
{
  int remainder = number % 3;
  answer[remainder][count[remainder]] = number;  // bez switch
  count[remainder]++;
}
for(int i=0; i<3; i++)                           // output result
{
  Console.Write("Remainder {0}:", i);
  foreach (int number in answer[i])
  {
    Console.Write(" {0}", number);
  }
  Console.WriteLine();
}
```
###### pascal triangle
namira briq kombinacii - primer na poziciq (7, 3) namirame kolko nachina ima da se vzemat 3 chisla ot 7
```C#
int n = 10;                             // broi na redove
int[][] pascal = new int[n+1][];        // syzdavame masiv ot masivi s n+1 na broi redove
pascal[0] = new int[1];                 // zadavame masiva na 1-viq red
pascal[0][0] = 1;                       // sys stoinost 1
for(int i = 1; i <= n; i++)             // na masivite ot vseki sledvasht red dobavqme po oshte 1 element
{                                       
  pascal[i] = new int[i + 1];           // red 2 stava s 3 elementa, red 5 stava s 6 elementa i t.n.
  pascal[i][0] = 1;                     // 0-viq element ot vseki red e 1
  for(int j = 0; j < i; j++)            // zadavame sledvashtite elementi na vseki red s cikal
  {
    pascal[i][j] = pascal[i-1][j-1] + pascal[i-1][j];  // vseki sledvsaht element e sbora ot tezi nad nego
  }
  pascal[i][i] = 1;                    // zadavame stoinost na posledniq element 
}                                      // nqma kak s gorniq nashin, otdqsno e prazno
for(int i = 0; i <= n; i++)            // izvejdame rezultata
{
  Console.WriteLine(String.Join(" ", pascal[i]));          // pascal[i] sa vsichki masivi
}
```
###### matrix multiplication
umnojava se vseki element ot red(i) ot 1-vata sys vseki element ot kolona(j) ot 2-rata, 
poluchenite rezultati se sybirat i se slagat v kletka (i, j) na rezultata
```C#
int[,] matrix1 = new int[,]
{
  { 1, 2, 3 },
  { 4, 5, 6 },
  { 7, 8, 9 }
};
int[,] matrix2 = new int[,]
{
  { 0, 1, 0 },
  { 7, 3, 4 },
  { 2, 6, 3 }
};
int[,] matrix3 = new int[,];
for(int i = 0; i < 3; i++)  // rows
{
  for(int j = 0; j < 3; j++)  //columns
  {
    matrix3[i, j] = 0;
    for(int k = 0; k < 3; k++)
    {
      matrix3[i, j] += matrix1[i, k] * matrix2[k, j];
    }
  }
}
for(int i = 0; i < 3; i++)
{
  for(int j = 0; j < 3; j++)
  {
    Console.Write(matrix3[i, j] + " ");
  }
 Console.WriteLine(); 
}
```
#### console class methods
**arr.Rank**                 dava broq na izmereniqta  
**arr.Length**               dava cqlata dyljina na masiva vyv vsichki izmereniq  
**arr.GetLength(0)**         dava dyljinata na edno izmerenie, v sluchaq (0)  
**arr.GetEnumerator()**      vryshta IEnumerator za elementite na masiva  
**arr.BunarySearch()**       tyrsi element v sortiran masiv  
**arr.IndexOf()**            vryshta indeksa na pyrviq nameren takyv element  

