public class Reference
{
    //This stores the references for scriptures: John 3:5, Proverbs 3:5-6
    //and sends it to the Scripture class

    //Atributtes
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    //Constructors

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    //Methods
    public string GetDisplayText()
    //This method builds the reference: book + " " + chapter + ":" + verse(s) and returns it
    {
        //This if says: if _endVerse was given a value then return a string with it included
        if (_endVerse != 0)
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}";
        }
    }
}