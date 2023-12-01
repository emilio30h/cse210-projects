using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the Scripture class
        Scripture scripture = new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only Son, that whoever believes in him should not perish but have eternal life.");

        // Display the complete scripture
        Console.WriteLine(scripture.GetDisplayText());

        // Prompt the user to press enter or type quit
        string input = Console.ReadLine();

        while (input != "quit")
        {
            // Hide a few random words
            scripture.HideRandomWords(3);

            // Clear the console
            ClearConsole();

            // Display the updated scripture with hidden words
            Console.WriteLine(scripture.GetDisplayText());

            // Prompt the user again
            input = Console.ReadLine();
        }
    }

    static void ClearConsole()
    {
        Console.Clear();
        Console.SetCursorPosition(0, 0);
    }
}