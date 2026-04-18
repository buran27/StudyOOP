using Study.Vector;
namespace Study.Program;



public static class Program
{
    public static void Main()
    {
      MyVector vec = new MyVector(12, 45);
      MyVector vec1 = new MyVector(5, -20);

      Console.WriteLine(vec);
      Console.WriteLine(vec1);

      MyVector vec3 = vec + vec1;
      Console.WriteLine(vec3);

      vec3 = vec - vec1;
      Console.WriteLine(vec3);

      vec3 = vec * vec1;
      Console.WriteLine(vec3);

      Console.WriteLine(vec == vec1);

      Console.WriteLine(vec != vec1);

      vec = -vec;
      Console.WriteLine(vec);

      vec1 = -vec1;
      Console.WriteLine(vec1);
    }
}

