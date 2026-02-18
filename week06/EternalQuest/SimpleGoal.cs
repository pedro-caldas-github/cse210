public class SimpleGoal : Goal
{
    public bool _isComplete { get; set; }
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        base.RecordEvent();
        Console.WriteLine("This goal is now complete!");
    }

    public new bool IsComplete()
    {
        return true;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal,{base.GetStringRepresentation()},{_isComplete}";
    }
}