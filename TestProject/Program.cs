using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Loops;

namespace TestProject
{
  class Program
  {
    static void Main(string[] args)
    {
      // Sorting arrays methods comparison
      #region ArraySorting
      /*
      int[] array = { 3, 5, 7, 1, 4, 89, 22, 7, 9, 2,-1, -4, 100, 45, 76, 2, 8, 346, -100, 24, 67, 34, 7, 4, 10, 21, 12, -40, 0, 1, 6, 17, 18};
      int swaps = 0;
      int repeats = 0;

      foreach( int a in Sorting.BubbleSort(array, out swaps, out repeats)) //Change MySort to BubbleSort
      {
        Console.WriteLine(a);
      }
      Console.WriteLine("swaps: {0}, repeats: {1}", swaps, repeats);
      Console.ReadKey();
      */
      #endregion

      // Escaping from a Maze
      #region MazePrint
      /*
      char[,] maze =       {{'#','.','#','#','#','#','#','#','#','#'},
                            {'#','.','.','#','.','#','.','.','#','#'},
                            {'#','.','.','#','.','#','.','#','.','.'},
                            {'#','.','.','.','.','#','.','#','.','#'},
                            {'#','#','#','.','#','.','.','#','.','#'},
                            {'#','.','#','.','.','.','.','#','.','#'},
                            {'#','.','.','.','.','#','#','#','.','#'},
                            {'#','#','.','#','#','#','.','.','.','#'},
                            {'#','.','.','.','.','.','.','#','.','#'},
                            {'#','#','#','#','#','#','#','#','#','#'}};

      for (int y = 0; y<maze.GetLength(0); y++)
      {
        for (int x = 0; x < maze.GetLength(1); x++)
        {
          Console.Write(maze[y, x]);
        }
        Console.WriteLine();
      }
      Console.ReadLine();
       */
      #endregion

      #region MazeEscape

      char[,] maze =       {{'#','.','#','#','#','#','#','#','#','#'},
                            {'#','.','.','#','.','#','.','.','#','#'},
                            {'#','.','.','#','.','#','.','#','.','.'},
                            {'#','.','.','.','.','#','.','#','.','#'},
                            {'#','#','#','.','#','.','.','#','.','#'},
                            {'#','.','#','.','.','.','.','#','.','#'},
                            {'#','.','.','.','.','#','#','#','.','#'},
                            {'#','#','.','#','#','#','.','.','.','#'},
                            {'#','.','.','.','.','.','.','#','.','#'},
                            {'#','#','#','#','#','#','#','#','#','#'}};

      #endregion
    }
  }
}
