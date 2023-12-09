using System;

class Program
{
    static void Main(string[] args)
    {
        // Display menu options
        Console.WriteLine("Choose an activity:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Listing Activity");
        Console.WriteLine("3. Reflection Activity");

        // Read user input
        string input = Console.ReadLine();

        // Run the selected activity based on user input
        switch (input)
        {
            case "1":
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
                break;
            case "2":
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
                break;
            case "3":
                ReflectionActivity reflectionActivity = new ReflectionActivity();
                reflectionActivity.Run();
                break;
            default:
                Console.WriteLine("Invalid choice. Exiting program.");
                break;
        }
    }
}