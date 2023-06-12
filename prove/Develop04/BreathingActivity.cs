using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int durationInSeconds)
        : base(name, description, durationInSeconds)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        PerformDeepBreathing();
        DisplayEndingMessage();
    }

    private void PerformDeepBreathing()
    {
        Console.WriteLine("Performing deep breathing...");

        // Assume each breath consists of an inhale and an exhale
        int breathCount = 0;
        int totalBreaths = GetDuration() / 6; // Each breath cycle takes 6 seconds (inhale + exhale)

        while (breathCount < totalBreaths)
        {
            Console.WriteLine("Breathe in...");
            CountdownTimer(3); // Countdown for inhale duration
            Console.WriteLine("Breathe out...");
            CountdownTimer(3); // Countdown for exhale duration
            breathCount++;
        }

        Console.WriteLine("Deep breathing exercise completed.");
    }

    private void CountdownTimer(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {
            Console.Write($"\r{i} second{(i > 1 ? "s" : "")} remaining...");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
