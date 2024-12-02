
public class Reference{

    private string _book;
    private int _chapter;
    private int _startverse;
    private int _endverse;

    private List<Scripture> _scriptureClassList = new();

    private bool _allHidden;

    public Reference(string book,int chapter,int singleverse, List<string> verseList) // Constructor
    {
        _book = book;
        _chapter = chapter;
        _startverse = singleverse;
        _endverse = singleverse;
        _allHidden = false;

        foreach (string verseText in verseList)
        {
            Scripture verseClass = new();

            verseClass.SetVerseText(verseText);

            _scriptureClassList.Add(verseClass);

            verseClass.StoreEachWord();
        }
    }

    public Reference(string book,int chapter,int start,int end, List<string> verseList) // Constructor
    {
        _book = book;
        _chapter = chapter;
        _startverse = start;
        _endverse = end;
        _allHidden = false;

        foreach (string verseText in verseList)
        {
            Scripture verseClass = new();

            verseClass.SetVerseText(verseText);

            _scriptureClassList.Add(verseClass);

            verseClass.StoreEachWord();
        }
    }



    public void StoreEachVerse(List<string> verseList)
    {
        foreach (string verseText in verseList)
        {
            Scripture verseClass = new();

            verseClass.SetVerseText(verseText);

            _scriptureClassList.Add(verseClass);

            verseClass.StoreEachWord();
        }
    }


    public void DisplayEachVerse()
    {

        int verseNum = _startverse;

        if (_startverse == _endverse){
            Console.WriteLine($"{_book} {_chapter}:{_startverse}");
        }
        else {
            Console.WriteLine($"{_book} {_chapter}:{_startverse}-{_endverse}");
        }

        foreach (Scripture verseClass in _scriptureClassList)
        {   
            Console.WriteLine($"Scripture {verseNum}: {verseClass.GetVerseText()}");
            verseNum = verseNum + 1;            
        }

    }

    public void HideRandomWords()
    {

        _allHidden = true;

        foreach (Scripture verseClass in _scriptureClassList){
            verseClass.HideRandomWord();
            if (verseClass.GetIfHidden() == false){
                _allHidden = false;
            }
        }
    }

    public void Memorizor()
    {
        Console.WriteLine();

        DisplayEachVerse();

        Console.WriteLine();

        Console.WriteLine("Press enter to continue or type 'quit' to finish:");

        string response = Console.ReadLine();
        
        while (response != "quit" && _allHidden == false){

            if (response != "quit"){
                HideRandomWords();
                HideRandomWords();
            }

            Console.Clear();

            DisplayEachVerse();

            Console.WriteLine();

            Console.WriteLine("Press enter to continue or type 'quit' to finish:");

            response = Console.ReadLine();

        }
        
        Console.WriteLine();

    }
}