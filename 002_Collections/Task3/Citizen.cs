namespace _002_Collections;
class Citizen : IComparable<Citizen>
{
    public int IndexNumber { get; set; } = 0;
    public string PasportNumber { get; set; } = string.Empty;
    public CitizenType Type { get; set; } = CitizenType.Pensioner;
    public List<Citizen> Citizens = new List<Citizen> { };
    public enum CitizenType
    {
        Pensioner = 1,
        Worker = 2,
        Student = 3,
    }

    public int SortByNameAscending(string name1, string name2) =>
        name1?.CompareTo(name2) ?? 1;
    public int CompareTo(Citizen compare) =>
        compare == null ? 1 : Type.CompareTo(compare.Type);
    private void VritePensionerNumberInLIst(Citizen Citizen, CitizenType Type)
    {
        if (Type == CitizenType.Pensioner)
            Console.WriteLine("Pensioner number in list" + " " + Citizens.IndexOf(Citizen));
    }
    private void AddItemAndSortCitizens(Citizen Citizen)
    {
        Citizens.Add(Citizen);
        Citizens.Sort();
    }
    public void SetCitizen(string PasportNumber, CitizenType Type)
    {
        Citizen Citizen = new()
        {
            IndexNumber = Citizens.Count() + 1,
            PasportNumber = PasportNumber,
            Type = Type
        };

        if (Citizens.Any(c => c.PasportNumber == PasportNumber))
        {
            Console.WriteLine("Pasport Number: " + PasportNumber + " " + "Have in list and not added");
            return;
        }

        AddItemAndSortCitizens(Citizen);
        VritePensionerNumberInLIst(Citizen, Type);
    }
}