using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an order
        Order order = new Order();

        // Create products
        Product product1 = new Product("Product 1", "P1", 10.5f, 2);
        Product product2 = new Product("Product 2", "P2", 15.25f, 1);

        // Add products to the order
        order.AddProduct(product1);
        order.AddProduct(product2);

        // Set customer details
        Address address = new Address("123 Main St", "Anytown", "CA", "USA");
        Customer customer = new Customer("John Doe", address);
        order.SetCustomer(customer);

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