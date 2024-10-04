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
        //Stores the reference
        _reference = Reference;

        //Stores the list, divides the list, and create a Word instance for each word
        //to finally store each word in the Word list called _words

        //Dividing the text string into a list of strings
        List<string> newWord = text.Split(' ').ToList();

        //Creating a loop to give each word a Word instance
        foreach (string word in newWord)
        {
        //Creating an instance of the class Word and inserting each word in the instance as parameter
            Word aWord = new Word(text: word);
            _words.Add(aWord);
        }
    }

    //Methods
    public void HideRandomWords(int numberToHide)
    //This calls the Hide method from the Word class to hide random words. Maybe call the random class and choose a number between 0 and the lenght of the List<Word> and return a number (or two) that will be used as an index to choose the words to hidde. numberToHidde says how many words we want to hidde at the same time
    {
        //Generating the random numbers
        Random random = new Random();

        //Creating a variable to iterate as many times an needed
        int count = 0;

        //Creating a loop to hide as many words as requested
        while (count < numberToHide)
        {
            //Each iteration will ask for a random number between 1 and the quantity of objects in the list.
            int randomNumber = random.Next(0, _words.Count);

            //If the word is already hidden, try again until another one is hidden
            if (_words[randomNumber].IsHidden() == false)
            {

            //Hidding the word in the [randomNumber] index in the _words object list
            _words[randomNumber].Hide();

            //Count + 1 each time a word is hidden
            count += 1;
            }



        }
        
        
    }
    public string GetDisplayText()
    //Displays the 
    {
        // $"{reference}"
        //Stores the reference in a string completely ready to be shown.
        string scriptureReference = _reference.GetDisplayText();

        string theScripture = "";

        //Iterar sobre _words (que retorna una lista de objetos Word) y de cada palabra obtenemos el texto.
        foreach (Word word in _words)
        {
            theScripture += $"{word.GetDisplayText()} ";
        }

        //Returns the full scripture ready to be shown.
        return $"{scriptureReference} {theScripture}";

    }
    public bool IsCompletelyHidden()
    //If this returns true, the program is over
    {
        //Iterate over each word in Words to make sure if all the words have a _isHidden value of true. If only a word has a false value, the entire function is false

        //Creating a variable to temporarily store the boolean info
        bool hiddenValue = true;

        //The while loop will end only if either hiddenValue is false o it reaches the break statement after determining each word instance has a falsy value.
        while (hiddenValue == true)
        {

            foreach (Word word in _words)
            {
                //Storing the hidden information
                hiddenValue = word.IsHidden();

                //Asks each word instance if the content is hidden, if not, the function will return false. Only one false is needed to make the entire function return false.
                if (hiddenValue == false)
                {
                    return false;
                }
            }

            break;
        }
        
        return true;
        



        
    }
}