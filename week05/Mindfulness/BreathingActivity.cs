public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        Name = name;
        Description = description;
        Duration = duration;
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Get ready to begin...");
        ShowSpinner(3);

        Console.WriteLine("Breathe in...");
        ShowSpinner(4);

        Console.WriteLine("Now breathe out...");
        ShowSpinner(4);

        DisplayEndingMessage();
    }


}