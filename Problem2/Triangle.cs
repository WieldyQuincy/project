using System;

namespace Problem2
{
  class Triangle
  {
    public Triangle(double sideA, double sideB, double sideC)
    {
      this.SideA = sideA;
      this.SideB = sideB;
      this.SideC = sideC;
    }

    public double SideA { get; private set; }
    public double SideB { get; private set; }
    public double SideC { get; private set; }

    public double Area()
    {
      double s = ((double)SideA + (double)SideB + (double)SideC) / 2;
      double a = s * (s - SideA) * (s - SideB) * (s - SideC);
      double area = Math.Sqrt(a);

      //   Console.WriteLine(double.IsNaN(area));

      return Math.Round(area, 4);

    }
    public bool IsEquilateral()
    {
      if (SideA == SideB && SideA == SideC)
      {
        return true;
      }

      return false;
    }

    public bool IsIsosceles()
    {
      if (SideA == SideB || SideA == SideC || SideB == SideC)
      {
        return true;
      }

      return false;
    }

    public bool IsScalene()
    {
      if (SideA != SideB && SideA != SideC && SideB != SideC)
      {
        return true;
      }

      return false;
    }

    public bool IsValid()
    {
      if (SideA > 0 && SideB > 0 && SideC > 0)
      {
        return true;
      }

      return false;
    }

    public bool IsRightAngle()
    {
      if (SideA > SideB && SideA > SideC)
      {
        double bigSide = SideA * SideA;
        double smallSide = Math.Pow(SideB, 2) + Math.Pow(SideC, 2);

        if (bigSide == smallSide)
        {
          return true;
        }
      }
      else if (SideB > SideA && SideB > SideC)
      {
        double bigSide = SideB * SideB;
        double smallSide = Math.Pow(SideA, 2) + Math.Pow(SideC, 2);

        if (bigSide == smallSide)
        {
          return true;
        }
      }
      else if (SideC > SideA && SideC > SideB)
      {
        double bigSide = SideC * SideC;
        double smallSide = Math.Pow(SideB, 2) + Math.Pow(SideA, 2);

        if (bigSide == smallSide)
        {
          return true;
        }
      }
      return false;
    }

    public bool IsAcute()
    {
      if (SideA > SideB && SideA > SideC)
      {
        double bigSide = SideA * SideA;
        double smallSide = Math.Pow(SideB, 2) + Math.Pow(SideC, 2);

        if (bigSide < smallSide)
        {
          return true;
        }
      }
      else if (SideB > SideA && SideB > SideC)
      {
        double bigSide = SideB * SideB;
        double smallSide = Math.Pow(SideA, 2) + Math.Pow(SideC, 2);

        if (bigSide < smallSide)
        {
          return true;
        }
      }
      else if (SideC > SideA && SideC > SideB)
      {
        double bigSide = SideC * SideC;
        double smallSide = Math.Pow(SideB, 2) + Math.Pow(SideA, 2);

        if (bigSide < smallSide)
        {
          return true;
        }
      }
      return false;
    }

    public bool IsObtuse()
    {
      if (!IsAcute() && !IsRightAngle())
      {
        return true;
      }
      return false;
    }
  }
}