using System;

namespace IfStatement
{
    class IfStatementExample
    {
        static void Main()
        {
            // Simple If else statement
            int a = 20;
            double b = 20.01;
            if (b > a)
            {
                Console.WriteLine($"{b} is grater then {a}");
            }
            else
            {
                Console.WriteLine($"{a} id grater than {b}");
            }

            // Simple else if statement
            int time = 22;
            if (time < 10)
            {
                Console.WriteLine("Hello, good morning!");
            }
            else if (time < 18)
            {
                Console.WriteLine("Hello, good afernoon");
            }
            else
            {
                Console.WriteLine("Hello, good evening");
            }

            // Ternary Operator
            int value = 20;
            string result = (value < 10) ? $"{value} is grater then 10" : $"10 is lesser than {value}";
            Console.WriteLine(result);
        }
    }
}