public class Video
{
    //Attributes
    private string _title;
    private string _author;
    private double _lengthInSeconds;
    private List<Comment> _comments;

    //Constructor
    public Video(string title, string author, double seconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = seconds;
        _comments = new List<Comment>();
    }

    //Setters & Getters

    //Methods
    public void StoreComments(Comment comment)
    {
        _comments.Add(comment);
    }

    public double NumberOfComments()
    {
        return _comments.Count();
    }
    public void DisplayVideo()
    {
        Console.WriteLine($"Video: {_title} - {_author} - {_lengthInSeconds} seconds");
        foreach(Comment comment in _comments)
        {
            Console.WriteLine(comment.CommentTracker());
        }
    }
}