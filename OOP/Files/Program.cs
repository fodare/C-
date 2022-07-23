using System;
using System.IO;

namespace FileManipulationExample
{
    class Program
    {
        static void Main()
        {
            // Creating files and writting message to the file
            string secretMessage = "Borris Johnson resigned";
            File.WriteAllText("message.txt", secretMessage);
            Console.WriteLine("Message written to file successfully!");

            // Reading message from file
            string extractedMessage = File.ReadAllText("message.txt");
            Console.WriteLine($"Secret message is: {extractedMessage}");
        }
    }
}