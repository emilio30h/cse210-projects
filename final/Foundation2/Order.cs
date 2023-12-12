using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> products;
    private Customer customer;

    public Order()
    {
        products = new List<Product>();
        customer = new Customer();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public decimal CalculateTotalCost()
    {
        decimal totalCost = 0;
        foreach (Product product in products)
        {
            totalCost += product.Price * product.Quantity;
        }
        return totalCost;
    }

    public string GetPackingLabel()
    {
        return $"Order: {customer.GetName()}\nAddress: {customer.GetAddress().GetAddressString()}";
    }

    public string GetShippingLabel()
    {
        if (customer.GetAddress().IsInUSA())
        {
            return $"Shipping to:\n{customer.GetName()}\n{customer.GetAddress().GetAddressString()}";
        }
        else
        {
            return $"International shipping to:\n{customer.GetName()}\n{customer.GetAddress().GetAddressString()}";
        }
    }

    public void SetCustomer(Customer customer)
    {
        this.customer = customer;
    }
}