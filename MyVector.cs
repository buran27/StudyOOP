
namespace Study.Vector;

public class MyVector
{
  public double DirectionX {get;}
  public double DirectionY {get;}

  public MyVector(double X, double Y) {DirectionX = X; DirectionY = Y;}

  public override string ToString(){
    return $"({DirectionX}, {DirectionY})";
  }

  public static MyVector operator +(MyVector left, MyVector right)
  {
    if(left is null || right is null)
      throw new ArgumentNullException();

    return new MyVector(
      left.DirectionX + right.DirectionX,
      left.DirectionY + right.DirectionY
    );
  }

  public static MyVector operator -(MyVector left, MyVector right)
  {
    if(left is null || right is null)
      throw new ArgumentNullException();

    return new MyVector(
      left.DirectionX - right.DirectionX,
      left.DirectionY - right.DirectionY
    );
  }

    public static MyVector operator *(MyVector left, MyVector right)
  {
    if(left is null || right is null)
      throw new ArgumentNullException();

    return new MyVector(
      left.DirectionX * right.DirectionX,
      left.DirectionY * right.DirectionY
    );
  }

    public bool operator ==(MyVector left, MyVector right)
  {
    if(left is null || right is null)
      return false;

    return (left.DirectionX == right.DirectionX) && (left.DirectionY == right.DirectionY);
  }

    public bool operator !=(MyVector left, MyVector right)
  {
    return !(left == right);
  }

    public static MyVector operator +(MyVector vector)
  {
    if (vector is null)
      throw new ArgumentNullException();
    return vector;
  }

    public static MyVector operator -(MyVector vector)
  {
    if (vector is null)
      throw new ArgumentNullException();
      
    return new MyVector(
      -vector.DirectionX,
      -vector.DirectionY
    );
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