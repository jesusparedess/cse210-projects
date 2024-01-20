using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Journal
{
    private List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void AddEntry(string prompt, string response)
    {
        entries.Add(new Entry(prompt, response));
    }

    public void DisplayJournal()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveJournal(string filename)
    {
        using (StreamWriter file = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                string line = $"\"{entry.Date.ToString("o")}\",\"{entry.Prompt.Replace("\"", "\"\"")}\",\"{entry.Response.Replace("\"", "\"\"")}\"";
                file.WriteLine(line);

            }
        }
    }

    public void LoadJournal(string filename)
    {
        entries.Clear();
        using (StreamReader file = new StreamReader(filename))
        {
            string line;
            while ((line = file.ReadLine()) != null)
            {
                string[] parts = line.Split(new char[] { ',' }, 3);
                string date = parts[0].Trim('"');
                string prompt = parts[1].Trim('"').Replace("\"\"", "\"");
                string response = parts[2].TrimStart(' ').Trim('"').Replace("\"\"", "\"");

                DateTime entryDate = DateTime.ParseExact(date, "o", null);

                entries.Add(new Entry(prompt, response, entryDate)); 
            }
        }
    }
}
