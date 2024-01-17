using System.Runtime.ExceptionServices;

namespace _002_Collections;

class Program
{
    static void Main()
    {
        // Task2
        // List<Months> months = new Months().GetMonthsByTheNumberOfDays(31);
        // months.ForEach(month => Console.WriteLine(month.Name + " " + month.Days));
        // Console.WriteLine(new Months().GetTheMonthBySerialNumber(3).IndexNumber);
        // Task3
        Citizens Citizens = new();
        Citizens.SetCitizen(new Pensioner("1P1"));
        Citizens.SetCitizen(new Worker("2W2"));
        Citizens.SetCitizen(new Pensioner("2P2"));
        Citizens.SetCitizen(new Student("2S2"));
        Citizens.CitizensList.ForEach(citizen =>
        {
            Console.WriteLine("Type: " + citizen.Type);
            Console.WriteLine("PasportNumber: " + citizen.PasportNumber);
            Console.WriteLine("");
        });
    }
}
