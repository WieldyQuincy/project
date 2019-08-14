using System;

namespace Problem2
{
  class Program
  {
    static void Main(string[] args)
    {
      double sideA;
      double sideB;
      double sideC;
      Console.WriteLine("Enter the length of each side of the triangle. Press enter after each side.");
      //Triangle a = new Triangle(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
      string inputA = Console.ReadLine();
      if (!double.TryParse(inputA, out sideA))
      {
        Console.WriteLine($"{inputA} is not a valid number. Please make sure there are no spaces or other characters in your input.");
      }
      else
      {
        string inputB = Console.ReadLine();
        if (!double.TryParse(inputB, out sideB))
        {
          Console.WriteLine($"{inputB} is not a valid number. Please make sure there are no spaces or other characters in your input.");
        }
        else
        {
          string inputC = Console.ReadLine();
          if (!double.TryParse(inputC, out sideC))
          {
            Console.WriteLine($"{inputC} is not a valid number. Please make sure there are no spaces or other characters in your input.");
          }
          else
          {
            Triangle a = new Triangle(sideA, sideB, sideC);
            Console.WriteLine("Triangle a summary:");
            PrintTriangleSummary(a);
          }
        }
      }

    }

    static void PrintTriangleSummary(Triangle a)
    {
      Console.WriteLine($"Is Valid: {a.IsValid()}");
      Console.WriteLine($"The triangle sides are: \nSide A = {a.SideA} \nSide B = {a.SideB} \nSide C = {a.SideC}");

      if (double.IsNaN(a.Area()))
      {
        Console.WriteLine("Triangle Area: Too large to display");
      }
      else
      {
        Console.WriteLine($"Triangle Area: {a.Area()}");
      }

      if (a.IsEquilateral())
      {
        Console.WriteLine($"Is Equilateral: {a.IsEquilateral()}");
        Console.WriteLine($"Is Isosceles: {a.IsIsosceles()}");
      }
      else if (a.IsIsosceles())
      {
        Console.WriteLine($"Is Equilateral: {a.IsEquilateral()}");
        Console.WriteLine($"Is Isosceles: {a.IsIsosceles()}");
      }
      else if (a.IsScalene())
      {
        Console.WriteLine($"Is Scalene: {a.IsScalene()}");
      }

      if (a.IsRightAngle() == true)
      {
        Console.WriteLine($"Constains a right angle: {a.IsRightAngle()}");
      }
      else if (a.IsAcute() == true)
      {
        Console.WriteLine($"Is acute: {a.IsAcute()}");
      }
      else if (a.IsObtuse() == true)
      {
        Console.WriteLine($"Is obtuse: {a.IsObtuse()}");
      }
    }
  }
}
