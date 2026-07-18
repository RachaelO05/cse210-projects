public class Word
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
        _isHidden = false;
    }

    public bool IsHidden()
    {
        bool hidden = _isHidden;
        return hidden;
    }

    public string GetDisplayText()
    {
        string displayText = "";
        if (_isHidden == false)
        {
            displayText = _text;
        }
        else if (_isHidden == true)
        {
            for(int i = 0; i < _text.Length; i++)
            {
                displayText += "_ ";
            }
        }
        return displayText;
    }
}