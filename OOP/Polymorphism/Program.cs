using System;

namespace PolymorphismExample
{
    class Animal
    {
        public virtual void animalSound()
        {
            Console.WriteLine("This animal makes a sound!");
        }
    }

    class Dog : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("Dog barks!");
        }
    }

    class Bird : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("Bird sings");
        }

    }

    class PRogram
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            Animal myDog = new Dog();
            Animal myBird = new Bird();

            myAnimal.animalSound();
            myBird.animalSound();
            myDog.animalSound();
        }
    }
}