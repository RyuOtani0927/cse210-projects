
public class Scripture{
    private string _text;
    private List<Word> _wordClassList = new();

    private List<int> _hiddenWordIndexList = new();

    private bool _hidden = false;

    public void HideRandomWord(){

        if (_wordClassList.Count != _hiddenWordIndexList.Count){
            
            Random random = new Random();

            int randomIndex = random.Next(_wordClassList.Count);

        
            while (_hiddenWordIndexList.Contains(randomIndex)){
                randomIndex = random.Next(_wordClassList.Count);
            }
        

            Word randomWordClass = _wordClassList[randomIndex];
            randomWordClass.Hide();

            UpdateText();

            _hiddenWordIndexList.Add(randomIndex);
        }

        if ((_wordClassList.Count == _hiddenWordIndexList.Count)){
            _hidden = true;
        }

    }

    public void UpdateText(){
        // Update the _text after hiding some word, as _text and _wordClassList are separate.
        string text = "";
        foreach (Word wordClass in _wordClassList){
            text = text + wordClass.GetWord() + " ";
        }

        _text = text;
    }

    public void StoreEachWord(){
        // Store each word in the _text into a new wordClass and the _wordClassList.
        string[] wordList = _text.Split(" ");

        foreach (string word in wordList)
        {
            Word wordClass = new();

            wordClass.SetWord(word);

            _wordClassList.Add(wordClass);
        }
    }

    public string GetVerseText()
    {
        UpdateText();
        return _text;
    }
    public void SetVerseText(string text)
    {
        _text = text;
    }

    public bool GetIfHidden()
    {
        return _hidden;
    }


}