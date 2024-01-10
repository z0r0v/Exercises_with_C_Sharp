namespace Classes001;

class Author
{
    private string? author;

    public string StringFieldAuthor
    {
        get
        {
            return !String.IsNullOrWhiteSpace(author) ? author : "Have not value";
        }
        set
        {
            author = value;
        }
    }

    public void Show()
    {
        Console.Write("Author: ");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write(StringFieldAuthor);
        Console.Write(" ");
        Console.ResetColor();
    }
}