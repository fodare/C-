using System;

namespace SAmpleMethods
{
    class Program
    {
        // Simple method which does not return a value thus the return type void
        static void Greetings()
        {
            Console.Clear();
            Console.WriteLine("Greeting method says hello!");
        }

        // Methods with Parameters
        static void NameCars(string[] carNames)
        {
            foreach (string car in carNames)
            {
                Console.WriteLine(car);
            }
        }

        // Methods with default values. Used as placeholder if user does not provide an argument in the merthod  call
        static string RepeatCountryName(string country = "Germany")
        {
            return country;
        }

        // Methods with multiple parameters.
        static void NameAge(string fName, int age)
        {
            Console.WriteLine($"{fName} is {age} years old!");
        }

        // Method with a return value
        static int AddTwoNumbers(int x, int y)
        {
            return x + y;
        }

        // Named Arguments
        static void NameChild(string child1, string child2)
        {
            Console.WriteLine($"The youngest child is {child2}");
        }

        // Method overloading
        static int DivideTwoNumbers(int x, int y)
        {
            return x / y;
        }

        static double DivideTwoNumbers(double x, double y)
        {
            return x / y;
        }

        static void Main(string[] args)
        {
            Greetings();
            NameCars(new string[] { "Volvo", "BMW", "Ford", "Mazda" });
            Console.WriteLine($"Your contry name is {RepeatCountryName("demmark")}");
            NameAge("Damilare", 19);
            int c = AddTwoNumbers(10, 11);
            Console.WriteLine($"The Value of c is: {c}");
            NameChild(child2: "Damilare", child1: "Bosun");

            int dividedNumberInt = DivideTwoNumbers(x: 10, y: 5);
            Console.WriteLine($"Int division is: {dividedNumberInt}");

            double dividedNumberDouble = DivideTwoNumbers(21.7, 23.7);
            Console.WriteLine($"Double division is: {dividedNumberDouble}");
        }
    }
}