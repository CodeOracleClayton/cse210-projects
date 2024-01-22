public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(string book, string chapter, string verses, string FullScripture)
    {
        _reference = new Reference(book, chapter, verses);
        string[] verseWords = FullScripture.Split(" ");
        for (int i = 0; i < verseWords.Length; i++)
        {
            Word newWord = new Word(verseWords[i]);
            _words.Add(newWord);
        }
    }
    public void HideWords()
    {
        int x = 0;
        Random random = new Random();
        while (x < 4)
        {
            int index = random.Next(_words.Count);
            if (_words[index].IsShown())
            {
                x++;
                _words[index].Hide();

            }

        }
    }
    public void DisplayRenderedText()
    {
        Console.WriteLine($"{_reference.GetReference()} - ");
        foreach (Word word in _words)
        {
            Console.Write($" {word.GetWord()}");
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {

            if (word.IsShown())
            {
                return false;
            }
        }
        return true;
    }

}