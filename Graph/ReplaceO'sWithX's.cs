using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class Pair
    {
        public int first;
        public int second;
        public Pair() { }
        public Pair(int f, int s) { first = f; second = s; }
    }
    class Test
    {
         public void Bfs(char[,] grid, bool[,] visited, Pair p)
         {
             int row = grid.GetLength(0);
             int col = grid.GetLength(1);
             Queue<Pair> q = new Queue<Pair>();
             q.Enqueue(p);

             int[] dRow = { -1, 1, 0, 0 };
             int[] dCol = { 0, 0, -1, 1 };
             while (q.Count != 0)
             {
                 Pair currentNode = q.Dequeue();
                 for (int i = 0; i < 4; i++)
                 {
                     int newRow = currentNode.first + dRow[i];
                     int newCol = currentNode.second + dCol[i];

                     if (newRow > 0 && newRow < row && newCol > 0 && newCol < col && 
                        !visited[newRow, newCol] && grid[newRow, newCol] == 'O')
                     {
                         grid[newRow, newCol] = 'S';
                         visited[newRow, newCol] = true;
                         q.Enqueue(new Pair(newRow, newCol));
                     }
                 }
             }
         }

         public bool IsBoundaryNode(int i, int j, int rowCount, int colCount)
         {
             return (i == 0 || i == rowCount - 1 || j == 0 || j == rowCount - 1);
         }

         public void fill(char[,] grid)
         {
             // Code here
             int row = grid.GetLength(0);
             int col = grid.GetLength(1);

             bool[,] visited = new bool[row, col];

             for (int i = 0; i < row; i++)
             {
                 for (int j = 0; j < col; j++)
                 {
                     if (grid[i, j] == 'O' && IsBoundaryNode(i, j, row, col))
                     {
                         Bfs(grid, visited, new Pair(i, j));
                     }
                 }
             }

             for (int i = 0; i < row; i++)
             {
                 for (int j = 0; j < col; j++)
                 {
                     if (grid[i, j] == 'S')
                     {
                         grid[i, j] = 'O';
                     }
                     else if (grid[i, j] == 'O')
                     {
                         grid[i, j] = 'X';
                     }
                 }
             }
         }
    }
    public  class ReplaceO_sWithX_s
    {
        public static void Main()
        {
            char[,] grid = new char[,]
            {
                {'X','X', 'X', 'X'},
                {'X','O', 'X', 'X'},
                {'X','O', 'O', 'X'},
                {'X','O', 'X', 'X'},
                {'X','X','O','O'}
            };

            Test t = new Test();
            t.fill(grid);
        }
    }
}
