public class PromptGenerator
{
    public string _topic;
    public List<string> _prompts = new List<string>();
    Random random = new Random();
    public PromptGenerator()
    {
        _prompts.Add("What was the best part of your day?");
        _prompts.Add("What are you grateful for today?");
        _prompts.Add("Describe a challenge you faced recently and how you overcame it.");
        _prompts.Add("What is something new you learned today?");
        _prompts.Add("Write about a memorable moment from your childhood.");
    }
    public string DisplayPrompts()
    {

    int index = random.Next(_prompts.Count);    
    Console.WriteLine(_prompts[index]);
    return _prompts[index];
    }
}