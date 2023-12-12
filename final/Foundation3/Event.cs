using System;

public class Event
{
    protected string title;
    protected string description;
    protected string date;
    protected string time;
    protected string address;

    public Event(string title, string description, string date, string time, string address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    public string GenerateMarketingMessage()
    {
        return $"Join us for the {title} event on {date} at {time}. {description}. Address: {address}.";
    }
}