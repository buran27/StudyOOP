
namespace Study.Vector;


public class MyVector
{
  public double DirectionX {get;}
  public double DirectionY {get;}

  public MyVector(double x, double y) {DirectionX = x; DirectionY = y;}

  public override string ToString(){
    return $"({DirectionX}, {DirectionY})";
  }

  public static MyVector operator +(MyVector left, MyVector right)
  {
    ArgumentNullException.ThrowIfNull(left);
    ArgumentNullException.ThrowIfNull(right);

    return new MyVector(
      left.DirectionX + right.DirectionX,
      left.DirectionY + right.DirectionY
    );
  }

  public static MyVector operator -(MyVector left, MyVector right)
  {
    ArgumentNullException.ThrowIfNull(left);
    ArgumentNullException.ThrowIfNull(right);

    return new MyVector(
      left.DirectionX - right.DirectionX,
      left.DirectionY - right.DirectionY
    );
  }

    public static double operator *(MyVector left, MyVector right)
  {
    ArgumentNullException.ThrowIfNull(left);
    ArgumentNullException.ThrowIfNull(right);

    return left.DirectionX * right.DirectionX + left.DirectionY * right.DirectionY;
  }

    public static bool operator ==(MyVector? left, MyVector? right)
  {
    ArgumentNullException.ThrowIfNull(left);
    ArgumentNullException.ThrowIfNull(right);

    return (left.DirectionX == right.DirectionX) && (left.DirectionY == right.DirectionY);
  }

    public static bool operator !=(MyVector? left, MyVector? right)
  {
    return !(left == right);
  }

    public static double operator +(MyVector vector)
  {
    ArgumentNullException.ThrowIfNull(vector);
      
    return Math.Sqrt(Math.Pow(vector.DirectionX, 2) + Math.Pow(vector.DirectionY, 2));
  }
  
    public override bool Equals(object? obj)
  {
      if (obj is not MyVector other)
          return false;

      return DirectionX == other.DirectionX && DirectionY == other.DirectionY;
  }

    public override int GetHashCode()
  {
      return HashCode.Combine(DirectionX, DirectionY);
  }
  
};