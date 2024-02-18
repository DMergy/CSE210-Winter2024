class Activity
{
    private string _activityName;
    private string _activityDescription;
    private int _activityDuration;

    public Activity(string activityName, int activityDuration)
    {
        _activityName = activityName;
        _activityDuration = activityDuration;

    }
    public void GetActivityName()
    {
        Console.WriteLine($"Welcome to the {_activityName} Activity");
    }
    
}