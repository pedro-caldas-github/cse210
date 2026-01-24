public class Reference
{

    public string _book;
    public int _chapter;
    public int _verse;
    public int _endVerse;
    private int v;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, int chapter, int verse, int v) : this(book, chapter, verse)
    {
        this.v = v;
    }

    public Reference(string book, int chapter, int verse, int endVerse, int startVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        if (_endVerse > 0)
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}";
        }
    }


}