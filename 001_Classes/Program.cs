#nullable disable
namespace Classes001;

class Program
{
    static void Main()
    {
        Console.WriteLine("Send program number from the list provided");
        Console.WriteLine("AreaPerimeter: 1");
        Console.WriteLine("Book: 2");
        string programNumber = Console.ReadLine();

        if (programNumber == "1")
        {
            new AreaPerimeter().Run();
            return;
        }

        if (programNumber == "2")
        {
            new Book().Show();
            return;
        }

        if (String.IsNullOrWhiteSpace(programNumber))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You don't send program number? Sorry! The problem is in you!");
            Console.ResetColor();
            return;
        }

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Enter the program number from the proposed list, not letters, not numbers not from the list!");
        Console.ResetColor();
    }
}