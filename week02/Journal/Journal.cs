using System;

public class Journal
{
    List<Entry> entries = new List<Entry>();

    public void AddEntry(string prompt, string response)
    {
        DateTime date = DateTime.Now;
        Entry entry = new Entry
        {
            Prompt = prompt,
            Response = response,
            Date = date
        };
        entries.Add(entry);
    }
    public void DisplayAll()
    {
        foreach (var entry in entries)
        {
            entry.Display();
            Console.WriteLine("--------------------");
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry.Date.ToShortDateString()}|{entry.Prompt}|{entry.Response}");
            }
        }
    }
    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        DateTime date = DateTime.Parse(parts[0]);
                        string prompt = parts[1];
                        string response = parts[2];
                        Entry entry = new Entry
                        {
                            Date = date,
                            Prompt = prompt,
                            Response = response
                        };
                        entries.Add(entry);
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}