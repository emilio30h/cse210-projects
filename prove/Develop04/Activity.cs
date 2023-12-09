using System;
using System.Threading;

abstract class Activity
{
    protected int duration;

    public void Run()
    {
        DisplayStartingMessage();
        PrepareToBegin();
        ExecuteActivity();
        DisplayEndingMessage();
    }

    protected abstract void ExecuteActivity();

    protected void DisplayStartingMessage()
    {
        Console.WriteLine($"=== {GetType().Name} ===");
        Console.WriteLine(GetDescription());
        Console.WriteLine("Enter the duration in seconds:");
        duration = int.Parse(Console.ReadLine());
    }

    protected abstract string GetDescription();

    protected void PrepareToBegin()
    {
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(3000); // Pause for 3 seconds
    }

    protected void DisplayEndingMessage()
    {
        Console.WriteLine("Good job! You have completed the activity.");
        Console.WriteLine($"Activity: {GetType().Name}");
        Console.WriteLine($"Duration: {duration} seconds");
        Thread.Sleep(3000); // Pause for 3 seconds
    }

    protected void PauseWithSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/");
            Thread.Sleep(1000); // Pause for 1 second
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(1000); // Pause for 1 second
            Console.Write("\b");
            Console.Write("\\");
            Thread.Sleep(1000); // Pause for 1 second
            Console.Write("\b");
            Console.Write("|");
            Thread.Sleep(1000); // Pause for 1 second
            Console.Write("\b");
        }
    }
}