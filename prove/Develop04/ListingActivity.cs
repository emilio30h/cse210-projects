using System;

class ListingActivity : Activity
{
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    protected override void ExecuteActivity()
    {
        Console.WriteLine("Start listing items:");

        int itemCount = 0;
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Length)];

        Console.WriteLine(prompt);
        Thread.Sleep(5000); // Pause for 5 seconds

        while (duration > 0)
        {
            Console.WriteLine("Enter an item:");
            string item = Console.ReadLine();
            if (string.IsNullOrEmpty(item))
                break;

            itemCount++;
            duration--;
        }

        Console.WriteLine($"Number of items listed: {itemCount}");
    }

    protected override string GetDescription()
    {
        return "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }
}