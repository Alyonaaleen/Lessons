using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
  class Program
  {
    static void Main(string[] args)
    {
      int a;

      Console.WriteLine("Enter a number");

      if (Int32.TryParse(Console.ReadLine(), out a))
      {
        // a;
      }

      if (a > 5) // && (a < 10)
      {
        if (a < 10)
        {
          Console.WriteLine("This number is greater than 5 and less than 10");
          Console.ReadLine();
        }

        else
        {
          Console.WriteLine("Unknown number");
          Console.ReadLine();
        }
      }

      else
      {
        Console.WriteLine("Unknown number");
        Console.ReadLine();
      }
    }
  }
}
