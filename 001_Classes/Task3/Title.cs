namespace Classes001;
class Title
{
    private string title = "Have not value";

    public string StringFieldTitle
    {
        get => title;
        set => title = value;
    }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Title: " + StringFieldTitle + "; ");
        Console.ResetColor();
    }
}