using System;

public class StationaryBicycle : Activity
{
    private double speed;  // Speed of the stationary bicycle

    public StationaryBicycle(DateTime date, int durationMinutes, double speed)
        : base(date, durationMinutes)
    {
        this.speed = speed;  // Set the speed of the stationary bicycle
    }

    public override double GetDistance()
    {
        // Calculate and return the distance covered based on the speed and duration
        return speed * (base.durationMinutes / 60.0);
    }

    public override double GetSpeed()
    {
        return speed;  // Return the speed of the stationary bicycle
    }

    public override double GetPace()
    {
        // Calculate and return the pace in minutes per mile
        return (60.0 / speed);
    }
}
