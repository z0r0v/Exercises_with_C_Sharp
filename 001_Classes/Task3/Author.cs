namespace Classes001;

class Author
{
    private string author = "Have not value";

    public string StringFieldAuthor
    {
        get => author;
        set => author = value;
    }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Author: " + StringFieldAuthor + "; ");
        Console.ResetColor();
    }
}