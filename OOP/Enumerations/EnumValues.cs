/*
By default, the first item of an enum has the value 0. The second has the value 1, and so on.

To get the integer value from an item, you must explicitly convert the item to an int 
*/

using System;

namespace EnumExample
{
    enum Months
    {
        January,
        Feburary,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        Novemeber,
        December
    }

    // You can also assign your own enum values.

    enum Names
    {
        Damilare = 10,
        Bosun = 20,
        Dare = 30,
        Daniel = 40
    }
}