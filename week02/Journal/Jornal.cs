public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    // public void AddEntry(string date, string prompt, string response)
    // {
    //     Entry newEntry = new Entry();
    //     newEntry.date = date;
    //     newEntry.prompt = prompt;
    //     newEntry.response = response;

    //     _entries.Add(newEntry);
    // }

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAllEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }

public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    Entry entry = new Entry();
                    entry.date = parts[0];
                    entry.prompt = parts[1];
                    entry.response = parts[2];
                    _entries.Add(entry);
                }
            }
        }
    }

public void SaveToFile(string filename)
    {
        List<string> lines = new List<string>();

        foreach (Entry e in _entries)
        {
            lines.Add($"{e.date}|{e.prompt}|{e.response}");
        }

        File.WriteAllLines(filename, lines);
    }
}