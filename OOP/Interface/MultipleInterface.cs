using System;

namespace InterfaceExample
{
    interface IFirstInterface
    {
        void myMethod();
    }

    interface ISecondInterface
    {
        void secondMethod();
    }

    // Implement multiple interfaces
    class DemoClass : IFirstInterface, ISecondInterface
    {
        public void myMethod()
        {
            Console.WriteLine("Method call from the first interface");
        }

        public void secondMethod()
        {
            Console.WriteLine("Method call from the second interface");
        }
    }
}