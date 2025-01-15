using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> entries;
    private List<string> prompts;

    public Journal()
    {
        entries = new List<Entry>();
        prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
    }

    public void WriteNewEntry()
    {
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Count)];
        Console.WriteLine($"\nPrompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();
        string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        entries.Add(new Entry(date, prompt, response));
        Console.WriteLine("Entry saved!");
    }

    public void DisplayJournal()
    {
        Console.WriteLine("\nJournal Entries:");
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveJournalToFile()
    {
        Console.Write("Enter filename to save the journal: ");
        string filename = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine(entry.ToFileString());
            }
        }
        Console.WriteLine("Journal saved successfully.");
    }

    public void LoadJournalFromFile()
    {
        Console.Write("Enter filename to load the journal: ");
        string filename = Console.ReadLine();
        if (File.Exists(filename))
        {
            entries.Clear();
            string[] lines = File.ReadAllLines(filename);
            foreach (var line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    entries.Add(new Entry(parts[0], parts[1], parts[2]));
                }
            }
            Console.WriteLine("Journal loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
