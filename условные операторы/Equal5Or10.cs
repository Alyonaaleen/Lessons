using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
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

      if (a == 5 || a == 10)
      {
        Console.WriteLine("This number is equal either 5 or 10");
        Console.ReadLine();
      }

      else
      {
        Console.WriteLine("Unknown number");
        Console.ReadLine();
      }
    }

  }
}
