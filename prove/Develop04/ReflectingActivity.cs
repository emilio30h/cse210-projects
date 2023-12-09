using System;
using System.Threading;

class ReflectionActivity : Activity
{
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not ascommitted?",
        "What did you learn from this experience?",
        "How did this experience change you?",
        "What advice would you give to someone who wants to do something similar?"
    };

    protected override void ExecuteActivity()
    {
        Console.WriteLine("Think deeply and reflect on the following prompts:");

        foreach (string prompt in prompts)
        {
            Console.WriteLine(prompt);
            Thread.Sleep(5000); // Pause for 5 seconds

            foreach (string question in questions)
            {
                Console.WriteLine(question);
                Thread.Sleep(3000); // Pause for 3 seconds
            }
        }
    }

    protected override string GetDescription()
    {
        return "This activity will help you reflect on meaningful experiences in your life by providing prompts and questions for self-reflection.";
    }
}