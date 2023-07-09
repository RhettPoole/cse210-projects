using System.Collections.Generic;

public class Customer
{
    // No comments needed here.
    public string Name { get; set; }
    public Address Address { get; set; }

    public Customer(string name, Address address)
    {
        Name = name; // Initialize customer name.
        Address = address; // Initialize customer address.
    }

    public bool USA()
    {
        return Address.USA();
    }
}