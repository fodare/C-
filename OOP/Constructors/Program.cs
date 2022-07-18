using System;

namespace ConstructorExample
{
    class Program
    {
        static void Main()
        {
            Car Ford = new Car();
            Console.WriteLine($"Model: {Ford.model}");
            Console.WriteLine($"Year: {Ford.year}");
            Console.WriteLine($"Color: {Ford.color}");

        }

    }
}