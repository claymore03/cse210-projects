//Tracks the book, chapter, and verse of a scripture
public class Reference
{
    private string _book;

    private int _chapter;

    private int _startVerse;

    private int _endVerse;

    public Reference(string book, int chapter, int startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public string SingleVerseScripture()
    {
        return $"{_book} {_chapter}:{_startVerse}";
    }

    public string MultiVerseScripture()
    {
        return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
    }
}