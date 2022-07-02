using System;

namespace MathMethods
{
    class MathMethodsExample
    {
        static void Main()
        {
            // C# math methods

            // Max methods
            int x = 10;
            int y = 50;
            Console.WriteLine("The max value of the  two numbers is: " + Math.Max(x, y));

            // Min methods
            Console.WriteLine("The min value of the two numbers is: " + Math.Min(x, y));

            // Square root method
            int z = 49;
            Console.WriteLine("The square root of the number is: " + Math.Sqrt(z));

            // Abosulte method
            double a = -14.24;
            Console.WriteLine("The absolute positive value is: " + Math.Abs(a));

            // Round method
            double b = 20.50;
            Console.WriteLine("The rounded value of the value is: " + Math.Round(b));
        }
    }
}