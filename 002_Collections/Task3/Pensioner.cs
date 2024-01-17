namespace _002_Collections;

class Pensioner : Citizen
{
    public Pensioner(string _pasportNumber)
    {
        PasportNumber = _pasportNumber;
        Type = CitizenType.Pensioner;
    }
}