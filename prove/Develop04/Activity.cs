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
        Console.Write($"How long, in seconds, would you like for your sesson? ");
        _activityTime = int.Parse(Console.ReadLine());

        Console.Clear();

        Console.WriteLine();

        Console.WriteLine("Get ready...");
        Spinner();
    }
    
    public void DisplayEnd()
    {
        Console.WriteLine("Well done!!");
        Spinner();
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_activityTime} seconds of the {_activityName} Activity.");
        Spinner();
        
        Console.Clear();
    }

    public void Spinner()
    {
        List<string> spinMarks = ["/","-","\\","|"];
        int spinIndex = 0;

        int pauseTime = 5; // in seconds

        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(pauseTime);

        while (currentTime < futureTime)
        {

            Console.Write(spinMarks[spinIndex]);

            Thread.Sleep(500);

            Console.Write("\b \b");
            
            spinIndex = spinIndex + 1;

            if (spinIndex == 4)
            {
                spinIndex = 0;
            }

            currentTime = DateTime.Now;
        }
    }

    

}