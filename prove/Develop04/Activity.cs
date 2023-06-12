using System;

public class Activity
{
    private string _name; // Name of the activity
    private string _description; // Description of the activity
    private int _durationInSeconds; // Duration of the activity in seconds

    public Activity(string name, string description, int durationInSeconds)
    {
        _name = name;
        _description = description;
        _durationInSeconds = durationInSeconds;
    }

    public void DisplayStartingMessage()
    {
        // Display the starting message for every activity.
        Console.WriteLine($"Starting {_name}...");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Duration: {_durationInSeconds} seconds.");
    }

    public void DisplayEndingMessage()
    {
        // Display the ending message for every activity.
        Console.WriteLine($"Congratulations! You have completed {_durationInSeconds} seconds of the {_name}.");
    }

    public int GetDuration()
    {
        return _durationInSeconds;
    }
}
