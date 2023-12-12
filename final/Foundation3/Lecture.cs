using System;

public class Lecture : Event
{
    protected string speaker;
    protected int capacity;

    public Lecture(string title, string description, string date, string time, string address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        this.speaker = speaker;
        this.capacity = capacity;
    }
}