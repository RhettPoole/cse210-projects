using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the Journal class
        Journal journal = new Journal();

        // Array of prompts
        string[] prompts = { "What did you learn today?", "How do you feel right now?", "What are you grateful for today?" };

        bool exit = false;

        while (!exit)
        {
            // Display the menu
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load entries from a file");
            Console.WriteLine("5. Clear all entries");
            Console.WriteLine("6. Exit");

            // Prompt the user for action
            string input = Console.ReadLine();

            // Process user input
            switch (input)
            {
                case "1":
                    // Get a random prompt from the array
                    Random rand = new Random();
                    string prompt = prompts[rand.Next(prompts.Length)];

                    // Ask the user for their response to the prompt
                    Console.Write(prompt + " ");
                    string response = Console.ReadLine();

                    // Add the entry to the journal
                    journal.AddEntry(prompt, response);

                    break;

                case "2":
                    // Display all entries in the journal
                    journal.DisplayEntries();
                    break;

                case "3":
                    // Prompt the user for a filename
                    Console.WriteLine("Enter a filename to save the journal:");
                    string filename = Console.ReadLine();

                    // Save the journal to a file
                    journal.SaveToFile(filename);

                    break;

                case "4":
                    // Prompt the user for a filename
                    Console.WriteLine("Enter a filename to load entries from:");
                    string loadFilename = Console.ReadLine();

                    // Load entries from a file
                    journal.LoadFromFile(loadFilename);

                    break;

                case "5":
                    // Clear all entries
                    journal.ClearEntries();
                    break;

                case "6":
                    // Exit the program
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }
        }
    }
}