using System;
using System.Diagnostics;
public class Breathing : Activity
{
    private string _script1 = "Breathe in...";
    private string _script2 = "Now, breathe out...";
    private string _description = "This activity will help you relax by walking you through breathing in and out slowly.  Clear your mind and focus on your breathing.";
    
    public Breathing(string activityName, int activityDuration) : base(activityName, activityDuration)
    {

    }
    public void GetActivityDescription()
    {
        Console.WriteLine(_description);
    }

    public void BreathingActivity(int seconds)
    {
        Console.WriteLine();
        int secondsTimer = 0;
        while (secondsTimer < seconds)
        {
            Console.WriteLine();
            for (int i = 4; i > 0; i--)
            {
                Console.Write($"{_script1}{i}");
                Thread.Sleep(1000);
                string blank = new string('\b', (_script1.Length + 2));
                Console.Write(blank);
                secondsTimer += 1;
            }
            Console.WriteLine($"{_script1}  ");
            for (int i = 5; i > 0; i--)
            {
                Console.Write($"{_script2}{i}");
                Thread.Sleep(1000);
                string blank = new string('\b', (_script2.Length + 2));
                Console.Write(blank);
                secondsTimer += 1;
            }
            Console.WriteLine($"{_script2}  ");
        }

    }
}