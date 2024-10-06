
public class Entry
{
    public string prompt;

    public string response;

    public string date;

    public string Arrange()
    {

        List<string> prompts = new();
        prompts.Add("Who was the most interesting person I interacted with today?");
        prompts.Add("What was the best part of my day?");
        prompts.Add("How did I see the hand of the Lord in my life today?");
        prompts.Add("What was the strongest emotion I felt today?");
        prompts.Add("If I had one thing I could do over today, what would it be?");

        Random rnd = new Random();
        int promptIndex = rnd.Next(prompts.Count);

        prompt = prompts[promptIndex];

        Console.WriteLine(prompt);
        Console.Write("> ");
        response = Console.ReadLine();

        DateTime theCurrentTime = DateTime.Now;
        date = theCurrentTime.ToShortDateString();

        string newEntry = $"Date: {date} - Prompt: {prompt}\n{response}";

        return newEntry;
    }
}