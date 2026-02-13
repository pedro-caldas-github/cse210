public class ListingActivity : Activity
{
    public int _count;
    public List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    public ListingActivity(string name, string description) : base(name, description)
    {
        Name = name;
        Description = description;
    }

    public void Run()
    {
        DisplayStartingMessage();
        ShowSpinner(3);

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        Console.WriteLine(_prompts[index]);

        Console.WriteLine($"You have {Duration} seconds. Start!");
        ShowCountdown(3);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(Duration);

        _count = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            if (response != "")
            {
                _count++;
            }
        }

        Console.WriteLine($"You listed {_count} items!");
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        Console.WriteLine(_prompts[index]);
    }

    public List<string> GetListFromUser()
    {
        return _prompts;
    }


}