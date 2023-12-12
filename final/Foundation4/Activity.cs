using System;

public class Activity
{
    protected string date;
    protected float length;

    public Activity(string date, float length)
    {
        this.date = date;
        this.length = length;
    }

    public virtual float CalculateDistance()
    {
        return 0; // Default implementation returns 0; to be overridden in derived classes
    }

    public virtual float CalculateSpeed()
    {
        return 0; // Default implementation returns 0; to be overridden in derived classes
    }

    public virtual float CalculatePace()
    {
        return 0; // Default implementation returns 0; to be overridden in derived classes
    }

    public virtual string GenerateSummary()
    {
        return $"Activity Date: {date}\nActivity Length: {length} minutes";
    }
}