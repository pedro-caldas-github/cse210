public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {
        Name = name;
        Description = description;
        Duration = 30;
    }

    public void Run()
    {
        DisplayStartingMessage();
        ShowSpinner(3);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(Duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            ShowSpinner(4);

            Console.WriteLine("Now breathe out...");
            ShowSpinner(4);
        }

        DisplayEndingMessage();
    }


}