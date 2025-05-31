// See https://aka.ms/new-console-template for more information

using System;

namespace StringLengthCounter1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the String Length Counter!");
            Console.WriteLine("-------------------------------------");

            bool continueCounting = true;

            while (continueCounting)
            {
                Console.WriteLine("\nEnter a string (or type 'exit' to quit):");

                // Read the user's input
                string? inputString = Console.ReadLine(); // Use string? for nullability

                // Check if the user wants to exit
                if (inputString?.ToLower() == "exit")
                {
                    continueCounting = false;
                    Console.WriteLine("Exiting the application. Goodbye!");
                    break; // Exit the loop
                }

                // Check if the input is null or empty after trimming whitespace
                if (string.IsNullOrWhiteSpace(inputString))
                {
                    Console.WriteLine("You didn't enter anything. Please try again.");
                    continue; // Go back to the start of the loop
                }

                // Calculate the length of the string
                int length = inputString.Length;

                // Display the length
                Console.WriteLine($"The length of your string is: {length}");
            }
        }
    }
}