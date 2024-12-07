public class Video
{
    private string _title;
    private string _author;
    private double _length;
    private List<Comment> _commentList = new();

    public Video(string title, string author, double length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public string GetTitle()
    {
        return _title;
    }
    public void SetTitle(string title)
    {
        _title = title;
    }
    public string GetAuthor()
    {
        return _author;
    }
    public void SetAuthor(string author)
    {
        _author = author;
    }
    public double GetLength()
    {
        return _length;
    }
    public void SetLength(double length)
    {
        _length = length;
    }

    public int CountComments()
    {
        return _commentList.Count;
    }
    public void DisplayVideoInfo()
    {

        Console.WriteLine();
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");

        Console.WriteLine("Comments:");
        foreach (Comment comment in _commentList)
        {
            Console.WriteLine(comment.GetComment());
        }
        Console.WriteLine();

    }
    public void AddComment(string commenterName, string commentText)
    {
        Comment newComment = new Comment(commenterName,commentText);

        _commentList.Add(newComment);
    }
}