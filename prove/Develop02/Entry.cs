using System;

public class Entry
{
    public string Prompt { get; private set; }
    public string Response { get; private set; }
    public DateTime Date { get; private set; }

    public Entry(string prompt, string response, DateTime date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }

    public Entry(string prompt, string response)
    {
        Prompt = prompt;
        Response = response;
    }

    public override string ToString()
    {
        return $"Date: {Date}\nPrompt: {Prompt}\nResponse: {Response}\n";
    }
}
