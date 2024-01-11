namespace Classes001;

class Book
{

    public void Show()
    {
        Title title = new Title();
        Author author = new Author();
        Content content = new Content();

        Console.Write("Send title: ");
        string userTitle = Console.ReadLine() ?? "Have not value";
        userTitle = userTitle != "" ? userTitle : "Have not value";

        Console.Write("Send author: ");
        string userAuthor = Console.ReadLine() ?? "Have not value";
        userAuthor = userAuthor != "" ? userAuthor : "Have not value";

        Console.Write("Send content: ");
        string userContent = Console.ReadLine() ?? "Have not value";
        userContent = userContent != "" ? userContent : "Have not value";

        title.StringFieldTitle = userTitle;
        author.StringFieldAuthor = userAuthor;
        content.StringFieldContent = userContent;

        author.Show();
        title.Show();
        content.Show();
    }
}