// Breathing Activity

// The activity should begin with the standard starting message and prompt for the duration that is used by all activities.

// The description of this activity should be something like:
// "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."

// After the starting message, the user is shown a series of messages alternating between "Breathe in..." and "Breathe out..."

// After each message, the program should pause for several seconds and show a countdown.

// It should continue until it has reached the number of seconds the user specified for the duration.

// The activity should conclude with the standard finishing message for all activities.



public class BreathingActivity : Activity
{

    public BreathingActivity()
    {
        _activityName = "Breathing";
        _activityDescription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void StartBreathing()
    {
        
        DisplayStart();

        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(_activityTime);

        Console.WriteLine();

        while (currentTime < futureTime)
        {
            Random rnd = new Random();
            int BreatheInTime = rnd.Next(3,6);
            int BreatheOutTime = rnd.Next(3,6);

            Console.Write("Breathe in...");
            Countdown(BreatheInTime);

            Console.Write("Now breathe out...");
            Countdown(BreatheOutTime);
            
            Console.WriteLine();

            currentTime = DateTime.Now;
        }

        DisplayEnd();

    }

}