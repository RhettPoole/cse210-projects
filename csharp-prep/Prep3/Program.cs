using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        Console.Write("What is the magic number? ");
        int magicNumber = int.Parse(Console.ReadLine());
        */

        Random randomGenerator = new Random();  // Random number generator
        int magicNumber = randomGenerator.Next(1, 101);

        int userGuess = -1; // Define what "userGuess" outside of the parameters of the 'while' so it will start.

        while (userGuess != magicNumber) // Define the parameters of the 'while'. 
        {
            Console.Write("The number is between 1 - 101, what is your guess? ");
            userGuess = int.Parse(Console.ReadLine()); // Convert the user's guess from a string to an integer.
            if (userGuess > magicNumber) // less than, lower
            {
                Console.WriteLine("Lower");
            }
            else if (userGuess < magicNumber) // greater than, higher
            {
                Console.WriteLine("Higher"); 
            }
            else    // the user guessed the right number, and 'while' loop stops.
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}
