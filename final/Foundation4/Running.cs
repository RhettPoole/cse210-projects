/// sources:
/// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods#method-overriding

using System;

public class Running : Activity
{
    private double distance;  // Distance covered during the running activity

    public Running(DateTime date, int durationMinutes, double distance)
        : base(date, durationMinutes)
    {
        this.distance = distance;  // Set the distance covered during the running activity
    }

    public override double GetDistance()
    {
        return distance;  // Return the distance covered during the running activity
    }

    public override double GetSpeed()
    {
        // Calculate and return the speed in miles per hour
        return distance / (base.durationMinutes / 60.0);
    }

    public override double GetPace()
    {
        // Calculate and return the pace in minutes per mile
        return (base.durationMinutes / distance);
    }
}
