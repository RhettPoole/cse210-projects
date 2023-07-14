using System.Collections.Generic;

public class BaseballGame : Event
{
    private string stadium;  // Stadium for the baseball game
    private int capacity;  // Capacity of the baseball game

    public BaseballGame(string title, string description, string date, string time, Address address, string stadium, int capacity)
        : base(title, description, date, time, address)
    {
        this.stadium = stadium;  // Set the stadium for the baseball game
        this.capacity = capacity;  // Set the capacity of the baseball game
    }

    public override string GetFullDetails()
    {
        string details = "Full Details:\n";
        details += GetStandardDetails();  // Get the standard details from the base class
        details += $"Type: Baseball Game\n";
        details += $"Stadium: {stadium}\n";
        details += $"Capacity: {capacity}\n";
        return details;  // Return the full details of the baseball game
    }

    public override string GetShortDescription()
    {
        return $"Type: Baseball Game, Title: {base.eventTitle}, Date: {base.eventDate}";  // Return the short description of the baseball game
    }
}
