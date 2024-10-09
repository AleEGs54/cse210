public class Video
{
    //Attributes
    private string _title;
    private string _author;
    private float _length;
    private List<Comment> _comments = new List<Comment>();

    //Constructors

    public Video(string title, string author, float length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    //Methods

    public void StoreComment(string name, string text)
    {
        //To store comments, first it creates a new instance of comments 
        //and add the name and text and aruments for the Comment constructor, 
        //finally it adds the comment instance to the list
        Comment comment = new Comment(name, text);
        _comments.Add(comment);
    }

    public int ReturnNumberOfComments()
    {
        return _comments.Count;
    }

    public string DisplayAll()
    {
        string allComments = "";
        foreach (Comment comment in _comments)
        {
            allComments += $"{comment.Display()}\n";
        }
        return $"\n{_title} - By {_author}, Lenght: {_length} minutes - Total Comments: {ReturnNumberOfComments()} \n\n{allComments}";
    }
}