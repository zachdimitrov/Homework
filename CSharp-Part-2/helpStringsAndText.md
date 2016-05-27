#### What is String
- sequence of chars
- each character is Unicode symbol
- represented by string data type in System.String object in .NET Framework
- immutable (readonly) sequence of characters, ne mojem da promenqme stringa a trqbva da syzdaden nov
- stringovete sa referenten tip 
- pazqt se v dynamic memory (managed heap)  
- default stoinost e Null - kato vseki referenten type

##### rabota sys stringove
`ReferenceEquals(p, p2)` proverqva dvete stoinosti dali sa referencii kym edno i syshto neshto    
`string p = "pesho";` char a = p[2]; // a = 's'   
`string empty = String.Empty;` syzdavane na prazen string  

##### leksikografsko sravnqvane
`string.Compare(str1, str2)` vryshta int rezultat: 0 - equal, -1 ako pyrvoto e po-malko, 1 - ako pyrvoto e po-golqmo    
`string.Compare(str1, str2, true)` slaga - ignore case  

##### concatenirane
```C#
string[] words = new string[] {"gosho", "tosho", "meow"};
string conc = string.Concat(words[0] + words[1] + word[2]); // po-dobriq nachin e stringbuilder
```
##### search in strings


