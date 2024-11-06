
public class Entry
{
    public string _entryPrompt;

    public string _userResponse;

    public string _entryDate;

    public int _score;

    public string Arrange()
    {

        string arranged = $"Date: {_entryDate} - Score: {_score}\nPrompt: {_entryPrompt}\n{_userResponse}";

        return arranged;
    }
}