using System;
using System.Collections.Generic; // You must have this at the top of every file that has lists, or standard collections.

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");

        /*
        List<int> numbers = new List<int>(); // To define a new list.

        numbers.Add(18); // To add items to a list.
        numbers.Add(20);

        Console.WriteLine(numbers.Count); // To print the size of a list, notice there's no parenthesis after the "count" because it is a property, not a function.

        foreach (int number in numbers) // The best (and safest) way to iterate through a list.
        {
            Console.WriteLine(number);
        }

        for (int i = 0; i < numbers.Count; i++)    // To access items by their index.
        {
            Console.WriteLine(numbers[i]);
        }
        */



        List<int> numbers = new List<int>(); // Create an empty list

        int userNumber = -1; // define userNumber outside parameters of the while loop
        while (userNumber != 0) // define parameters
        {
            Console.Write("Enter a number (0 to quit): ");// prompt user
            string userResponse = Console.ReadLine(); // define variable for userResponse

            userNumber = int.Parse(userResponse);// convert to integer

            if (userNumber != 0) // set parameter for 0 not being added to the list.
            {
                numbers.Add(userNumber);
            }

    }

        // Compute the sum
        int sum = 0; // set the base for sum
        foreach (int number in numbers)  // set parameters, make sure to define variable type for "number", notice that "number" isn't defined anywhere else.
        {
            sum += number;
        }

        Console.WriteLine($"The sum is {sum}");

        // Compute the average. You must convert the int, to a float.
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        //Find the max, by sorting the list.

        int max = numbers[0]; // Define max outside of the parameters of "foreach"

        foreach(int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");

    }
}