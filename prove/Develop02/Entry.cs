public class Entry
{
    public string _date = DateTime.Now.ToShortDateString();
    public string _text = "";

    public Entry(string text)
    {
        _text = text;
    }
    public Entry(string text, string date)
    {
        _text = text;
        _date = date;
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"{_date}");
        Console.WriteLine($"{_text}");
        Console.WriteLine();
    }

    public string StringEncode()
    {
        return $"{_date}\n{_text}\n";
    }


}