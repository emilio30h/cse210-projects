using System;

class ListingActivity : Activity
{
    protected override void ExecuteActivity()
    {
        Console.WriteLine("Start listing items:");

        int itemCount = 0;
        while (duration > 0)
        {
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