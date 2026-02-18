public class CheckListGoal : Goal
{
    public int _amountCompleted { get; set; }
    public int _target { get; set; }
    public int _bonus { get; set; }

    public CheckListGoal(string name, string description, int points, int targetCount) : base(name, description, points)
    {
        name = _shortName;
        description = _description;
        points = _points;
        _target = targetCount;
        _amountCompleted = 0;
    }

    public override void RecordEvent()
    {
        base.RecordEvent();
        _amountCompleted++;
        Console.WriteLine($"You have completed {_amountCompleted} out of {_target} for this goal.");
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetStringRepresentation()
    {
        return $"CheckListGoal,{base.GetStringRepresentation()},{_amountCompleted},{_target},{_bonus}";
    }
}