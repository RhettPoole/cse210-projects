using System.Collections.Generic;

public class Address
{
    // No comments needed as the names are self explanatory.
    public string StreetAddress { get; set; }
    public string City { get; set; }
    public string StateProvince { get; set; }
    public string Country { get; set; }

    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        StreetAddress = streetAddress; // Initialize street address
        City = city; // Initialize city
        StateProvince = stateProvince; // Initialize the state or province for Canadian address
        Country = country; // Initialize country
    }

    public bool USA()
    {
        return Country == "USA";
    }

    // "Get" function to display the entire address.
    public string GetFullAddress()
    {
        return $"Street Address: {StreetAddress}\nCity: {City}\nState/Province: {StateProvince}\nCountry: {Country}";
    }
}