namespace DetermineTriangleType;

public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input side 1 of triangle: ");
        var a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input side 2 of triangle: ");
        var b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input side 3 of triangle: ");
        var c = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(DetermineTriangleType(a, b, c));

        Console.ReadKey();
    }

    public static TriangleType DetermineTriangleType(double a, double b, double c)
    {
        var triangle = new Triangle(a, b, c);
        return triangle.DetermineTriangleType();
    }
}