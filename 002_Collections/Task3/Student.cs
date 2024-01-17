namespace _002_Collections;

class Student : Citizen
{
    public Student(string _pasportNumber)
    {
        PasportNumber = _pasportNumber;
        Type = CitizenType.Student;
    }
}