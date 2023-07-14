using System;

public class Swimming : Activity
{
    private int laps;  // Number of laps swam during the swimming activity

    public Swimming(DateTime date, int durationMinutes, int laps)
        : base(date, durationMinutes)
    {
        this.laps = laps;  // Set the number of laps swam during the swimming activity
    }

    public override double GetDistance()
    {
        // Calculate and return the distance covered based on the number of laps (assuming 1 lap = 50 meters) and conversion to miles
        return laps * 50.0 * 0.62 / 1000.0;
    }

    public override double GetSpeed()
    {
        // Calculate and return the speed in miles per hour based on the distance covered and duration of the activity
        return (GetDistance() / (base.durationMinutes / 60.0));
    }

    public override double GetPace()
    {
        // Calculate and return the pace in minutes per mile based on the duration of the activity and distance covered
        return (base.durationMinutes / GetDistance());
    }
}
