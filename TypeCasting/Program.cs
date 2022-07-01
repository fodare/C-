using System;

namespace Typecasting
{
    class TypeCastingExample
    {
        static void Main()
        {
            // Implict casting
            int sampleInt = 10;
            double sampleDouble = sampleInt;
            Console.WriteLine(sampleDouble);

            // Explicit casting
            double amount = 9.78;
            int finalAmount = (int)amount;

            Console.WriteLine(finalAmount);


            // C# type conversion methods
            int x = 30;
            double y = 30.00;
            bool isDay = false;

            Console.WriteLine(Convert.ToString(x));
            Console.WriteLine(Convert.ToDouble(x));
            Console.WriteLine(Convert.ToInt32(y));
            Console.WriteLine(Convert.ToString(isDay));
        }
    }
}