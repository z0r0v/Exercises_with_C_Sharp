// Задание 3 
// Используя Visual Studio, создайте проект по шаблону Console Application. 
// Требуется: 
// Создать класс Book. Создать классы Title, Author и Content, каждый из которых должен содержать 
// одно строковое поле и метод void Show(). 
// Реализуйте возможность добавления в книгу названия книги, имени автора и содержания. 
// Выведите на экран разными цветами при помощи метода Show() название книги, имя автора и 
// содержание. 


#nullable disable
namespace Classes001;

class Book
{

    public void Show()
    {
        Title title = new Title();
        Author author = new Author();
        Content content = new Content();

        Console.Write("Send title: ");
        string userTitle = Console.ReadLine();
        Console.Write("Send author: ");
        string userAuthor = Console.ReadLine();
        Console.Write("Send content: ");
        string userContent = Console.ReadLine();

        bool dataTitleIsEmpty = String.IsNullOrWhiteSpace(userTitle);
        bool dataAuthorIsEmpty = String.IsNullOrWhiteSpace(userAuthor);
        bool dataContentIsEmpty = String.IsNullOrWhiteSpace(userContent);

        if (!dataTitleIsEmpty)
        {
            title.StringFieldTitle = userTitle!;
        }

        if (!dataAuthorIsEmpty)
        {
            author.StringFieldAuthor = userAuthor!;
        }

        if (!dataContentIsEmpty)
        {
            content.StringFieldContent = userContent!;
        }

        author.Show();
        title.Show();
        content.Show();
    }
}