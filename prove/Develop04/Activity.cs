public class Activity
{
    protected string _activityName;
    protected string _activityDescription;
    protected int _activityTime;

    public void DisplayStart()
    {
        Console.WriteLine();
        Console.WriteLine($"Welcome to the {_activityName} Activity.");
        Console.WriteLine();
        Console.WriteLine(_activityDescription);
        Console.WriteLine();
        Console.Write($"How long, in seconds, would you like for your sesson?");
        _activityTime = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Get ready...");
        Console.WriteLine();
    }
    
    public void DisplayEnd()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        Console.WriteLine();
        Console.WriteLine($"You have completed another 30 seconds of the {_activityName} Activity.");
    }

}