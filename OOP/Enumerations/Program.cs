using System;

namespace EnumExample
{
    // Emum is special class that represents a group of constants
    class EnumExample
    {
        // Create an enum
        enum GameLevel
        {
            Low, Medium, High
        }

        // Access items
        class Program
        {
            static void Main()
            {
                GameLevel userGameLevel = GameLevel.Medium;
                Console.WriteLine(userGameLevel);
                Console.WriteLine("");

                int myMonth = (int)Months.July;
                Console.WriteLine(myMonth);
                Console.WriteLine("");

                int myName = (int)Names.Damilare;
                Console.WriteLine(myName);
                Console.WriteLine("");



                // You can also use switch statement with enum
                int myNames = (int)Names.Daniel;
                Console.WriteLine(myNames);
                switch (myNames)
                {
                    case 10:
                        Console.WriteLine($"Value is: {myNames} with name: Damilare!"); break;

                    case 20:
                        Console.WriteLine($"Value is: {myNames} withe name Bosun!"); break;

                    case 30:
                        Console.WriteLine($"Value is: {myNames} with name Dare!"); break;

                    case 40:
                        Console.WriteLine($"Value is: {myNames} with name Daniel!"); break;
                }
            }
        }

    }
}