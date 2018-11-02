using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
  class Program
  {
    static void Main(string[] args)
    {
      int a;
      int b;

      Console.WriteLine("Enter number 1");

      if (Int32.TryParse(Console.ReadLine(), out a))
      {
       // a;
      }
      Console.WriteLine("Enter number 2");

      if (Int32.TryParse(Console.ReadLine(), out b))
      {
       // b;
      }

      if (a - b == 0)
      {
        Console.WriteLine("Numbers are equal {0}, {1}", a, b);
        Console.ReadKey();
      }

      else if (a - b > 0)
      {
        int c = a - b;
        Console.WriteLine("Number 1 is greater than number 2 by {2}: {0}, {1}", a, b, c);
        Console.ReadKey();
      }

      else if (a - b < 0)
      {
        int c = b - a;
        Console.WriteLine("Number 2 is greater than number 2 by {2}: {0}, {1}", a, b, c);
        Console.ReadKey();
      }
    }
  }
}
