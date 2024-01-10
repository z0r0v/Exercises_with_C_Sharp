namespace Classes001;
class Title
{
    private string? title;

    public string StringFieldTitle
    {
        get
        {
            return !String.IsNullOrWhiteSpace(title) ? title : "Have not value";
        }
        set
        {
            title = value;
        }
    }

    public void Show()
    {
        Console.Write("Title: ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(StringFieldTitle);
        Console.Write(" ");
        Console.ResetColor();
    }
}