using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int score = 0;

    public void Start()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("\nEternal Quest Goal Tracker");
            Console.WriteLine("1. List all goals");
            Console.WriteLine("2. Create a new goal");
            Console.WriteLine("3. Record a goal event");
            Console.WriteLine("4. Display score");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option: ");

       switch (Console.ReadLine())
            {
                case "1":
                    ListGoals();
                    break;
                case "2":
                    CreateGoal();
                    break;
                case "3":
                    RecordEvent();
                    break;
                case "4":
                    DisplayScore();
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }

    private void ListGoals()
    {
        if (goals.Any())
        {
            Console.WriteLine("\nGoals:");
            foreach (var goal in goals)
            {
                Console.WriteLine(goal.GetStringRepresentation());
            }
        }
        else
        {
            Console.WriteLine("No goals have been created.");
        }
    }

private void CreateGoal()
{
    Console.WriteLine("\nSelect goal type:");
    Console.WriteLine("1. Simple Goal");
    Console.WriteLine("2. Eternal Goal");
    Console.WriteLine("3. Checklist Goal");
    Console.Write("Choice: ");
    string choice = Console.ReadLine();

    Console.Write("Enter goal title: ");
    string title = Console.ReadLine();
    Console.Write("Enter goal description: ");
    string description = Console.ReadLine();
    Console.Write("Enter points for completing the goal: ");
    int points = 0;
    while (!int.TryParse(Console.ReadLine(), out points) || points <= 0)
    {
        Console.WriteLine("Invalid input. Please enter a positive integer for points.");
    }

    switch (choice)
    {
        case "1":
            goals.Add(new SimpleGoal(title, description, points));
            Console.WriteLine("Simple Goal created successfully.");
            break;
        case "2":
            goals.Add(new EternalGoal(title, description, points));
            Console.WriteLine("Eternal Goal created successfully.");
            break;
        case "3":
            Console.Write("Enter target count for completion: ");
            int targetCount = 0;
            while (!int.TryParse(Console.ReadLine(), out targetCount) || targetCount <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer for target count.");
            }
            Console.Write("Enter bonus points for completing the goal: ");
            int bonus = 0;
            while (!int.TryParse(Console.ReadLine(), out bonus) || bonus < 0)
            {
                Console.WriteLine("Invalid input. Please enter a non-negative integer for bonus points.");
            }
            goals.Add(new ChecklistGoal(title, description, points, targetCount, bonus));
            Console.WriteLine("Checklist Goal created successfully.");
            break;
        default:
            Console.WriteLine("Invalid choice. Please select a valid goal type.");
            break;
    }
}

    private void RecordEvent()
{
    Console.Write("Enter goal title to record: ");
    string title = Console.ReadLine();
    var goal = goals.FirstOrDefault(g => g.Name.Equals(title, StringComparison.OrdinalIgnoreCase));

    if (goal != null)
    {
        int pointsGained = goal.RecordEvent(); 
        score += pointsGained;  
        Console.WriteLine($"Event recorded for '{goal.Name}'. Points gained: {pointsGained}. Total score: {score}");
    }
    else
    {
        Console.WriteLine("Goal not found.");
    }
}


    private void DisplayScore()
    {
        Console.WriteLine($"Current score: {score}");
    }
}