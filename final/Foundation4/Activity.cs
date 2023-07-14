/// sources:
/// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/abstract-and-sealed-classes-and-class-members

using System;

public abstract class Activity
{
    protected DateTime date;  // Date of the activity
    protected int durationMinutes;  // Duration of the activity in minutes

    public Activity(DateTime date, int durationMinutes)
    {
        this.date = date;  // Set the date of the activity
        this.durationMinutes = durationMinutes;  // Set the duration of the activity in minutes
    }

    public abstract double GetDistance();  // Abstract method to get the distance of the activity
    public abstract double GetSpeed();  // Abstract method to get the speed of the activity
    public abstract double GetPace();  // Abstract method to get the pace of the activity

    public string GetSummary()
    {
        // Generate a summary of the activity including date, type, duration, distance, speed, and pace
        string summary = $"{date.ToString("dd MMM yyyy")} {GetType().Name} ({durationMinutes} min) - ";
        summary += $"Distance: {GetDistance()} miles, ";
        summary += $"Speed: {GetSpeed()} mph, ";
        summary += $"Pace: {GetPace()} min per mile";
        return summary;  // Return the generated summary
    }
}
