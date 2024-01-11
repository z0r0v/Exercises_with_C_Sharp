namespace Classes001;
class AreaPerimeter
{
    public void Run()
    {
        double area;
        double perimeter;
        double side1ConvertToDoble;
        double side2ConvertToDoble;


        Console.WriteLine("Send side1");
        string? side1 = Console.ReadLine();
        Console.WriteLine("Send side2");
        string? side2 = Console.ReadLine();

        try
        {
            side1ConvertToDoble = Convert.ToDouble(side1);
            side2ConvertToDoble = Convert.ToDouble(side2);
        }
        catch
        {
            Console.WriteLine("You entered the values incorrectly");
            return;
        }

        area = new Rectangle(side1ConvertToDoble, side2ConvertToDoble).Area;
        perimeter = new Rectangle(side1ConvertToDoble, side2ConvertToDoble).Perimeter;

        Console.Write("Area: " + area + "; ");
        Console.WriteLine("Perimeter: " + perimeter + "; ");
    }
}