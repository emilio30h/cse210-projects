using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("1. Display Player Info");
            Console.WriteLine("2. List Goal Names");
            Console.WriteLine("3. List Goal Details");
            Console.WriteLine("4. Create Goal");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Save Goals");
            Console.WriteLine("7. Load Goals");
            Console.WriteLine("8. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    DisplayPlayerInfo();
                    break;
                case "2":
                    ListGoalNames();
                    break;
                case "3":
                    ListGoalDetails();
                    break;
                case "4":
                    CreateGoal();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    SaveGoals();
                    break;
                case "7":
                    LoadGoals();
                    break;
                case "8":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    private void DisplayPlayerInfo()
    {
        Console.WriteLine($"Player Score: {_score}");
    }

    private void ListGoalNames()
    {
        Console.WriteLine("Goal Names:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.ShortName);
        }
    }

    private void ListGoalDetails()
    {
        Console.WriteLine("Goal Details:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    private void CreateGoal()
    {
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();

        Console.Write("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());

        Console.WriteLine("Select goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Enter your choice: ");
        string typeChoice = Console.ReadLine();

        switch (typeChoice)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("Enter goal target: ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("Enter goal bonus: ");
                int bonus = int.Parse(Console.ReadLine());

                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid choice. Goal creation canceled.");
                break;
        }
    }

    private void RecordEvent()
    {
        Console.WriteLine("Select a goal to record the event:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].ShortName}");
        }

        Console.Write("Enter your choice: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goals.Count)
        {
            Goal goal = _goals[index];
            goal.RecordEvent();
            _score += goal.Points;

            Console.WriteLine("Event recorded successfully.");
        }
        else
        {
            Console.WriteLine("Invalid choice. Event recording canceled.");
        }
    }

    private void SaveGoals()
    {
        Console.Write("Enter file path to save goals: ");
        string filePath = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved successfully.");
    }

    private void LoadGoals()
    {
        Console.Write("Enter file path to load goals: ");
        string filePath = Console.ReadLine();

        if (File.Exists(filePath))
        {
            _goals.Clear();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] data = line.Split('|');

                    if (data.Length >= 4)
                    {
                        string name = data[0];
                        string description = data[1];
                        int points = int.Parse(data[2]);

                        if (data.Length == 4)
                        {
                            _goals.Add(new SimpleGoal(name, description, points));
                        }
                        else if (data.Length == 6)
                        {
                            int amountCompleted = int.Parse(data[3]);
                            int target = int.Parse(data[4]);
                            int bonus = int.Parse(data[5]);

                            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                        }
                    }
                }
            }

            Console.WriteLine("Goals loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found. Goals loading canceled.");
        }
    }
}