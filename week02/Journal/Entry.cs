using System;

public class Entry
{
    private string _prompt;
    private string _input;
    private string _date;

    public Entry(string prompt, string input, string date)
    {
        _prompt = prompt;
        _input = input;
        _date = date;
    }

    public void Display()
    {
        Console.WriteLine($"{_date} - {_prompt}");
        Console.WriteLine(_input);
        Console.WriteLine();
    }

    // Getters so Journal can save/load entries
    public string GetPrompt() => _prompt;
    public string GetInput() => _input;
    public string GetDate() => _date;
}
