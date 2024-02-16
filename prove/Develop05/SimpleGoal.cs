public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override void RecordEvent()
    {
        _isComplete = true;
        // Add logic to update user score.
    }

    public override bool IsComplete() => _isComplete;

    public override string GetDetailsString() => "Simple goal details.";

    public override string GetStringRepresentation()
    {
        return _isComplete ? "[X]" : "[ ]";
    }
}