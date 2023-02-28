//Tracks the book, chapter, and verse of a scripture
public class Reference
{
    private string _book;

    private int _chapter;

    private string _startVerse;

    private string _endVerse;

    public Reference(string book, int chapter, int startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = Convert.ToString(startVerse);
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = Convert.ToString(startVerse);
        _endVerse = Convert.ToString(endVerse);
    }

    //Getter and Setter for Book value
    public string GetBook(string newBook)
    {
        return _book;
    }
    public void SetBook(string newBook)
    {
        _book = newBook;
    }

    //Getter and Setter for Chapter value
     public int GetChapter(int newChapter)
    {
        return _chapter;
    }
    public void SetChapter(int newChapter)
    {
        _chapter = newChapter;
    }

    //Getter and Setter for Start Verse value
     public string GetStartVerse(string newStartVerse)
    {
        return _startVerse;
    }
    public void SetStartVerse(string newStartVerse)
    {
        _startVerse = newStartVerse;
    }

    //Getter and Setter for End Verse value
      public string GetEndVerse(string newEndVerse)
    {
        return _endVerse;
    }
    public void SetEndVerse(string newEndVerse)
    {
        _endVerse = newEndVerse;
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