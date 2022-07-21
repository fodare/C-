using System;

namespace InheritanceExample
{
    /*
    Inheritance is the process of a class deriving it's properties from another class.
    2 types of categories: Parent class and Derived class.
    */
    class Vehicle
    {
        public string name;

        public void honk()
        {
            Console.WriteLine("Tuut, tuut");
        }
    }

    class Car : Vehicle // Inheritance from parent class Vehicle
    {
        public string modelName = "Ford Mustang";
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();

            Console.WriteLine(car1.modelName);
            car1.honk();
        }
    }
}
