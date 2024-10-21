
public class Verse{
    private string _text;
    private List<Word> wordClassList = new();

    public void StoreEachWord(){

        string[] wordList = _text.Split(" ");

        foreach (var word in wordList)
        {
            Word wordClass = new();

            wordClass.SetWord(word);

            wordClassList.Add(wordClass);
        }
    }

    public string GetVerseText()
    {
        return _text;
    }
    public void SetVerseText(string text)
    {
        _text = text;
    }

}