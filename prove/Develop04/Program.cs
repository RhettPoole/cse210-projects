using System;

// Sources:
// https://www.tutorialspoint.com/csharp/csharp_inheritance.htm
// https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/object-oriented/inheritance

class Program
{
    static void Main(string[] args)
    {
        Menu.ShowMenu();
        int choice = Menu.GetChoice();

        // Perform actions based on the user's choice
        switch (choice)
        {
            case 1:
                // Perform Breathing Activity
                BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", GetDuration());
                breathingActivity.Run();
                break;
            case 2:
                // Perform Listing Activity
                ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", GetDuration());
                listingActivity.Run();
                break;
            case 3:
                // Perform Reflection Activity
                ReflectionActivity reflectionActivity = new ReflectionActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", GetDuration());
                reflectionActivity.Run();
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }

        Console.WriteLine("Thank you for using the Activity Program!");
    }

    static int GetDuration()
    {
        Console.Write("Enter the duration in seconds: ");
        return Convert.ToInt32(Console.ReadLine());
    }
}
