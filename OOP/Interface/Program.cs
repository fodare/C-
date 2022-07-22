using System;

namespace InterfaceExample
{
    // An interface is a complete abstract class which can only contain abstract methods and properties

    interface IAnimal
    {
        void animalSound();

    }

    class Pig : IAnimal // Implement class used to impment Interface methods
    {
        public void animalSound()
        {
            Console.WriteLine("Pig snorts erverwhere!");
        }
    }

    class Program
    {
        static void Main()
        {
            Pig myPig = new Pig();
            myPig.animalSound();

            DemoClass newClass = new DemoClass();
            newClass.myMethod();
            newClass.secondMethod();
        }
    }

}