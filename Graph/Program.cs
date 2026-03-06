using Graph;
using System;
using System.Collections.Generic;
class Program
{
    public static void Main(string[] args)
    {
        //// First Step, Take input from 
        //Console.WriteLine("Enter the Number of Nodes :");
        //int n = int.Parse(Console.ReadLine()!);
        //Console.WriteLine("Enter the Number of Edges :");
        //int k = int.Parse(Console.ReadLine()!);

        ////Second Step, Convert into Graph Representation
        //IGraphRepresentation grphRepresent = new GraphRepresentation();
        ////grphRepresent.AdjacencyMatrix(n, k);

        //List<List<(int to, int weight)>> inputAdjList = grphRepresent.AdjacencyList(n, k);

        ////Third Step, pass that graph into various method for traversal
        //Console.WriteLine("Breath First Traversal");
        //IGraphTraversal grphTraversal = new GraphTraversal();
        ////grphTraversal.BFS(inputAdjList);
        //grphTraversal.DFS(inputAdjList, 0);

        Solution s = new Solution();

        int[][] image = new int[][]
        {
            new int[] {1, 1, 1},
            new int[] {1, 1, 0},
            new int[] { 1, 0, 1 }
        };

        s.FloodFill(image, 1, 1, 2);



        Console.ReadKey();
    }
}