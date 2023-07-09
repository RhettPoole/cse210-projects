// Sources:
// C# Lists and Collections: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/collections
// C# ?: Operator (C# Reference): https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/conditional-operator

using System.Collections.Generic;

public class Order
{
    // List to store products.
    private List<Product> products;
    // Customer associated with the order.
    private Customer customer;

    public Order(Customer customer)
    {
        products = new List<Product>(); // Initialize list
        this.customer = customer; // Set the customer
    }

    public void AddProduct(Product product)
    {
        products.Add(product); // Adding product to order
    }

    // Calculate the total cost by iterating over each product in the order.
    public decimal CalculateTotalCost()
    {
        decimal totalCost = 0;
        foreach (Product product in products)
        {
            totalCost += product.Price * product.Quantity;
        }

        // Add shipping cost based on the customer's location
        totalCost += customer.USA() ? 5 : 35;

        return totalCost;
    }

    // Generate the packing label by iterating over each product in the order.
    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (Product product in products)
        {
            packingLabel += $"Name: {product.Name}, Product ID: {product.ProductCode}\n";
        }

        return packingLabel; // Return the generated packing label.
    }

    public string GetShippingLabel()
    {
        // Generate the shipping label by combining customer's name, address, and customer's address details.
        return $"Shipping Label: \nName: {customer.Name}\nAddress:\n{customer.Address.GetFullAddress()}";
    }

}