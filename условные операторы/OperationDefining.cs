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

      switch (a)
      {
        case "1":
          Console.WriteLine("Add");
          Console.ReadLine();
          break;
        case "2":
          Console.WriteLine("Deduct");
          Console.ReadLine();
          break;
        case "3":
          Console.WriteLine("Multiply");
          Console.ReadLine();
          break;
        default:
          Console.WriteLine("Cannot parse number");
          Console.ReadLine();
          break;
      }
    }
  }
}
