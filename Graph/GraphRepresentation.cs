using System;
using System.Collections.Generic;

namespace Graph
{
    internal class GraphRepresentation : IGraphRepresentation
    {
        public List<List<(int to, int weight)>> AdjacencyList(int n, int k)
        {
            List<List<(int to, int weight)>> adj = new List<List<(int to, int weight)>>();
            for (int i = 0; i < n; i++)
                adj.Add(new List<(int, int)>());
            
            for (int i = 0; i < k; i++)
            {
                int u, v, w;
                u = int.Parse(Console.ReadLine()!);
                v = int.Parse(Console.ReadLine()!);
                w = int.Parse(Console.ReadLine()!);
                adj[u].Add((v, w));
                adj[v].Add((u, w));
            }
            return adj;
        }
        
        public int[,] AdjacencyMatrix(int n, int k)
        {
            int[,] mat = new int[n, n];

            for (int i = 0; i < k; i++)
            {
                int u = int.Parse(Console.ReadLine()!);
                int v = int.Parse(Console.ReadLine()!);
                int w = int.Parse(Console.ReadLine()!);
                mat[u, v] = w;
                mat[v, u] = w;
            }
            return mat;
        }
    }
}
