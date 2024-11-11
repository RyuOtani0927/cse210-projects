public class Activity
{
    protected string _activityName;
    protected string _activityDescription;
    protected int _activityTime;

    public string GetActivityName()
    {
        return _activityName;
    }

    public void SetActivityName(string activityName)
    {
        _activityName = activityName;
    }

    public string GetActivityDescription()
    {
        return _activityDescription;
    }

    public void SetActivityDescription(string activityDescription)
    {
        _activityDescription = activityDescription;
    }

    public int GetActivityTime()
    {
        return _activityTime;
    }

    public void SetActivityTime(int activityTime)
    {
        _activityTime = activityTime;
    }



    public void DisplayStart()
    {
        Console.Clear();
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
        Console.WriteLine();
    }

    public void Countdown(int countTime)
    {
        int counter = countTime;

        while (counter > 0)
        {
            Console.Write(counter);

            Thread.Sleep(1000);

            Console.Write("\b \b");

            counter = counter - 1;
        }

        Console.WriteLine();

    }
    

}