namespace Classes001;

class Content
{
    private string content = "Have not value";

    public string StringFieldContent
    {
        get => content;
        set => content = value;
    }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("Content: " + StringFieldContent + "; ");
        Console.ResetColor();
    }
}