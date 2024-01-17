namespace _002_Collections;

class Worker : Citizen
{
    public Worker(string _pasportNumber)
    {
        PasportNumber = _pasportNumber;
        Type = CitizenType.Worker;
    }
}