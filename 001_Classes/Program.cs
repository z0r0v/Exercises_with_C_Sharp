namespace Classes001;

class Program
{
    static void Main()
    {
        Console.WriteLine("Send program number from the list provided");
        Console.WriteLine("AreaPerimeter: 1");
        Console.WriteLine("Book: 2");
        Console.WriteLine("Figure: 3");
        Console.WriteLine("Address: 4");
        string programNumber = Console.ReadLine() ?? "deffault falue";

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


        if (programNumber == "3")
        {
            Point point1 = new("point1", 2, 4);
            Point point2 = new("point2", 4, 8);
            Point point3 = new("point3", 8, 16);
            Point point4 = new("point4", 16, 32);
            Point point5 = new("point5", 32, 64);

            new Figure(point1, point2, point3, point4, point5).PerimeterCalculator();
            return;
        }

        if (programNumber == "4")
        {
            Address address = new();

            address.Index = "220115";
            address.City = "Minsk";
            address.Street = "str Kizhevatov";
            address.House = "80";
            address.Apartment = "78";

            Console.Write(address.Index +
            " " + address.City +
            " " + address.Street +
            " " + address.House +
            " " + address.Apartment);
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