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
**decimal**|-79228162514264337593543950335 .. 79228162514264337593543950335| ```decimal 4.5m; ```

###### other non number types

*type*| *range* | *literal*
---|---|---
**char**|A Unicode character.| ```char a = 'a'; ```
**string**|A string of Unicode characters.| ```string s = "string"; ```
**bool**|True or False.| ```bool b = True; ```
**object**|An object.| ```object o; ```
