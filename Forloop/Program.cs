using System;

namespace ForLoops
{
    class ForLoopExamples
    {
        static void Main()
        {
            // Basic For Loop
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Value of i is: {i}");
            }

            Console.Clear();

            // Basic foreach loop
            string[] userNames = { "Mike", "Townsend", "Balake", "John" };
            foreach (string i in userNames)
            {
                Console.WriteLine(i);
            }
        }
    }
}