// Задание 2 
// Используя Visual Studio, создайте проект по шаблону Console Application. 
// Требуется: Создать класс с именем Rectangle. 
//  Page | 3 
// В теле класса создать два поля, описывающие длины сторон double side1, side2. 
// Создать пользовательский конструктор Rectangle(double side1, double side2), в теле которого 
// поля side1 и side2 инициализируются значениями аргументов. 
// Создать два метода, вычисляющие площадь прямоугольника - double AreaCalculator() и периметр 
// прямоугольника - double PerimeterCalculator(). 
// Создать два свойства double Area и double Perimeter с одним методом доступа get.
// Написать программу, которая принимает от пользователя длины двух сторон прямоугольника и выводит 
// на экран периметр и площадь.

namespace Classes001;
class AreaPerimeter
{
    public void Run()
    {
        string? side1;
        string? side2;
        double side1ConvertToDoble;
        double side2ConvertToDoble;
        double area;
        double perimeter;
        bool dataIsEmpty;

        Console.WriteLine("Send side1");
        side1 = Console.ReadLine();
        Console.WriteLine("Send side2");
        side2 = Console.ReadLine();

        dataIsEmpty = String.IsNullOrWhiteSpace(side1) || String.IsNullOrWhiteSpace(side2);

        if (!dataIsEmpty)
        {
            side1ConvertToDoble = Convert.ToDouble(side1);
            side2ConvertToDoble = Convert.ToDouble(side2);

            area = new Rectangle(side1ConvertToDoble, side2ConvertToDoble).Area;
            perimeter = new Rectangle(side1ConvertToDoble, side2ConvertToDoble).Perimeter;

            Console.Write("Area: " + area);
            Console.Write("; ");
            Console.WriteLine("Perimeter: " + perimeter);
            Console.Write("; ");
            return;
        }

        if (dataIsEmpty)
        {
            Console.WriteLine("You are not send side1 or side2");
            return;
        }
    }
}