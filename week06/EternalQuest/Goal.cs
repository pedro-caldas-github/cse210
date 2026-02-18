public abstract class Goal
{
    public string _shortName { get; set; }
    public string _description { get; set; }
    public int _points { get; set; }

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public virtual void RecordEvent()
    {
        Console.WriteLine($"You have earned {_points} points for completing the goal: {_shortName}");
    }

    public virtual bool IsComplete()
    {
        return false;
    }

    public string GetDetailsString()
    {
        return $"Goal: {_shortName}\nDescription: {_description}\nPoints: {_points}";
    }

    public virtual string GetStringRepresentation()
    {
        return $"{_shortName},{_description},{_points}";
    }

}