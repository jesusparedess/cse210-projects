public class ChecklistGoal : Goal
{
    private int _target;
    private int _amountCompleted;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;
        Console.WriteLine($"{Name} progress: {_amountCompleted}/{_target}. {Points} points earned.");
        if (_amountCompleted == _target)
        {
            Console.WriteLine($"Bonus achieved! Additional {_bonus} points earned.");
            return Points;
        }
        return 0;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetStringRepresentation()
    {
        return $"{Name}: {(IsComplete() ? "[X]" : $"[{_amountCompleted}/{_target}]")} - {Description}";
    }
}