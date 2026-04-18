using Xunit;
using Study.Vector;
namespace LAB1.Tests;

public class UnitTest1
{
    [Fact]
    public void Constructor_SetsCoordinatesCorrectly()
    {
        MyVector vector = new MyVector(3, 4);

        Assert.Equal(3, vector.DirectionX);
        Assert.Equal(4, vector.DirectionY);
    }

    [Fact]
    public void AddsCoordinatesCorrectly()
    {
        MyVector left = new MyVector(1, -2);
        MyVector right = new MyVector(3, 4);

        var result = left + right;

        Assert.Equal(4, result.DirectionX);
        Assert.Equal(2, result.DirectionY);
    }

    [Fact]
    public void SubtracksCoordinatesCorrectly()
    {
        MyVector left = new MyVector(1, -2);
        MyVector right = new MyVector(3, 4);

        var result = left - right;

        Assert.Equal(-2, result.DirectionX);
        Assert.Equal(-6, result.DirectionY);
    }

    [Fact]
    public void MultiplyCoordinatesCorrectly()
    {
        MyVector left = new MyVector(1, -2);
        MyVector right = new MyVector(3, 4);

        var result = left * right;

        Assert.Equal(3, result.DirectionX);
        Assert.Equal(-8, result.DirectionY);
    }
}
