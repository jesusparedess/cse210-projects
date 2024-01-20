using System;

class Program
{
    static Journal journal = new Journal();
    static string[] prompts = new string[]
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "Did you excercise and work on your habits today?",
        "What was the strongest emotion I felt today?",
        "Could you tell us how you feel right now?"
    };

    static void Main()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteNewEntry();
                    break;
                case "2":
                    journal.DisplayJournal();
                    break;
                case "3":
                    SaveJournalToFile();
                    break;
                case "4":
                    LoadJournalFromFile();
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please choose again.");
                    break;
            }
        }
    }

    static void WriteNewEntry()
    {
        Random rnd = new Random();
        int promptIndex = rnd.Next(prompts.Length);
        Console.WriteLine(prompts[promptIndex]);
        string response = Console.ReadLine();
        journal.AddEntry(prompts[promptIndex], response);
    }

    static void SaveJournalToFile()
    {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();
        journal.SaveJournal(filename);
        Console.WriteLine("Journal saved.");
    }

    static void LoadJournalFromFile()
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();
        journal.LoadJournal(filename);
        Console.WriteLine("Journal loaded.");
    }
}
// Enhancement: The Entry class captures both the date and time when a new entry is created, 
// This exceeds the basic requirement by providing a more detailed and accurate record of each entry.
