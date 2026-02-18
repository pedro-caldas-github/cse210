public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        name = _shortName;
        description = _description;
        points = _points;
    }

    public override void RecordEvent()
    {
        base.RecordEvent();
        Console.WriteLine("This goal can be completed multiple times!");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal,{base.GetStringRepresentation()}";
    }
}