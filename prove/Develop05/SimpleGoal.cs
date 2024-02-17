public class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine($"{Name} completed! {Points} points earned.");
            return Points;
        }
        Console.WriteLine($"{Name} is already complete.");
        return 0;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"{Name}: {(IsComplete() ? "[X]" : "[ ]")} - {Description}";
    }
}