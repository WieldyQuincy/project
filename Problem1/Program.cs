using System;

namespace Problem1
{
  class Program
  {
    static void Main(string[] args)
    {

      decimal l;
      decimal w;
      decimal h;

      Console.WriteLine("Enter the box length and press enter:");
      if (!decimal.TryParse(Console.ReadLine(), out l))
      {
        Console.WriteLine("Invalid input, please make sure there are no spaces or other characters in your input.");
      }
      else
      {
        Console.WriteLine("Enter the box width and press enter:");
        if (!decimal.TryParse(Console.ReadLine(), out w))
        {
          Console.WriteLine("Invalid input, please make sure there are no spaces or other characters in your input.");
        }
        else
        {
          Console.WriteLine("Enter the box hidth and press enter:");
          if (!decimal.TryParse(Console.ReadLine(), out h))
          {
            Console.WriteLine("Invalid input, please make sure there are no spaces or other characters in your input.");
          }
          else
          {
            Box a = new Box(l, w, h);
            Console.WriteLine($"The difference is: {a.VolumeDiff()}");
          }
        }
      }




    }
  }
}
