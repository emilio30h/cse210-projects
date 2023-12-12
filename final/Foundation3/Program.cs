using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating instances of different event types
        Event event1 = new Event("Conference", "Annual tech conference", "2023-10-15", "09:00", "123 Main Street");
        Lecture lecture1 = new Lecture("Machine Learning", "Introduction to machine learning", "2023-11-20", "14:00", "456 Elm Street", "John Doe", 100);
        Reception reception1 = new Reception("Networking Event", "Networking event for professionals", "2023-12-05", "18:00", "789 Oak Street", "rsvp@example.com");
        OutdoorGathering outdoorGathering1 = new OutdoorGathering("Picnic", "Community picnic", "2023-07-30", "12:00", "321 Pine Street", "Sunny");

        // Generating marketing messages for each event
        string event1Message = event1.GenerateMarketingMessage();
        string lecture1Message = lecture1.GenerateMarketingMessage();
        string reception1Message = reception1.GenerateMarketingMessage();
        string outdoorGathering1Message = outdoorGathering1.GenerateMarketingMessage();

        // Printing the marketing messages
        Console.WriteLine(event1Message);
        Console.WriteLine(lecture1Message);
        Console.WriteLine(reception1Message);
        Console.WriteLine(outdoorGathering1Message);
    }
}