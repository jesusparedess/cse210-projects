using System;
using System.Collections.Generic;

public class Library
{
    private List<Scripture> _scriptures;
    private Random _random;

    public Library()
    {
        _scriptures = new List<Scripture>();
        _random = new Random();
    }

    public void AddScripture(Reference reference, string text)
    {
        _scriptures.Add(new Scripture(reference, text));
    }

    public Scripture GetRandomScripture()
    {
        if (_scriptures.Count == 0)
        {
            throw new InvalidOperationException("No scriptures have been added to the library.");
        }

        int index = _random.Next(_scriptures.Count);
        return _scriptures[index];
    }
}
