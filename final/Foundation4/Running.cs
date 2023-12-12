using System;

public class Running : Activity
{
    protected float distance;

    public Running(string date, float length, float distance)
        : base(date, length)
    {
        this.distance = distance;
    }

    public override float CalculateDistance()
    {
        return distance;
    }
}