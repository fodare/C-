using System;

namespace ArrayExample
{
    class Arrays
    {
        static void Main()
        {
            string[] favouriteNames = { "Larry", "Garry", "Barry", "Karry" };
            string newName = favouriteNames[2];
            Console.WriteLine(newName); // Outout would be Barry

            // Changing Element of an array
            newName = "Damilare";
            favouriteNames[2] = newName;
            Console.WriteLine(favouriteNames[2]);

            // Getting the number of items within an array
            Console.WriteLine($"The number of items withn array favouriteNames is: {favouriteNames.Length}");

            // Looping trough an array using Foor loop
            for (int i = 0; i < favouriteNames.Length; i++)
            {
                Console.WriteLine(favouriteNames[i]);
            }

            // Other ways of creating arrays on c#

            // Create an array of four elements, and add values later
            // string[] cars = new string[4];

            // Create an array of four elements and add values right away 
            // string[] cars = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

            // Create an array of four elements without specifying the size 
            // string[] cars = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

            // Create an array of four elements, omitting the new keyword, and without specifying the size
            // string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

            // However, you should note that if you declare an array and initialize it later, you have to use the new keyword:

            // Declare an array
            // string[] cars;

            // Add values, using new
            // cars = new string[] { "Volvo", "BMW", "Ford" };

            // Add values without using new (this will cause an error)
            // cars = { "Volvo", "BMW", "Ford" };

            // Sorting an array
            Array.Sort(favouriteNames);

            Console.WriteLine("Sorted list is: ");

            foreach (string x in favouriteNames)
            {
                Console.WriteLine(x);
            }

            //Other useful array methods, such as Min, Max, and Sum, can be found in the System.Linq namespace.
        }
    }
}