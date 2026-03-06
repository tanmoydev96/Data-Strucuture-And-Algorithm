using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public static class DetectCycle
    {

        public static bool bfs(List<List<int>> adjMat, bool[] visited, int element)
        {
            Queue<(int, int)> q = new Queue<(int, int)>();

            q.Enqueue((element, -1));
            visited[element] = true;
            while (q.Count != 0)
            {
                (int a, int b) currentNode = q.Dequeue();
                int node = currentNode.a;
                int parent = currentNode.b;
                foreach (int neighbors in adjMat[node])
                {
                    if (!visited[neighbors])
                    {
                        q.Enqueue((neighbors, node));
                        visited[neighbors] = true;
                    }
                    else if (neighbors != parent)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool isCycle(int V, int[,] edges)
        {
            // Code here
            List<List<int>> adjMat = new List<List<int>>();
            bool[] visited = new bool[V];

            for (int i = 0; i < V; i++)
            {
                adjMat.Add(new List<int>());
            }

            for (int i = 0; i < edges.GetLength(0); i++)
            {
                adjMat[edges[i, 0]].Add(edges[i, 1]);
                adjMat[edges[i, 1]].Add(edges[i, 0]);
            }

            for (int i = 0; i < visited.Length; i++)
                if (!visited[i])
                {
                    if (bfs(adjMat, visited, i)) return true;
                }

            return false;
        }
        public static void Main(string[] args)
        {
            int V = 4;
            int[,] edges = new int[,]
                {
                    { 1 ,2 },
                    {2, 3 }
                };
            isCycle(V, edges);
        }
    }
}


        

