using System;
using System.Diagnostics;

public class Listing : Activity
{
    private List<string> _promptList = new List<string>
    {
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"
    };
    private List<string> _userList = new List<string>();
    private string _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

    public Listing(string activityName, int activityDuration) : base(activityName, activityDuration)
    {

    }
    public void GetActivityDescription()
    {
        Console.WriteLine(_description);
    }
    private string GetRandomPrompt()
    {
        var random = new Random();
        int index = random.Next(_promptList.Count);
        return _promptList[index];
    }
    public void ReturnPrompt(int seconds)
    {
        Console.WriteLine();
        var question = GetRandomPrompt();
        Console.WriteLine("List as many resposes as you can to the following prompt:");
        Console.WriteLine($"--- {question} ---");
        CountDown(8);
        Timer(seconds);
    }
    public void Timer(int seconds)
    {
        Stopwatch timer = new Stopwatch();
        timer.Start();
        while (timer.Elapsed.TotalSeconds < seconds)
        {
            Console.Write("> ");
            _userList.Add(Console.ReadLine());
        }
        timer.Stop();
        int listLength = _userList.Count;
        Console.WriteLine($"You listed {listLength} items!");
    }

}