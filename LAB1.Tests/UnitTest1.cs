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

        Assert.Equal(-5, result);
    }

    [Fact]
    public void UnaryPlus()
    {
        var vector = new MyVector(2, -3);

        var result = +vector;

        Assert.Equal(Math.Sqrt(2 * 2 + 3 * 3), result);
    }

    [Fact]
    public void EqualityOperator()
    {
        var first = new MyVector(1, 2);
        var second = new MyVector(1, 2);

        var result = first == second;

        Assert.True(result);
    }

    [Fact]
    public void InequalityOperator()
    {
        var first = new MyVector(1, 2);
        var second = new MyVector(1, 3);

        var result = first != second;

        Assert.True(result);
    }

    [Fact]
    public void Equals_ForEqualVectors()
    {
        var first = new MyVector(1, 2);
        var second = new MyVector(1, 2);

        var result = first.Equals(second);

        Assert.True(result);
    }

    [Fact]
    public void GetHashCode_ForEqualVectors()
    {
        var first = new MyVector(1, 2);
        var second = new MyVector(1, 2);

        Assert.Equal(first.GetHashCode(), second.GetHashCode());
    }

    [Fact]
    public void ToString_CorrectFormat()
    {
        var vector = new MyVector(1, 2);

        var result = vector.ToString();

        Assert.Equal("(1, 2)", result);
    } 
}
