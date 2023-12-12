using System;

public class Swimming : Activity
{
    protected int laps;

    public Swimming(string date, float length, int laps)
        : base(date, length)
    {
        this.laps = laps;
    }

    public override float CalculatePace()
    {
        float pace = length / laps;
        return pace;
    }
}