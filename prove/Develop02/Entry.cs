
public class Entry
{
    public string prompt;

    public string response;

    public string date;

    public int score;

    public string Arrange()
    {

        string arranged = $"Date: {date} - Score: {score}\nPrompt: {prompt}\n{response}";

        return arranged;
    }
}