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
        //El metodo que llame a show, debe escoger tres palabras aleatoriamente y marcarlas como _isHidden. Luego, Show() llama a Hide para escoder palabras marcadas, si no están marcadas, solo lo dejarán pasar.

        //Activates the _isHidden attribute as true.
        _isHidden = true;
    }
    public void Show()
    {//If a word is hidden, the show method shows an underscore, otherwise it shows the word

        if (_isHidden == true)
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
    }
    public bool IsHidden()
    //Verifies if a word is hidden or not
    //If isHidden = true; return true, else, false.
    {
        if (_isHidden == true)
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
        Show();
        return _text;
    }



}