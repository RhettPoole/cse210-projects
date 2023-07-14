using System.Collections.Generic;

public abstract class Event
{
    protected string eventTitle;  // Title of the event
    private string eventDescription;  // Description of the event
    protected string eventDate;  // Date of the event
    private string eventTime;  // Time of the event
    private Address eventAddress;  // Address of the event

    public Event(string title, string description, string date, string time, Address address)
    {
        eventTitle = title;  // Set the title of the event
        eventDescription = description;  // Set the description of the event
        eventDate = date;  // Set the date of the event
        eventTime = time;  // Set the time of the event
        eventAddress = address;  // Set the address of the event
    }

    public string GetStandardDetails()
    {
        string details = $"Title: {eventTitle}\n";  // Get the title of the event
        details += $"Description: {eventDescription}\n";  // Get the description of the event
        details += $"Date: {eventDate}\n";  // Get the date of the event
        details += $"Time: {eventTime}\n";  // Get the time of the event
        details += $"Address: {eventAddress.GetFullAddress()}\n";  // Get the full address of the event
        return details;  // Return the standard details of the event
    }

    public abstract string GetFullDetails();  // Abstract method to get the full details of the event

    public abstract string GetShortDescription();  // Abstract method to get the short description of the event
}
