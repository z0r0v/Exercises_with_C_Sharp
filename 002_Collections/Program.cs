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
        Citizen Citizen = new Citizen();
        Citizen.SetCitizen("1P1", Citizen.CitizenType.Pensioner);
        Citizen.SetCitizen("1S1", Citizen.CitizenType.Student);
        Citizen.SetCitizen("1W1", Citizen.CitizenType.Worker);
        Citizen.SetCitizen("2P2", Citizen.CitizenType.Pensioner);
        Citizen.SetCitizen("1P1", Citizen.CitizenType.Pensioner);
        Citizen.SetCitizen("1W1", Citizen.CitizenType.Worker);

        List<Citizen> citizens = Citizen.Citizens;
        Console.WriteLine("");
        Console.WriteLine("Citizens:");
        citizens.ForEach(citizen =>
        {
            Console.WriteLine("IndexNumber: " + citizen.IndexNumber);
            Console.WriteLine("Type: " + citizen.Type);
            Console.WriteLine("PasportNumber: " + citizen.PasportNumber);
        });
    }
}
