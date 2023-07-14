using System.Collections.Generic;

public class PoolParty : Event
{
    private string poolParty;  // Weather forecast for the pool party

    public PoolParty(string title, string description, string date, string time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        this.poolParty = weatherForecast;  // Set the weather forecast for the pool party
    }

    public override string GetFullDetails()
    {
        string details = "Full Details:\n";
        details += GetStandardDetails();  // Get the standard details from the base class
        details += $"Type: Outdoor Gathering\n";
        details += $"Weather Forecast: {poolParty}\n";
        return details;  // Return the full details of the pool party
    }

    public override string GetShortDescription()
    {
        return $"Type: Outdoor Gathering, Title: {base.eventTitle}, Date: {base.eventDate}";  // Return the short description of the pool party
    }
}
