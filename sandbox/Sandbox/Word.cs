using System;
class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    { 
        if (_isHidden == true)
        {
            int textLength = _text.Length;
            _text = " ";
            for (int i = 0; i < textLength; i++)
            {
                _text = "_";
            }
        }
        

    }
    public bool Ishidden()
    {
        return true;
    }
    public string GetDisplayText()
    {
        Show();
        return _text;
    }
}