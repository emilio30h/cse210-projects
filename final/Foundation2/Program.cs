using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an order
        Order order = new Order();

        // Create products
        Product product1 = new Product
        {
            Name = "Product 1",
            ProductId = "P1",
            Price = 10.5f,
            Quantity = 2
        };

        Product product2 = new Product
        {
            Name = "Product 2",
            ProductId = "P2",
            Price = 15.25f,
            Quantity = 1
        };

        // Add products to the order
        order.Products.Add(product1);
        order.Products.Add(product2);

        // Set customer details
        order.Customer.Name = "John Doe";
        order.Customer.Address = new Address
        {
            Street = "123 Main St",
            City = "Anytown",
            StateProvince = "CA",
            Country = "USA"
        };

        // Calculate total cost
        decimal totalCost = order.CalculateTotalCost();

        // Print packing and shipping labels
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.GetPackingLabel());

        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order.GetShippingLabel());

        Console.WriteLine("\nTotal Cost: $" + totalCost);
    }
}