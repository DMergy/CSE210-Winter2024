using System;

public class PromptGenerator
{
    public static string[] _prompt =
    {
        "What was the best moment of your day and why? ",
        "Who did you share a special moment with today? ",
        "What was your something new that you learned today? ",
        "Who made you feel special or made you smile today?" ,
        "What do you most wish for tomorrow? ",
        "Did you receive any unexpected blessings today that you attribute to your faith? ",
    };
    public List<string> _journalPrompt = new List<string>(_prompt);

    public PromptGenerator()
    {

    }

    public void Display()
    {
        var random = new Random();
        int index = random.Next(_journalPrompt.Count);
        string journalPrompt = _journalPrompt[index];
        Console.WriteLine($"\n{_journalPrompt}");
    }

    public string GetPrompt()
    {
        var random = new Random();
        int index = random.Next(_journalPrompt.Count);
        string journalPrompt = _journalPrompt[index];

        return journalPrompt;
    }

}
