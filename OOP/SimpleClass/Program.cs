using System;
namespace Sampleapplication;

class Program
{
    static void Main()
    {
        Car Ford = new Car();
        Ford.color = "Blue";
        Ford.door = 4;
        Ford.maxSpeed = 250;

        Car Toyota = new Car();
        Toyota.color = "Black";
        Toyota.door = 2;
        Toyota.maxSpeed = 200;


        Console.WriteLine(Ford.color);
        Console.WriteLine(Ford.door);
        Console.WriteLine(Ford.maxSpeed);

        Console.WriteLine("********************");
        Console.WriteLine(Toyota.color);
        Console.WriteLine(Toyota.door);
        Console.WriteLine(Toyota.maxSpeed);

        Ford.SpeedUp();
    }
}