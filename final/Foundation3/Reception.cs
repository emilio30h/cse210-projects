using System;

public class Reception : Event
{
    protected string rsvpEmail;

    public Reception(string title, string description, string date, string time, string address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        this.rsvpEmail = rsvpEmail;
    }
}