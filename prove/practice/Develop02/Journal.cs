using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    private List<Entry> entries;
    private List<string> prompts;

    public Journal()
    {
        entries = new List<Entry>();
        prompts = new List<string>()
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What was the highlight of your day?",
            "Describe a challenge you faced today and how you overcame it.",
            "What are you grateful for today?",
            "Write about a goal you're currently working towards.",
            "Describe something interesting you learned today."
        };
    }

    public void WriteNewEntry()
    {
        Random random = new Random();
        int promptIndex = random.Next(prompts.Count);
        string prompt = prompts[promptIndex];

        Console.WriteLine($"Prompt: {prompt}");
        Console.WriteLine("Enter your response:");
        string response = Console.ReadLine();

        Entry entry = new Entry(response, prompt, DateTime.Now);
        entries.Add(entry);

        Console.WriteLine("Entry added successfully.");
    }

    public void DisplayJournal()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No entries found.");
            return;
        }

        foreach (Entry entry in entries)
        {
            Console.WriteLine($"Date: {entry.Date}");
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Response: {entry.Response}");
            Console.WriteLine();
        }
    }

    public void SaveJournalToFile()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No entries found to save.");
            return;
        }

        Console.WriteLine("Enter the filename to save the journal:");
        string filename = Console.ReadLine();

        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (Entry entry in entries)
                {
                    writer.WriteLine($"Date: {entry.Date}");
                    writer.WriteLine($"Prompt: {entry.Prompt}");
                    writer.WriteLine($"Response: {entry.Response}");
                    writer.WriteLine();
                }
            }

            Console.WriteLine("Journal saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal: {ex.Message}");
        }
    }

    public void LoadJournalFromFile()
    {
        Console.WriteLine("Enter the filename to load the journal:");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        try
        {
            entries.Clear();

            using (StreamReader reader = new StreamReader(filename))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    if (line.StartsWith("Date:"))
                    {
                        string dateStr = line.Substring(line.IndexOf(':') + 1).Trim();
                        DateTime date = DateTime.Parse(dateStr);

                        string prompt = reader.ReadLine().Substring(8).Trim();
                        string response = reader.ReadLine().Substring(10).Trim();

                        Entry entry = new Entry(response, prompt, date);
                        entries.Add(entry);

                        reader.ReadLine(); // Empty line
                    }
                }
            }

            Console.WriteLine("Journal loaded successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal: {ex.Message}");
        }
    }
}

class Entry
{
    public string Response { get; set; }
    public string Prompt { get; set; }
    public DateTime Date { get; set; }

    public Entry(string response, string prompt, DateTime date)
    {
        Response = response;
        Prompt = prompt;
        Date = date;
    }
}