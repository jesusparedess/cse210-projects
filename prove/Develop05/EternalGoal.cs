public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override void RecordEvent()
    {
        // Add logic to update user score.
    }

    public override bool IsComplete() => false;

    public override string GetDetailsString() => "Eternal goal details.";

    public override string GetStringRepresentation() => "[ ]";
}