using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        Console.WriteLine("Hello Prep3 World!");

        for (int i = 2; i <= 20; i++)
        {
            Console.WriteLine(i);
        }
        */

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}