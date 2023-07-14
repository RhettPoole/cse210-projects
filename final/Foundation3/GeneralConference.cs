/// Sources:
/// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods#method-overriding

using System.Collections.Generic;

public class GeneralConference : Event
{
    private string confirmationEmail;  // Confirmation email for tickets

    public GeneralConference(string title, string description, string date, string time, Address address, string confirmationEmail)
        : base(title, description, date, time, address)
    {
        this.confirmationEmail = confirmationEmail;  // Set the confirmation email for tickets
    }

    public override string GetFullDetails()
    {
        string details = "Full Details:\n";
        details += GetStandardDetails();  // Get the standard details from the base class
        details += $"Type: General Conference\n";
        details += $"Confirmation Email for tickets: {confirmationEmail}\n";
        return details;  // Return the full details of the general conference
    }

    public override string GetShortDescription()
    {
        return $"Type: General Conference, Title: {base.eventTitle}, Date: {base.eventDate}";  // Return the short description of the general conference
    }
}
