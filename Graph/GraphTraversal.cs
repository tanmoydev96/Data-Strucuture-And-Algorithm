using System;
using System.Collections.Generic;

namespace Graph
{
    public class GraphTraversal : IGraphTraversal
    {
        public void BFS(List<List<(int, int)>> adj)
        {
            Queue<int> q = new Queue<int>();
            bool[] visited = new bool[adj.Count];
            q.Enqueue(0);
            visited[0] = true;
            while(q.Count != 0)
            {     
                int u = q.Dequeue();
                Console.Write(u + "  ");
                foreach ( var (v,w) in adj[u])
                {
                    if (!visited[v])
                    {                       
                        q.Enqueue(v);
                        visited[v] = true;
                    }
                }
                Console.WriteLine();
            }
        }

        public void DFS(List<List<(int, int)>> adj, int v)
        {
            Stack<int> s = new Stack<int>();
            bool[] visited = new bool[adj.Count];

            s.Push(v);
            visited[v] = true;
            while(s.Count != 0)
            {
                int u = s.Pop();
                Console.WriteLine(u + "  ");
                foreach(var (k,w) in adj[u])
                {
                    if (!visited[k])
                    {
                        visited[k] = true;
                        s.Push(k);
                    }
                }
            }
        }


    }
}
