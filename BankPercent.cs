using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter your deposit");

      decimal deposit;

      if (decimal.TryParse(Console.ReadLine(), out deposit))
      {
        Console.WriteLine("Enter the number of months");

        int months;

        if (Int32.TryParse(Console.ReadLine(), out months))
        {
          for (int i = 0; i < months; i++)
          {
            deposit += deposit * (decimal)0.07;
          }

          Console.WriteLine("Your total money: {0}", deposit);
          Console.ReadKey();
        }
        else Console.WriteLine("InvalidInput");
        Console.ReadKey();
      }
      else Console.WriteLine("InvalidInput");
      Console.ReadKey();
    }
  }
}
