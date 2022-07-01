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
