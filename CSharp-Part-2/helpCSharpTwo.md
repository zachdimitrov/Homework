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
