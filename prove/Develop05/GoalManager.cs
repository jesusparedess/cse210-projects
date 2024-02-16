using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public void Start()
    {
        LoadGoals();
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Welcome to Eternal Quest Goal Tracker");
            Console.WriteLine("1. List all goals");
            Console.WriteLine("2. Create a new goal");
            Console.WriteLine("3. Record a goal event");
            Console.WriteLine("4. Display score");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    ListAllGoals();
                    break;
                case "2":
                    CreateGoal();
                    break;
                case "3":
                    RecordGoalEvent();
                    break;
                case "4":
                    DisplayScore();
                    break;
                case "5":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
        SaveGoals();
    }

    private void ListAllGoals()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }
    }

    private void CreateGoal()
    {
        // Implement the logic to create different types of goals based on user input
    }

    private void RecordGoalEvent()
    {
        // Implement the logic for recording goal events
    }

    private void DisplayScore()
    {
        Console.WriteLine($"Your current score is: {_score}");
    }

    private void SaveGoals()
    {
        // Implement the logic to save goals to a file
    }

    private void LoadGoals()
    {
        // Implement the logic to load goals from a file
    }
}