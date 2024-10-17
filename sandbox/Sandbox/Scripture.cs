using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        string[] texts = text.Split(",");
        foreach(var subtext in texts)
        {
            Word word = new Word(subtext);
            _words.Add(word);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        int randomNumberInRange = rand.Next(1,5);
        randomNumberInRange = numberToHide;

    }

    public string GetDisplayText()
    {
        
        return _reference.GetDisplayText() + " "+ _words ;
    }
    public bool IsCompletelyHidden()
    {
        return true;
    }

}