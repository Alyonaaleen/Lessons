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
          int i = 0;
          while (i < months)
          {
            deposit += deposit * (decimal)0.07;
            i++;
          }

          Console.WriteLine("Your total money: {0}", deposit);
          Console.WriteLine($"После {months} месяцев сумма вклада составит {deposit}");

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
