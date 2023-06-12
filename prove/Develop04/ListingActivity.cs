using System;

// Sources:
// https://learn.microsoft.com/en-us/dotnet/api/system.datetime.now?view=net-7.0

public class ListingActivity : Activity
{
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string name, string description, int durationInSeconds)
        : base(name, description, durationInSeconds)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.WriteLine("Take a moment to think...");
        Console.WriteLine("Press any key to start listing items.");

        Console.ReadKey();
        Console.Clear();

        int itemCounter = StartListing();

        Console.WriteLine($"Number of items listed: {itemCounter}");
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Length);
        return prompts[index];
    }

    private int StartListing()
    {
        int itemCounter = 0;
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write($"{itemCounter + 1}. ");
            string item = Console.ReadLine();

            if (string.IsNullOrEmpty(item))
            {
                break; // Exit the loop if the user enters an empty item
            }

            itemCounter++;
        }

        return itemCounter;
    }


    private void CountdownTimer(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {
            Console.Write($"\r{i} second{(i > 1 ? "s" : "")} remaining...");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
