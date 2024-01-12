namespace Classes001;

class Point(string name, int cordinateX, int cordinateY)
{
    private int _cordinateX = cordinateX;
    private int _cordinateY = cordinateY;

    private string _name = name;

    public int X
    {
        get => _cordinateX;
    }
    public int Y
    {
        get => _cordinateY;
    }
    public string Name
    {
        get => _name;
    }
}