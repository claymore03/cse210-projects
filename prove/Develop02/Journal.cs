public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public List<string> _prompts = new List<string>()
    {
        "How have you seen the hand of the Lord in your life today?",
        "Have you done any good in the world today?  What specifically?",
        "How were you a problem solver today?",
        "Did you try anything new today? How did it go?",
        "How are you feeling today? Why are feeling this way?"
    };

    public Journal()
    {

    }

    public void DisplayPrompt()
    {
        var random = new Random();
        int index = random.Next(_prompts.Count);
        Console.WriteLine(_prompts[index]);
        Console.WriteLine(">Entry:");
    }

    public void SaveEntry(string text)
    {
        Entry e = new Entry(text);
        _entries.Add(e);
    }

    public void DisplayEntries()
    {
        for(int i=0;i<_entries.Count;i++)
        {
            _entries[i].DisplayEntry();
        }
    }

    public string StringEncode()
    {
        string combinedString = "";
        for(int i=0;i<_entries.Count;i++)
        {
            combinedString += _entries[i].StringEncode();
        }
        return combinedString;        
    }

    public void StringDecode(string readText)
    {
        string[] parts = readText.Split($"\n", System.StringSplitOptions.RemoveEmptyEntries);
        for(int i=0;i<parts.Length;i+=2)
        {
            Entry e = new Entry(parts[i+1], parts[i]);
            _entries.Add(e);
        }
       
    }

}