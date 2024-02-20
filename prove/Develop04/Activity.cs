using System;
using System.Diagnostics;
public class Activity
{
    private string _name;
    private string _description = "You may beging in...";
    private int _duration;

    public Activity(string activityName, int activityDuration)
    {
        _name = activityName;
        _duration = activityDuration;

    }
    public void GetActivityName()
    {
        Console.WriteLine($"Welcome to the {_name} Activity");
    }
    public void SetActivityName(string activityName)
    {
        _name = activityName;
    }
    public int GetActivityTime()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        int userSeconds = Int32.Parse(Console.ReadLine());
        _duration = userSeconds;
        return userSeconds;
    }
    public void SetActivityTime(int activityTime)
    {
        _duration = activityTime;
    }
    public void GetReady()
    {
        Console.Clear();
        Spinner spinner = new Spinner();
        spinner.ShowSpinnerReady();
    }
    public void GetDone()
    {
        Spinner spinner = new Spinner();
        spinner.ShowSpinnerDone();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity!");
        spinner.ShowSpinner();
    }
    public void CountDown(int time)
    {
        Console.WriteLine();
        for (int i = time; i > 0; i--)
        {
            Console.Write($"{_description}{i}");
            Thread.Sleep(1000);
            string blank = new string('\b', (_description.Length + 5));
            Console.Write(blank);
        }
        Console.WriteLine($"Go:                                  ");
    }

}