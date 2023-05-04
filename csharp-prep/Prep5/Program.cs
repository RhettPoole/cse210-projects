using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep5 World!");
        /*
        returnType FunctionName(dataType parameter1, dataType parameter2)
        {
            //function_body
        }


        Console.WriteLine($"{AddNumbers(1, 2)}");

        AddingNumbers(1,2);

        int AddNumbers(int first, int second)
        {
            int sum = first + second;
            return sum;
        }

        // use the word "static" in front of all functions defined for now. This causes the function to be called without any context.

        static void DisplayMessage()
        {
            Console.WriteLine("Hello world!");
        }

        static void DisplayPersonalMessage(string userName)
        {
            Console.WriteLine($"Hello {userName}");
        }

        static int AddingNumbers(int first, int second)
        {
            int sum = first + second;
            return sum;
        }
        */

        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptFavNumber();
        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);


        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");   // Welcome message
        }

        static string PromptUserName() // set no parameters because, idk ask ChatGPT
        {
            Console.Write("What is your name?: "); // Prompt
            string userName = Console.ReadLine(); // Store value
            return userName; // Return value
        }

        static int PromptFavNumber() // set function with no parameters
        {
            Console.Write("What is your favorite number?: ");   // Prompt for favorite number
            int userNumber = int.Parse(Console.ReadLine());
            return userNumber;
        }

        static int SquareNumber(int userNumber)
        {
            int square = userNumber * userNumber;
            return square;
        }

        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your favorite number is {square}.");
        }

    }
}