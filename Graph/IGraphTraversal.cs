using System.Collections.Generic;
namespace Graph   
{
    interface IGraphTraversal
    {
        public void BFS(List<List<(int, int )>> adj);
        public void DFS(List<List<(int, int)>> adj, int v);
    }
}
