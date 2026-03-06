using System.Collections.Generic;

namespace Graph
{
    internal interface IGraphRepresentation
    {
        public List<List<(int to, int weight)>> AdjacencyList(int n, int k);
        public int[,] AdjacencyMatrix(int n, int k);
    }
}
