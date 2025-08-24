using System;
using System.Linq;
public class Program
{
    public static void Main(string[] args)
    {
        int totalpeoples = int.Parse(Console.ReadLine()) * 2;
        List<List<int>> peopleWithStrength = new List<List<int>>();

        for (int i = 0; i < totalpeoples - 1; i++)
        {
            List<int> tempdata = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            peopleWithStrength.Add(tempdata);
        }
    }
}