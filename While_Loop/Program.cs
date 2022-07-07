using System;

namespace WhileLoopExample
{
    class WhileExample
    {
        static void Main()
        {
            int x = 0;
            // Example of a while loop.
            while (x < 5)
            {
                Console.WriteLine($"{x} is lesser than 5. Incrementing");
                x++;
            }

            // Example of do while loop

            bool gameOn = true;

            do
            {
                Console.WriteLine("Is the game on. Enter (yes / no ): ");
                string answer = Console.ReadLine();

                if (answer == "yes")
                {
                    continue;
                }
                else
                {
                    gameOn = false;
                    Console.WriteLine("Thanks. Stopping application!");
                }
            } while (gameOn);
        }
    }
}