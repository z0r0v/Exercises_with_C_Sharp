namespace Classes001;

class Content
{
    private string? content;

    public string StringFieldContent
    {
        get
        {
            return !String.IsNullOrWhiteSpace(content) ? content : "Have not value";
        }
        set
        {
            content = value;
        }
    }

    public void Show()
    {
        Console.Write("Content: ");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write(StringFieldContent);
        Console.ResetColor();
        Console.Write("; ");
    }
}