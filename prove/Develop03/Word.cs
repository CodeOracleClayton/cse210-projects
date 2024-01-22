public class Word
{
    private string _word;

    private bool _shown;

    public Word(string word)
    {
        _word = word;
        _shown = true;
    }
    public void Hide()
    {
        char[] letters = _word.ToCharArray();
        for (int i = 0; i < _word.Length; i++)
        {
            letters[i] = '_';
        }
        _word = new string(letters);
        _shown = false;
    }
    public string GetWord()
    {
        return _word;

    }
    public bool GetShown()
    {
        return _shown;

    }

    public bool IsShown()
    {
        if (_shown)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
