namespace Classes001;

class Figure
{
    private readonly Point _A;
    private readonly Point _B;
    private readonly Point _C;
    private readonly Point _D;
    private readonly Point _E;
    public string Name { get; set; } = string.Empty;
    public double Perimeter { get; set; } = 0;
    public Figure(Point A, Point B)
    {
        _A = A;
        _B = B;
        PerimeterCalculator();
    }

    public Figure(Point A, Point B, Point C) : this(A, B)
    {
        _C = C;
        PerimeterCalculator();
    }

    public Figure(Point A, Point B, Point C, Point D) : this(A, B, C)
    {
        _D = D;
        PerimeterCalculator();
    }

    public Figure(Point A, Point B, Point C, Point D, Point E) : this(A, B, C, D)
    {
        _E = E;
        PerimeterCalculator();
    }

    private double LengthSide(Point A, Point B)
    {
        return Math.Sqrt((A.X - B.X) * (A.X - B.X)
                            + (A.Y - B.Y) * (A.Y - B.Y));
    }
    private void PerimeterCalculator()
    {
        Name = _A.Name + "-" + _B.Name + "-";
        double lengthSide1 = LengthSide(_A, _B);
        double lengthSide2 = 0;
        double lengthSide3 = 0;
        double lengthSide4 = 0;
        double lengthSide5 = 0;

        if (_C != null)
        {
            lengthSide2 = LengthSide(_C, _A);
            lengthSide3 = LengthSide(_B, _C);
            Name += _C.Name + "-"; ;
        }

        if (_D != null)
        {
            lengthSide4 = LengthSide(_D, _C!);
            Name += _D.Name + "-";
        }

        if (_E != null)
        {
            lengthSide5 = LengthSide(_E, _D!);
            Name += _E.Name;
        }

        Perimeter = lengthSide1 + lengthSide2 + lengthSide3 + lengthSide4 + lengthSide5;
    }
}