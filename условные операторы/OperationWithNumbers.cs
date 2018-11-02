using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter operation number");
      Console.WriteLine("1 for Add");
      Console.WriteLine("2 for Deduct");
      Console.WriteLine("3 for Multiply");
      string a = Console.ReadLine();

      Console.WriteLine("Enter number 1");
      int b;
      if (Int32.TryParse(Console.ReadLine(), out b))
      {
        // b;
      }

      Console.WriteLine("Enter number 2");
      int c;
      if (Int32.TryParse(Console.ReadLine(), out c))
      {
        // c;
      }

      switch (a)
      {
        case "1":
          Console.WriteLine(b+c);
          Console.ReadLine();
          break;
        case "2":
          Console.WriteLine(b-c);
          Console.ReadLine();
          break;
        case "3":
          Console.WriteLine(b*c);
          Console.ReadLine();
          break;
        default:
          Console.WriteLine("Cannot parse operation");
          Console.ReadLine();
          break;
      }
    }
  }
}
