using System;
using System.Collections.Generic;

public class Order
{
    public List<Product> Products { get; set; }
    public Customer Customer { get; set; }

    public Order()
    {
        Products = new List<Product>();
        Customer = new Customer();
    }

    public decimal CalculateTotalCost()
    {
        decimal totalCost = 0;
        foreach (Product product in Products)
        {
            totalCost += (decimal)product.Price * product.Quantity;
        }
        return totalCost;
    }

    public string GetPackingLabel()
    {
        return $"Order: {Customer.Name}\nAddress: {Customer.Address.GetAddressString()}";
    }

    public string GetShippingLabel()
    {
        if (Customer.Address.IsInUSA())
        {
            return $"Shipping to:\n{Customer.Name}\n{Customer.Address.GetAddressString()}";
        }
        else
        {
            return $"International shipping to:\n{Customer.Name}\n{Customer.Address.GetAddressString()}";
        }
    }
}