using System;

public class Cycling : Activity
{
    protected float speed;

    public Cycling(string date, float length, float speed)
        : base(date, length)
    {
        this.speed = speed;
    }

    public override float CalculateSpeed()
    {
        return speed;
    }
}