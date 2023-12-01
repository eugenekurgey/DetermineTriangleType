namespace DetermineTriangleType;

public class Triangle
{
    public double SideA { get; set; }
    public double SideB { get; set; }
    public double MaxSide { get; set; }

    public Triangle(double a, double b, double c)
    {
        InitializeSides(a, b, c);
    }

    private void InitializeSides(double a, double b, double c)
    {
        SideA = a;
        SideB = b;
        MaxSide = c;
        double temp;

        if (SideA > MaxSide)
        {
            temp = MaxSide;
            MaxSide = SideA;
            SideA = temp;
        }

        if (SideB > MaxSide)
        {
            temp = MaxSide;
            MaxSide = SideB;
            SideB = temp;
        }
    }

    public TriangleType DetermineTriangleType()
    {
        if (!IfTriangleExist()) return TriangleType.NotExist;
        
        var maxSideSqw = Math.Pow(MaxSide, 2);
        var sumOtherSidesSqw = Math.Pow(SideA, 2) + Math.Pow(SideB, 2);

        if (maxSideSqw == sumOtherSidesSqw) return TriangleType.Right;
        if (maxSideSqw > sumOtherSidesSqw) return TriangleType.Obtuse;
        return TriangleType.Acute;
    }

    private bool IfTriangleExist() => SideA + SideB > MaxSide;
}

public enum TriangleType
{
    NotExist,
    Right,
    Acute,
    Obtuse
}