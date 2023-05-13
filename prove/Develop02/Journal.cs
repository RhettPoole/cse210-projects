using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    private List<Entry> entries = new List<Entry>();

    public void AddEntry(string prompt, string response)
    {
        // Get the current date and time
        DateTime now = DateTime.Now;

        // Create a new Entry object with the prompt, response, and date
        Entry entry = new Entry(prompt, response, now);

        // Save the entry to the list of entries
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        // Display all entries in the journal
        foreach (Entry entry in entries)
        {
            Console.WriteLine(entry.ToString());
        }
    }

    public void SaveToFile(string filename)
    {
        // Save the journal to the file
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine(entry.ToString());
            }
        }

        Console.WriteLine("Journal saved to file: " + filename);
    }

    public void LoadFromFile(string filename)
    {
        // Clear any existing entries
        entries.Clear();

        // Load entries from the file
        using (StreamReader reader = new StreamReader(filename))
        {
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] parts = line.Split('\t');

                if (parts.Length == 3)
                {
                    string prompt = parts[0];
                    string response = parts[1];
                    DateTime date = DateTime.Parse(parts[2]);

                    Entry entry = new Entry(prompt, response, date);
                    entries.Add(entry);
                }
            }
        }

        Console.WriteLine("Journal loaded from file: " + filename);
    }

    public void ClearEntries()
    {
        entries.Clear();
        Console.WriteLine("All entries cleared.");
    }
}
