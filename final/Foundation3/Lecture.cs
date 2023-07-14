using System.Collections.Generic;

public class Lecture : Event
{
    private string speaker;  // Speaker for the lecture
    private int capacity;  // Capacity of the lecture

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        this.speaker = speaker;  // Set the speaker for the lecture
        this.capacity = capacity;  // Set the capacity of the lecture
    }

    public override string GetFullDetails()
    {
        string details = "Full Details:\n";
        details += GetStandardDetails();  // Get the standard details from the base class
        details += $"Type: Lecture\n";
        details += $"Speaker: {speaker}\n";
        details += $"Capacity: {capacity}\n";
        return details;  // Return the full details of the lecture
    }

    public override string GetShortDescription()
    {
        return $"Type: Lecture, Title: {base.eventTitle}, Date: {base.eventDate}";  // Return the short description of the lecture
    }
}
