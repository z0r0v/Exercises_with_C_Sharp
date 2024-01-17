namespace _002_Collections;
class Citizen()
{
    public string PasportNumber { get; set; } = string.Empty;
    public CitizenType Type { get; set; } = default;
    public enum CitizenType
    {
        Pensioner = 1,
        Worker = 2,
        Student = 3,
    }
}