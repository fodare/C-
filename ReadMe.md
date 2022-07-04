# Basics of C #

A personal journal like documentation to help document some C# lessons.
VS Code dotnet documentation [VS Code dotnet tutorial](https://docs.microsoft.com/en-us/dotnet/core/tutorials/library-with-visual-studio-code?pivots=dotnet-6-0).

## Intro ##

C# is an OOP language that runs on the dotnet framework. It can be used to develop or program web application or services, mobile applications, desktop applications ...

## Syntax ##

A basic C# program has this following syntax below.

~~~ C#
using System;
// small cosole program to print hello world.
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
~~~

- The keyword <code>using System</code> means the program can use other classes from the System namespace.

- <code>Namespace</code> a keyword to signify a container of other classes. Mostly used to help organize programs.

- <code>Class</code> collection of data fields and methods.

- <code>Main</code> the entry point for program execution.

## Output ##

To output values or messages to the console, you can use either the <code>WritLine()</code> or <code>Write()</code> method of the console calss. Example syntax below:

~~~ c#
Console.WriteLine("Hello World!");
Console.Write("Hello World!");
~~~

The difference between the two is that, <code>WritLine()</code> method prints values in a new line while <code>Write()</code> method print values on the same line.

## Variables ##

They are containers created in the computer memory to help hold temporary data. In C# there are various types of variables, but common ones are :

- <code>Int</code> signifies numerical values without decimal places or point. Example 123, -123, 10 ...

- <code>double</code> signifies numerical values with floating points. Example is 10.99, 12.00, 30.01…

- <code>char</code> signifies a single word or character. Example 'A', 'b'...

- <code>string</code> signifies text. Different from <code>char</code> as it's more that just a single character. Example "This is a string".

- <code>bool</code> signifies a "true" or "false" value.

### Syntax ##

~~~c#
type variableName = value;
~~~

## Identifiers ##

These are unique names to help give name to variables. Identifiers can be short names (like x and y) or more descriptive names (age, sum, totalVolume).

General rule for naming variables are:

- Can contain letters, digits and underscore(_).
- Must begin with a letter.
- Starts with lowercase word and no white spaces.
- Names are case-sensitive.
- Must not contain c# reserved words.

## DataTypes ##

Reserved words to signify type and size of variables. The most common data types are:

| Data Type   | Size        | Description     |
| :---        |    :----:   |          ---: |
| int      | 4 bytes       | Whole numbers from -2,147,483,648 to 2,147,483,647.  |
| long   | 8 bytes        | Whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807.      |
| float   | 4 bytes        | fractional numbers. Sufficient for storing 6 to 7 decimal digits.     |
| double   | 8 bytes        | Stores fractional numbers. Sufficient for storing 15 decimal digits.      |
| char   | 2 bytes        | Stores a single character/letter.  |
| string   | 2 bytes per character        | Stores a sequence of characters.      |

## Type Casting ##

Is when you convert or assign a value of one data type to another. There are 2 types of casting in C# namely:

- Implicit casting: Converting from a smaller type to much larger type. Example is: <code>char</code> → <code>int</code> → <code>long</code> → <code>float</code> → <code>double</code>. This type of casting is done automatically.

- Explicit casting: Converting a much larger type to a smaller data type. Example is: <code>double</code> → <code>float</code> → <code>long</code> → <code>int</code> → <code>char</code>. This type of casting has to be done manually by placing the target type in parentheses in front of the parent value. Example below:

~~~c#
 double amount = 9.78;
 int finalAmount = (int)amount;
~~~

## Type Conversion Methods ##

C# has built-in methods that help with type conversion. Method names are :

- <code>Convert.ToBoolean</code>
- <code>Convert.ToDouble</code>
- <code>Convert.ToString</code>
- <code>Convert.ToInt32</code>
- <code>Convert.ToInt64</code>

## User Input ##

To receive uses inputs to a program, you can use the <code>ReadLine()</code> method from the Console class. The methods accept values entered by users and by default store them in string type, so you have to explicitly convert values to target data type

## Math functions ##

C# does have some built-in math methods from Math class to help perform math functions. Sample methods are:

- <code>Max</code> used to find the highest value of two numerical values.
- <code>Min</code> used to find the lowest value of two numerical values.
- <code>Sqrt</code> Find square root of a numerical value.
- <code>Abs</code> help returns absolute positive value of a numerical value.
- <code>Round</code> Helps round up a number to the nearest whole number.

## Conditions and If statements ##

C# does support some basic math logical conditional comparisons, and they can be used for actions to help make decisions in a program. C# supports following conditional statements.

- <code>if</code> determine a block of code to be executed if a specified condition is true.
- <code>else</code> determine a block of code to be executed if the same condition is false.
- <code>else if</code> determine a block of code to be executed if the first condition is false.
- <code>switch</code> specifies many alternative code block to be executed depending on an outcome.

C# also support ternary Operator to help shorten <code>if..else</code> statement and below is its syntax:

<code>variable = (condition) ? expressionTrue :  expressionFalse;</code>
