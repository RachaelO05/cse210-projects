public class Entry
{
    public string _date;
    public string _mood;
    public string _promptText;
    public string _entryText;

    public void Display ()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Mood: {_mood}");
        Console.WriteLine($"Prompt Text: {_promptText}");
        Console.WriteLine($"Entry Text: {_entryText}");
    }
}