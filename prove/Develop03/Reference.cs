public class Reference
{
    private string _book;

    private string _chapter;

    private string _verseText;

    public Reference(string book, string chapter, string verseOne)
    {
        _book = book;
        _chapter = chapter;
        _verseText = verseOne;
    }
    public Reference(string book, string chapter, string verseOne, string verseTwo)
    {
        _book = book;
        _chapter = chapter;
        _verseText = $"{verseOne} - {verseTwo}";
    }
    public string GetReference()
    {
        return $"{_book} {_chapter}: {_verseText}";
    }
}
