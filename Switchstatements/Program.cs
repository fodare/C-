using System;

namespace SwitchStatementExample
{
    class SwitchExample
    {
        static void Main()
        {
            /* C# Switch statements is generally used to select a block of code to be excuted when
            there are multiple reaults an expression could return. Example below
            */

            int day = 4;

            switch (day)
            {
                case 1: Console.WriteLine("Day is Monday!"); break;
                case 2: Console.WriteLine("Day is Tuesday!"); break;
                case 3: Console.WriteLine("Day is Wednesday!"); break;
                case 4: Console.WriteLine("Day is Thursday!"); break;
                case 5: Console.WriteLine("Day is Friday!"); break;
                case 6: Console.WriteLine("Day is Saturday!"); break;
                case 7: Console.WriteLine("Day is Sunday!"); break;
            }
        }
    }
}