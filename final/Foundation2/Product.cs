using System.Collections.Generic;

public class Product
{
    // No comments needed as the names are self explanatory.
    public string Name { get; set; }
    public string ProductCode { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }

    public Product(string name, string productCode, decimal price, int quantity)
    {
        // Initialize all items in "Product" class.
        Name = name;
        ProductCode = productCode;
        Price = price;
        Quantity = quantity;
    }
}