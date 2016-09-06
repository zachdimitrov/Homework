## 2. High Quality Code

#### High Quality Code - What is it?
- Easy to read and understand
  - Easy to modify and maintain
- Correct behavior in all cases
  - Well tested
- Well architectured and designed
- Well documented
  - Self-documenting code
- Well formatted  

#### Code Conventions
- Formatting
- Naming
- Best practices

#### Managing Complexity
- Complexity ammount
- Architecture and design
- Code construction

#### Code Quality
- Correct behavior
  - Conforming to the requirements
  - Stable, no hangs, no crashes
  - Bug free – works as expected
  - Correct response to incorrect usage
- Readable – easy to read
- Understandable – self-documenting
- Maintainable – easy to modify when required 
- Good identifiers' names
  - Good names for variables, constants, methods, parameters, classes, structures, fields, properties, interfaces, structures, enumerations, namespaces,
- High-quality classes, interfaces and class hierarchies
  - Good abstraction and encapsulation
  - Simplicity, reusability, minimal complexity
  - Strong cohesion, loose coupling
- High-quality methods
  - Reduced complexity, improved readability
  - Good method names and parameter names
  - Strong cohesion, loose coupling
-   - Variables, data, expressions and constants
  - Minimal variable scope, span, live time
  - Simple expressions
  - Correctly used constants
  - Correctly organized data
- Correctly used control structures
  - Simple statements
  - Simple conditional statements and simple conditions
  - Well organized loops without deep nesting
- Good code formatting
  - Reflecting the logical structure of the program
  - Good formatting of classes, methods, blocks, whitespace, long lines, alignment, etc.
- High-quality documentation and comments
  - Effective comments
  - Self-documenting code
- Defensive programming and exceptions
Ubiquitous use of defensive programming
  - Well organized exception handling
- Code tuning and optimization
  - Quality code instead of good performance
  - Code performance when required
- Following the corporate code conventions
  - Formatting and style, naming, etc.
  - Domain-specific best practices
- Well tested and reviewed
  - Testable code
  - Well designed unit tests
    - Tests for all scenarios
    - High code coverage
  - Passed code reviews and inspections

## 3.Code Formatting

#### What is it needed for
- Good formatting goals
  - To improve code readability
  - To improve code maintainability
- Fundamental principle of code formatting:
  - Any (consistent) formatting style that follows the above principle is good
  - Good formatting don’t affect speed, memory use or other aspects of the program

##### Blocks 
- C# { and } alone on single lines, indent the code block one tab  
- JS - { on the same line, and } alone on the last line  

##### Brackets  
- use them to group operations - obligatory - ```x = (3 + 4) * (2 + 7);```  
- no spaces betweenbrackets and expressions - ```Factorial(uint num);```  

##### Empty lines  
- one empty line for separation between methods   
- or logically related code parts

##### separation   
- separate parameters by comma and one space ```(one, two)```  

##### order of definitions  
- Use the following order of definitions:
  - Constants, delegates, inner types, fields, constructors, properties, methods
  - Static members, public members, protected members, internal members, private members

##### line break
- brake after punctuation or operators
- one tab indent after brake in C# and 2 in JS

## 4.Naming Identifiers
- Always use **English**
- Avoid abbreviations unless accepted ones
- Avpid hard to pronounce names
- Use meaningfull names
- Use context names too - ```Account.Deposit()```
 
 #### Naming Conventions
- in C# classes, structures etc. are in **PascalCase** - [Adjective] + [Noun]  
- Interfaces - 'I' + [Verb] + 'able' or 'I' + [Noun] or 'I' + [Adjective] + [Noun]  
- Enumerations - [Noun] or [Verb] or [Adjective] - content is **PascalCase**  
- Special classes - **Attribute**, **Collection**, **Exception** suffix - ```StringsCollection```  
- dont abbreviate names  
- namespaces - **PascalCase**
- file name the same as class name - PascalCase for C#, no capitals for JS
- assembly name the same as root namespace
- Methods in C# - **PascalCase**, JS - **camelCase**
- Variable names - **camelCase** - [Noun] or [Adjective] + [Noun]
- Boolean - should reflect on the name - ```isPrime```
- counters ```ticketCount```, state ```threadState```, conventions for these names
- constants ```CAPITAL_LETTERS``` or ```PascalCase``` 

## 5.Comments and Documentation

#### Self Documenting
- program structure
- readable code
- good naming
- clear abstractions
- minimized complexity
- Loose coupling and strong cohesion

#### Effective comments
- Do not repeat the code
- Comment code intent ask why

#### XML Documentation  
```C#
<summary>
<param name="name">description</param>
<returns>
<remarks>
<c> and <code>
<see> and <seealso>
<c> and <code>
Gives you a way to indicate code
<see> and <seealso> and cref
Code reference <seealso cref="TestClass.Main"></seealso>
<exception>
```
