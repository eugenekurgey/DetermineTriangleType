using DetermineTriangleType;

namespace UnitTests;

public class Tests
{
    [Test]
    public void Test_RightTriangle()
    {
        var result = Program.DetermineTriangleType(3, 4, 5);
        Assert.AreEqual(result, TriangleType.Right);
    }
    
    [Test]
    public void Test_AcuteTriangle()
    {
        var result = Program.DetermineTriangleType(3, 3, 4);
        Assert.AreEqual(result, TriangleType.Acute);
    }
    
    [Test]
    public void Test_ObtuseTriangle()
    {
        var result = Program.DetermineTriangleType(3, 4, 6);
        Assert.AreEqual(result, TriangleType.Obtuse);
    }
    
    [Test]
    public void Test_TriangleNotExist()
    {
        var result = Program.DetermineTriangleType(14, 22, 1);
        Assert.AreEqual(result, TriangleType.NotExist);
    }
}