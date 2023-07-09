// Sources:
// C# Collections https://www.tutorialspoint.com/csharp/csharp_collections.htm
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create Products
        Product product1 = new Product("Shoes that smell like ranch", "2048", 220.88m, 2);
        Product product2 = new Product("Pickled wallets", "1982", 185.33m, 1);

        // Create Addresses
        Address address1 = new Address("2260 East Sicily Street", "Boston", "Massachusets", "USA");
        Address address2 = new Address("459 S 5th W", "Brandon", "Manitoba", "Canada");

        // Create Customers
        Customer customer1 = new Customer("Rhett Poole", address1);
        Customer customer2 = new Customer("Blair Leavitt", address2);

        // Create Orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product1);

        // Display packing labels, shipping labels, and total prices
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order2.CalculateTotalCost());

        Console.WriteLine();

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order2.CalculateTotalCost());
    }
}