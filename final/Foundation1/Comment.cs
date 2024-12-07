public class Comment
{
    private string _commenterName;
    private string _commentText;

    public Comment(string name, string text)
    {
        _commenterName = name;
        _commentText = text;
    }
    public string GetName()
    {
        return _commenterName;
    }
    public void SetName(string name)
    {
        _commenterName = name;
    }
    public string GetText()
    {
        return _commentText;
    }
    public void SetText(string text)
    {
        _commentText = text;
    }

    public string GetComment()
    {
        return $"{_commenterName} - {_commentText}";
    }


}