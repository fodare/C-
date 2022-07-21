using System;

namespace Encapsulation
{
    /* Encapsulation is the process of keeping sensitve data hidden from users and only accessble
    trough

    The idea is to make sensitive data private then use properties {get; set; } to retrive and initilize the field.
    */

    class EncapsulationExample
    {
        class Person
        {
            private string name;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }
        }

        class Program
        {
            static void Main()
            {
                Person person1 = new Person();
                person1.Name = "Damilare";
                Console.WriteLine(person1.Name);
            }
        }
    }
}