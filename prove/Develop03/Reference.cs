
public class Reference{

    private string _book;
    private int _chapter;
    private int _startverse;
    private int _endverse;

    private List<Verse> verseClassList = new();

    public Reference(string book,int chapter,int singleverse, List<string> verseList) // Constructor
    {
        _book = book;
        _chapter = chapter;
        _startverse = singleverse;
        _endverse = singleverse;

        foreach (string verseText in verseList)
        {
            Verse verseClass = new();

            verseClass.SetVerseText(verseText);

            verseClassList.Add(verseClass);
        }
    }

    public Reference(string book,int chapter,int start,int end, List<string> verseList) // Constructor
    {
        _book = book;
        _chapter = chapter;
        _startverse = start;
        _endverse = end;

        foreach (string verseText in verseList)
        {
            Verse verseClass = new();

            verseClass.SetVerseText(verseText);

            verseClassList.Add(verseClass);
        }
    }



    public void StoreEachVerse(List<string> verseList)
    {
        foreach (string verseText in verseList)
        {
            Verse verseClass = new();

            verseClass.SetVerseText(verseText);

            verseClassList.Add(verseClass);
        }
    }

    public void DisplayEachVerse()
    {
        foreach (Verse verseClass in verseClassList)
        {
            Console.WriteLine(verseClass.GetVerseText());
        }

    }
}