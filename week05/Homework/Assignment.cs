public class Assignment
{
    protected string _name;
    protected string _topic;

    public Assignment(string name, string topic)
    {
        _name = name;
        _topic = topic;
    }

    public string Getname()
    {
        return _name;
    }

    public string SetName(string name)
    {
        _name = name;
        return _name;
    }

    public string Gettopic()
    {
        return _topic;
    }

    public string SetTopic(string topic)
    {
        _topic = topic;
        return _topic;
    }

   public string GetSummary()
    {
        return $"{_name} - {_topic}";
    }
}