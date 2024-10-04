public class Word
{
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
        _text = text;
        _isHidden = false;
    }

    //Methods

    public void Hide()
    {
        //Takes a word (_text) and retrieves the lenght, then replaces the word with as many undercores are needed

        //Storing the lenght of the word
        int lenghtText = _text.Length;

        //Redeclaring the word as empty
        _text = "";

        //Filling the variable with as many underscores as needed according to the lenght of the original word. As result, _text will be "____...___"
        for (int i = 0; i < lenghtText; i++)
        {
            _text += "_";
        }

    }
    public void Show()
    {
        
    }
    public bool IsHidden()
    //Verifies if a word is hidden or not
    {
        //If firstLetter of the word is underscore, it means that the word is hidden.
        char firtsLetter = _text[0];
        if (firtsLetter == '_' )
        {
        return true;
        }
        else
        {
        return false;
        }

    }
    public string GetDisplayText()
    //The word this method returns could be a word (like "prayer") or the hidden version (____).
    {
        return _text;
    }



}