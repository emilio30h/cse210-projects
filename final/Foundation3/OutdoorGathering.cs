using System;

public class OutdoorGathering : Event
{
    protected string weatherForecast;

    public OutdoorGathering(string title, string description, string date, string time, string address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        this.weatherForecast = weatherForecast;
    }
}