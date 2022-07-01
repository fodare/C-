using System;

namespace VariableExample
{
    class Variables
    {
        static void Main()
        {
            // Declaring a variable
            int age = 10;
            string name = "Damilare";

            // You can also declear a variable without value
            string country;
            country = "Germany";

            // Displaying variable values
            Console.WriteLine("Hello " + name + " you are " + age);

            // To declare a static variable. Use the cost keyword at the beginning of the declaration
            const double pi = 3.14159;

            // declaring many variabes of same type
            int x = 5, y = 6, z = 7;

            // declaring many variables with the same value
            int a, b, c;
            a = b = c = 10;
            Console.WriteLine(a + b + c);
        }

    }
}