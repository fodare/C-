using System;

namespace UserInput
{
    class USerInputExample
    {
        static void Main()
        {
            // Tell user what to enter
            Console.WriteLine("Please enter your name below: ");

            // ReadLine method is used to accept values from user
            string userName = Console.ReadLine();

            Console.WriteLine("Please enter your age below: ");

            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello " + userName + " you are " + age);

        }
    }
}