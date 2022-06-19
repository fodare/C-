class ConsoleClassExample
{
    static void Main()
    {
        // WriteLine method. Used to print multiline statement
        System.Console.WriteLine("Application");
        System.Console.WriteLine("says");
        System.Console.WriteLine("Hello");

        // ReadKey method. Used to receive instructions / values from the user.
        System.Console.ReadKey();

        // Write method. Used to  print a statement on the same line.
        System.Console.Write("Hello World is an old statement. Use Application says hello!");

        // Clear mthod. This is used to clear contenets on the console screen
        System.Console.Clear();

        // ReadLine method. Used to collect values from users input and store them into a variable.
        String x = System.Console.ReadLine();
        System.Console.WriteLine(x);
    }
}