using System;

public class Address
{
    public string Street { get; set; }
    public string City { get; set; }
    public string StateProvince { get; set; }
    public string Country { get; set; }

    public bool IsInUSA()
    {
        return Country == "USA";
    }

    public string GetAddressString()
    {
        return $"{Street}, {City}, {StateProvince}, {Country}";
    }
}