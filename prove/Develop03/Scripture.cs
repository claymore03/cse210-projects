//Tracks the text of a scripture reference
public class Scripture
{
    // private List<string> _text = new List<string>()
    // {
    //     "For God so bloved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.", "Behold, I would exhort you that when ye shall read these things, if it be wisdom in God that ye should read them, that ye would remember how merciful the Lord hath been unto the children of men, from the creation of Adam even down until the time that ye shall receive these things, and ponder it in your hearts. And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. And by the power of the Holy Ghost ye may know the truth of all things."
    // };

    private string _text;

    public Scripture(string text)
    {
        _text = text;
    }

    public void SetText(string newText)
    {
        _text = newText;
    }

    public string DisplayText()
    {
        return $"{_text}";
    }

    public void SplitText()
    {
        string[] parts =  _text.Split($" ", System.StringSplitOptions.RemoveEmptyEntries);
        // for(int i=0;i<parts.Length;i++)
        // {
        //     Console.WriteLine(parts[i]);
        // }
    }

    
}