
public class Verse{
    private string _text;
    private List<Word> wordClassList = new();

    private List<int> hiddenWordIndexList = new();

    private bool _hidden = false;

    public void HideRandomWord(){

        if (wordClassList.Count != hiddenWordIndexList.Count){
            
            Random random = new Random();

            int randomIndex = random.Next(wordClassList.Count);

        
            while (hiddenWordIndexList.Contains(randomIndex)){
                randomIndex = random.Next(wordClassList.Count);
            }
        

            Word randomWordClass = wordClassList[randomIndex];
            randomWordClass.Hide();

            UpdateText();

            hiddenWordIndexList.Add(randomIndex);
        }

        if ((wordClassList.Count == hiddenWordIndexList.Count)){
            _hidden = true;
        }

    }

    public void UpdateText(){
        // Update the _text after hiding some word, as _text and wordClassList are separate.
        string text = "";
        foreach (Word wordClass in wordClassList){
            text = text + wordClass.GetWord() + " ";
        }

        _text = text;
    }

    public void StoreEachWord(){
        // Store each word in the _text into a new wordClass and the wordClassList.
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