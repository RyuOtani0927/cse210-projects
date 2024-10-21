
public class Word{
    private string _word;

    public void Hide() // Hide the word.
    {
        
        string word = "";

        foreach (char character in _word)
        {
            word = word + "_";
        }

        _word = word;
    }

    public string GetWord()
    {
        return _word;
    }

    public void SetWord(string word)
    {
        _word = word;
    }


}