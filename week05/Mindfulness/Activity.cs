public class Activity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Duration { get; set; }

    public Activity(string name, string description, int duration)
    {
        Name = name;
        Description = description;
        Duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting Activity: {Name}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Duration: {Duration} minutes");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Finished Activity: {Name}");
        Console.WriteLine("Great job! Take a moment to reflect on how you felt during the activity.");
    }

    public void ShowSpinner(int seconds)
    {
    List<string> animationStrings = new List<string>();
    animationStrings.Add("|");
    animationStrings.Add("/");
    animationStrings.Add("-");
    animationStrings.Add("\\");
    animationStrings.Add("|");
    animationStrings.Add("/");
    animationStrings.Add("-");
    animationStrings.Add("\\");

    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(seconds);

    int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(250); 
            Console.Write("\b \b"); 

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000); 
            Console.Write("\b \b"); 
        }
    }
}