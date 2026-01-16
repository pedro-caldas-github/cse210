public class Entry
{
    public string date;
    public string prompt;
    public string response;

    public void DisplayEntry()
    {
        Console.WriteLine($"{date} - {prompt}\n{response}\n");
    }
}