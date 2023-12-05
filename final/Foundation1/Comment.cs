public class Comment
{
    //Attributes
    private string _name;
    private string _textComment;

    //Constructor
    public Comment(string name, string comment)
    {
        _name = name;
        _textComment = comment;
    }

    //Setters & Getters
    public string GetName()
    {
        return _name;
    }
    public string GetComment()
    {
        return _textComment;
    }

    //Methods
    public string CommentTracker()
    {
        return $"\tcomment: {_name} - {_textComment}";
    }
}