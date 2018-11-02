using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Loops
{
  public class InfiniteWhileLoopMultiplication
  {
    public static void Run()
    {
      int i = 1;
      while (i>0)
      {
        Console.WriteLine("Enter number 1");
        string a = Console.ReadLine();

        Console.WriteLine("Enter number 2");
        string b = Console.ReadLine();

        if (Parse(a) >= 0 && Parse(a) <= 10 && Parse(b) >= 0 && Parse(b) <= 10)
        {
          int number1 = Parse(a);
          int number2 = Parse(b);

          Console.WriteLine("Multiplication result: {0}", number1 * number2);
          Console.ReadKey();
          break;
        }
        else Console.WriteLine("You have entered wrong numbers. Try again. Hint: they should be between 0 and 10");

        continue; // можно не писать
      }

    }

    public static int Parse(string a)
    {
      int number;

      if (Int32.TryParse(a, out number))
        return number;
      else return -1;
    }

  }
}
