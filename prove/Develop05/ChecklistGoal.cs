public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        // Add logic to update user score and apply bonus if target is reached.
    }

    public override bool IsComplete() => _amountCompleted >= _target;

    public override string GetDetailsString() => "Checklist goal details.";

    public override string GetStringRepresentation()
    {
        return _amountCompleted >= _target ? $"[X] Completed {_amountCompleted}/{_target} times"
                                           : $"[ ] Completed {_amountCompleted}/{_target} times";
    }
}