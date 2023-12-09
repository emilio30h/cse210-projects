using System;
using System.Threading;

class BreathingActivity : Activity
{
    protected override void ExecuteActivity()
    {
        Console.WriteLine("Start breathing activity:");

        Console.WriteLine("Breathe in...");
        Thread.Sleep(3000); // Pause for 3 seconds
        Console.WriteLine("Breathe out...");
        Thread.Sleep(3000); // Pause for 3 seconds

        while (duration > 6)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(3000); // Pause for 3 seconds
            Console.WriteLine("Breathe out...");
            Thread.Sleep(3000); // Pause for 3 seconds

            duration -= 6;
        }

        if (duration > 0)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(duration * 1000); // Pause for remaining duration
        }
    }

    protected override string GetDescription()
    {
        return "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
}