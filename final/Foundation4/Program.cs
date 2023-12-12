using System;

class Program
{
    static void Main(string[] args)
    {
        Activity activity1 = new Activity("2023-10-15", 60);
        Running running1 = new Running("2023-11-20", 45, 5.2f);
        Cycling cycling1 = new Cycling("2023-12-05", 30, 20);
        Swimming swimming1 = new Swimming("2023-07-30", 60, 10);

        Console.WriteLine(activity1.GenerateSummary());
        Console.WriteLine();

        Console.WriteLine(running1.GenerateSummary());
        Console.WriteLine($"Distance: {running1.CalculateDistance()} miles");
        Console.WriteLine();

        Console.WriteLine(cycling1.GenerateSummary());
        Console.WriteLine($"Speed: {cycling1.CalculateSpeed()} mph");
        Console.WriteLine();

        Console.WriteLine(swimming1.GenerateSummary());
        Console.WriteLine($"Pace: {swimming1.CalculatePace()} minutes per lap");
    }
}