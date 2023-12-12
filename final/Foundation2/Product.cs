using System;

public class Product
{
    private string name;
    private string productId;
    private float price;
    private int quantity;

    public Product(string name, string productId, float price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    public string GetName()
    {
        return name;
    }

    public float GetPrice()
    {
        return price;
    }

    public int GetQuantity()
    {
        return quantity;
    }
}