using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Loops
{
  class Sorting
  {
    int[] array = {3,5,7,1,4,89,22,7,9,2};

    public static int[] BubbleSort(int[] arr, out int swaps, out int repeats)
    {
      int[] b = arr;
      repeats = 0;
      swaps = 0;

      for (int j = 0; j < b.Length-1; j++)
      {
        for (int i = 0; i < b.Length-j-1; i++)
        {
          repeats++;

          if (b[i] > b[i + 1])
          {
            int c = b[i];
            b[i] = b[i + 1];
            b[i + 1] = c;
            swaps++;
          }
        }

      }
      // сравниваем число 1 и 2
      // если число 2 меньше 1, свапаем местами
      // свапаем дальше пока самое большое число не окажется в конце
      // повторяем сначала
      return b;
    }

    public static int[] MySort(int[] arr, out int swaps, out int repeats)
    {
      int[] b = arr;
      swaps = 0;
      repeats = 0;

      for (int j = 0; j < 1; j++)
      {
        for (int i = 0; i < b.Length - 1; i++)
        {
          repeats++;

          if (b[i] > b[i + 1])
          {
            int c = b[i];
            b[i] = b[i + 1];
            b[i + 1] = c;
            j--;
            swaps++;
            break;
          }
        }

      }
      // сравниваем число 1 и 2
      // если число 2 меньше 1, свапаем местами
      // если свапали числа, начинаем проверку с самого начала
      // повторяем
      return b;
    }
  }
}
// третий метод сортировки: если свапнулди, сравниваем два предыдущих, если нет, идём дальше, можно попробовать рекурсию