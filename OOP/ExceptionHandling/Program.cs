/* 
When an error occurs the execution or compliation of a program stops and throws an exception.

try - statement allows you to define a bloack of code to be tested for errors while it's being executed.

catch - allows you to define a block of code to be executed, if an error occurs in the try block.

finally - allows you to execute code after try...catch execution regradless of the result.

syntax: 
try 
{
  //  Block of code to try
}
catch (Exception e)
{
  //  Block of code to handle errors
}

throw - allows you to create a custom error.
*/

using System;
using System.IO;

namespace ExceptionHandling
{
    class Age
    {
        public void checkAge(int age)
        {
            if (age <= 18)
            {
                throw new ArithmeticException("Access denied - you must be at least 18 years of age!");
            }
            else
            {
                Console.WriteLine("Access granted. Do enjoy life and make memeories!");
            }
        }
    }
    class Program
    {
        static void Main()
        {
            try // Test 
            {
                int[] someNumbers = new int[4] { 1, 2, 3, 4 };
                Console.WriteLine(someNumbers[10]);
            }
            catch (Exception error) // if the test fails
            {
                Console.WriteLine(error.Message);
                Console.WriteLine(error.StackTrace);
            }
            finally // regardless of outcome
            {
                Console.WriteLine("The try...catch block is finished");
                Age newPerson = new Age();
                newPerson.checkAge(20);
            }
        }
    }
}