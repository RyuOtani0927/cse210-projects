// Reflection Activity

// The activity should begin with the standard starting message and prompt for the duration that is used by all activities.

// The description of this activity should be something like: "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."

// After the starting message, select a random prompt to show the user

// After displaying the prompt, the program should ask the to reflect on questions that relate to this experience.

// After each question the program should pause for several seconds before continuing to the next one. While the program is paused it should display a kind of spinner.

// It should continue showing random questions until it has reached the number of seconds the user specified for the duration.

// The activity should conclude with the standard finishing message for all activities.



public class ReflectionActivity : Activity
{

    private List<string> reflectionPrompts = new();
    private List<string> reflectionQuestions = new();

    private List<int> usedReflectionPrompts = new();
    private List<int> usedReflectionQuestions = new();

    public ReflectionActivity()
    {
        _activityName = "Reflection";
        _activityDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

        reflectionPrompts.Add("Think of a time when you stood up for someone else.");
        reflectionPrompts.Add("Think of a time when you did something really difficult.");
        reflectionPrompts.Add("Think of a time when you helped someone in need.");
        reflectionPrompts.Add("Think of a time when you did something truly selfless.");

        reflectionQuestions.Add("Why was this experience meaningful to you?");
        reflectionQuestions.Add("Have you ever done anything like this before?");
        reflectionQuestions.Add("How did you get started?");
        // reflectionQuestions.Add("How did you feel when it was complete?");
        // reflectionQuestions.Add("What made this time different than other times when you were not as successful?");
        // reflectionQuestions.Add("What is your favorite thing about this experience?");
        // reflectionQuestions.Add("What could you learn from this experience that applies to other situations?");
        // reflectionQuestions.Add("What did you learn about yourself through this experience?");
        // reflectionQuestions.Add("How can you keep this experience in mind in the future?");
    }

    public void StartReflection()
    {
        DisplayStart();

        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(_activityTime);

        Random rnd = new();

        int randomIndex;

        do
        {
            randomIndex = rnd.Next(reflectionPrompts.Count);
        } while (usedReflectionPrompts.Contains(randomIndex));
        
        string reflectionPrompt = reflectionPrompts[randomIndex];

        usedReflectionPrompts.Add(randomIndex);

        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        Console.WriteLine($" --- {reflectionPrompt} --- ");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue. ");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        Countdown(5);

        Console.Clear();

        while (currentTime < futureTime)
        {
            Random rnd2 = new();

            int randomIndex2;

            do
            {
                randomIndex2 = rnd2.Next(reflectionQuestions.Count);
            } while (usedReflectionQuestions.Contains(randomIndex2));

            string reflectionQuestion = reflectionQuestions[randomIndex2];

            usedReflectionQuestions.Add(randomIndex2);

            Console.Write($"> {reflectionQuestion} ");
            Spinner();

            currentTime = DateTime.Now;
        }

        Console.WriteLine();

        DisplayEnd();

    }


}