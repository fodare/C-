using System;

namespace AbstractionExample
{
    /*
    Abstraction is the process of hiding certain detais from users and only show essential information

    Abstract class: A restricted class the cannot be used to create objects 

    Abstract method: Can only be used in an abstract class and does not have a body. The body is provided
                    In the derived class.
    */

    abstract class Animal
    {
        public abstract void animalSound(); // An abstract method

        public void sleep()
        {
            Console.WriteLine("Zzzzzz.");
        }
    }

    class Pig : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("Pig snorts everywhere");
        }
    }

    class Program
    {
        static void Main()
        {
            Pig myPig = new Pig();
            myPig.animalSound();
            myPig.sleep();
        }
    }
}