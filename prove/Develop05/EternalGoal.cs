public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        Console.WriteLine($"{Name} recorded! {Points} points earned.");
        return Points; 
    }

    public override bool IsComplete()
    {
        return false; 
    }

    public override string GetStringRepresentation()
    {
        return $"{Name} - {Description}";
    }
}