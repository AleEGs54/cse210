public class Word{
    //It's kind of an auxiliar class. Creates an object Word which contains a single
    //word from a string and assigns a value if it's hidden or not. Has the ability
    //to hide, show, tell if a word is hidden or not and get the word that is 
    //displayed in the console.

    //Attributes
    private string _text;
    private bool _isHidden;

    //Constructors

    public Word(string text) 
    {
        
    }

    //Methods

    public void Hide()
    {
        
    }
    public void Show()

    {

    }
    public bool isHidden()
    //Verifies if a word is hidden or not
    {
        return false;
    }
    public string GetDisplayText()
    //The word this method retrieves could be a word (like "prayer") or the hidden version
    //(____). It's usefull to then call the isHidden function, to determine if it's hidden or not.
    {
        return "";
    }



}