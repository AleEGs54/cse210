public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _emotion;

    public void Display()
    {
        //This method must add 3 things: the date + the prompt + the entry text (answer)
        //$"{date} {promptText}: {entryText} "
        string anEntry = $"\nDate: {_date} - Prompt: {_promptText} \nanswer: {_entryText} \nemotion: {_emotion}";
        Console.WriteLine(anEntry);
    }
}