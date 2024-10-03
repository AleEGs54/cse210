public class Scripture{
    //This class receives the reference from the Reference class, also creates
    // a list of Word objects. It receives the entire scripture as a string
    //and divides the string into Word objects, each word comes with a isHidden value
    //that can be true or false (false is default). 

    //Attributes
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    //Constructors
    public Scripture(Reference Reference, string text)
    {
        //Empty
    }

    //Methods
    public void HideRandomWords(int numberToHide)
    //This calls the Hide method from the Word class to hide random words
    {
        
    }
    public string GetDisplayTexts()
    //Some text could be words, some other text could be underscores, useful to
    // store in a Word list and the use the Word object methods
    {
        return "";
    }
    public bool IsCompletelyHidden()
    //If this returns true, the program is over
    {
        return false;
    }
}