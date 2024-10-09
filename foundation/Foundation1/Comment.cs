public class Comment {
    //Attributes
    private string _name;
    private string _text;

    //Constructors

    public Comment (string name, string text)
    {
        _name = name;
        _text = text;
    }

    //Methods
    public string Display()
    {
        return $"{_name}: {_text}";
    }
}