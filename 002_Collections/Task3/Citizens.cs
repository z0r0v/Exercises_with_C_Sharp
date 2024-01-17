namespace _002_Collections;

class Citizens
{
    public List<Citizen> CitizensList = new() { };
    private List<Citizen> CitizensListPensioner = new() { };
    private List<Citizen> CitizensListStudent = new() { };
    private List<Citizen> CitizensListWorker = new() { };

    private void AddCitizenToList(Citizen Citizen)
    {
        if (Citizen.Type == Citizen.CitizenType.Pensioner)
            CitizensListPensioner.Add(Citizen);

        if (Citizen.Type == Citizen.CitizenType.Student)
            CitizensListStudent.Add(Citizen);

        if (Citizen.Type == Citizen.CitizenType.Worker)
            CitizensListWorker.Add(Citizen);

        CitizensList = CitizensListPensioner;
        CitizensList = CitizensList.Concat(CitizensListWorker).ToList();
        CitizensList = CitizensList.Concat(CitizensListStudent).ToList();
    }
    public void SetCitizen(Citizen Citizen)
    {
        if (CitizensList.Any(citizen => citizen.PasportNumber == Citizen.PasportNumber))
        {
            Console.WriteLine("Pasport Number: " + Citizen.PasportNumber + " " + "Have in list and not added");
            return;
        }

        AddCitizenToList(Citizen);

        if (Citizen.Type == Citizen.CitizenType.Pensioner)
            Console.WriteLine("Pensioner number in list" + " " + CitizensList.IndexOf(Citizen));
    }
}