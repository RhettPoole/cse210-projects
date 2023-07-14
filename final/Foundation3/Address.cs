using System.Collections.Generic;

public class Address
{
    private string streetAddress;
    private string city;
    private string state;
    private string country;

    public Address(string streetAddress, string city, string state, string country)
    {
        this.streetAddress = streetAddress;  // Set the street address
        this.city = city;  // Set the city
        this.state = state;  // Set the state
        this.country = country;  // Set the country
    }

    public string GetFullAddress()
    {
        return $"Street Address: {streetAddress}, City: {city}, State/Province: {state}, Country: {country}";  // Return the full address
    }
}
