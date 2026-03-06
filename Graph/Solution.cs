using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class Solution
    {
        public static void BFS(int[][] image, int sr, int sc, int color, bool[,] visited)
        {
            int n = image.Length;
            int m = image[sr].Length;

            Queue<(int, int)> q = new Queue<(int, int)>();
            visited[sr,sc] = true;
            image[sr][sc] = color;
            q.Enqueue((sr, sc));

            //Up, Down, Left, Right
            int[] dRow = new int[] { -1, 1, 0, 0 };
            int[] dCol = new int[] { 0, 0, -1, 1 };

            while (q.Count != 0)
            {
                (int a, int b) currentNode = q.Dequeue();
                for (int i = 0; i < 4; i++)
                {
                    int nRow = currentNode.a + dRow[i];
                    int nCol = currentNode.b + dCol[i];
                    if (nRow >= 0 && nRow < n && nCol >= 0 && nCol < m && !visited[nRow,nCol] && image[nRow][nCol] != 0)
                    {
                        visited[nRow,nCol] = true;
                        image[nRow][nCol] = color;
                        q.Enqueue((nRow, nCol));
                    }
                }
            }
        }
        public int[][] FloodFill(int[][] image, int sr, int sc, int color)
        {
            int n = image.Length;
            int m = image[sr].Length;
            bool[,] visited = new bool[n,m];

            BFS(image, sr, sc, color, visited);
            return image;
        }
    }
}
