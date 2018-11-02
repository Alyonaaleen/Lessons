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

      Console.WriteLine("Enter your deposit amount (0-1000)");

      if (Int32.TryParse(Console.ReadLine(), out a))
      {
        // a;
      }

      if (a<100)
      {
        Console.WriteLine("You will receive {0}", a*1.05+15); //a += a*0.05, writeline in the very end
        Console.ReadLine();
      }

      else if (a >= 100 && a<=200)
      {
        Console.WriteLine("You will receive {0}", a * 1.07+15);
        Console.ReadLine();
      }

      else if (a >200)
      {
        Console.WriteLine("You will receive {0}", a * 1.1+15);
        Console.ReadLine();
      }
    }

  }
}
