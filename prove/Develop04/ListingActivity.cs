public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public override void Run()
    {
        DisplayStartingMessage();
        Random rnd = new Random();
        string randomPrompt = _prompts[rnd.Next(_prompts.Count)];
        Console.WriteLine(randomPrompt);

        ShowSpinner(3); 

        Console.WriteLine("Start listing (type 'done' to finish):");
        List<string> userEntries = new List<string>();
        string entry;
        int startTime = Environment.TickCount;
        
        do
        {
            entry = Console.ReadLine();
            if (entry.ToLower() != "done" && (Environment.TickCount - startTime < _duration * 1000))
            {
                userEntries.Add(entry);
            }
        }
        while (entry.ToLower() != "done" && (Environment.TickCount - startTime < _duration * 1000));
        
        Console.WriteLine($"You listed {userEntries.Count} items.");
        
        DisplayEndingMessage();
    }
}
