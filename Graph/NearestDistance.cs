using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class Pair_N
    {
        public int rowId;
        public int colId;
        public int distance;
        public Pair_N() { }
        public Pair_N(int rId, int cId, int d) { rowId = rId; colId = cId; distance = d; }
    }
    class Solution
    {
        public void Bfs(int[,] grid, bool[,] visited, List<List<int>> result, Queue<Pair_N> pair)
        {
            int rLength = grid.GetLength(0);
            int cLength = grid.GetLength(1);

            while (pair.Count != 0)
            {
                Pair_N currentNode = pair.Dequeue();

                int[] dRow = { -1, 1, 0, 0 };
                int[] dCol = { 0, 0, -1, 1 };

                for (int i = 0; i < 4; i++)
                {
                    int newRow = currentNode.rowId + dRow[i];
                    int newCol = currentNode.colId + dCol[i];
                    int d = currentNode.distance;

                    if (newRow >= 0 && newRow < rLength && newCol >= 0 && newCol < cLength &&
                    !visited[newRow, newCol] && grid[newRow, newCol] == 0)
                    {
                        visited[newRow, newCol] = true;
                        pair.Enqueue(new Pair_N(newRow, newCol, d + 1));
                        result[newRow][newCol] = d+1;
                    }
                }
            }
        }
        public List<List<int>> nearest(int[,] grid)
        {
            // code here
            int rowLength = grid.GetLength(0);
            int colLength = grid.GetLength(1);

            List<List<int>> result = new List<List<int>>();
            for (int i = 0; i < rowLength; i++)
            {
                result.Add(new List<int>(new int[colLength]));
            }

            bool[,] visited = new bool[rowLength, colLength];
            Queue<Pair_N> q = new Queue<Pair_N>();

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    if (grid[i, j] == 1)
                    {
                        q.Enqueue(new Pair_N(i, j, 0));
                    }
                }
            }
            Bfs(grid, visited, result, q);
            return result;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            NearestDistance n = new NearestDistance();

            int[,] grid = new int[,]
            {
               {0, 1, 0},
               {1, 1, 0},
               {1, 0, 0 }
            };
            n.nearest(grid);


        }
    }
}
