public class ReflectingActivity : Activity
{
    public List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
    };
    public List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };


    public ReflectingActivity(string name, string description) : base(name, description)
    {
        Name = name;
        Description = description;
    }

    public void Run()
    {
        DisplayStartingMessage();
        ShowSpinner(3);

        Console.WriteLine("Take a moment to reflect on the following prompt:");
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        Console.WriteLine(_prompts[index]);

        ShowCountdown(10);

        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        Console.WriteLine(_prompts[index]);
    }

    public List<string> GetRandomQuestion()
    {
        Random rand = new Random();
        int index = rand.Next(_questions.Count);
        return _questions;
        
    }

    public void DisplayRandomPrompt()
    {
        GetRandomPrompt();
    }

    public void DisplayRandomQuestion()
    {
        GetRandomQuestion();
    }

}