using System;

public class Menu
{
    public static void ShowMenu()
    {
        Console.WriteLine("Welcome to Activity Program!");
        Console.WriteLine("Please select an activity:");

        // Display menu options
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Listing Activity");
        Console.WriteLine("3. Reflection Activity");
    }

    public static int GetChoice()
    {
        Console.Write("Enter the number of your choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        return choice;
    }
}
