using System;
using System.Threading;

class BreathingActivity : Activity
{
    protected override void ExecuteActivity()
    {
        int breathInDuration = duration / 2;
        int breathOutDuration = duration / 2;

        for (int i = 0; i < duration; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine("Breathe in...");
                PauseWithSpinner(breathInDuration);
            }
            else
            {
                Console.WriteLine("Breathe out...");
                PauseWithSpinner(breathOutDuration);
            }
        }
    }

    protected override string GetDescription()
    {
        return "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
}