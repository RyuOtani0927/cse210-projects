
public class Entry
{
    public string prompt;

    public string response;

    public string date;

    public string Arrange()
    {

        string arranged = $"Date: {date} - Prompt: {prompt}\n{response}";

        return arranged;
    }
}