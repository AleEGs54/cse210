public class Entry 
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        //This method must add 3 things: the date + the prompt + the entry text (answer)
        //$"{date} {promptText}: {entryText} "
        string anEntry = $"Date: {_date} - Prompt: {_promptText} \n Answer: {_entryText} \n";
        Console.WriteLine(anEntry);
    }
}