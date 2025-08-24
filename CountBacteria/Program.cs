using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.Write(Convert.ToString(n, 2).Count(x => x == '1'));
    }
}

