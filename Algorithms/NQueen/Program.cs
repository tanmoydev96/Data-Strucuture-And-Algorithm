using static System.Runtime.InteropServices.JavaScript.JSType;

public class Solution
{
    public void NQueenHelper(List<List<string>> matrix, IList<IList<string>> result, int col)
    {

        if (col == matrix.Count)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < matrix.Count; i++)
            {
                list.Add(string.Join("", matrix[i]));
            }
            result.Add(list);
            return;
        }

        for (int i = 0; i < matrix.Count; i++)
        {
            if (IsSafe(matrix, i, col))
            {
                matrix[i][col] = "Q";
                NQueenHelper(matrix, result, col + 1);
                matrix[i][col] = ".";
            }
        }
    }
    public bool IsSafe(List<List<string>> matrix, int row, int column)
    {
        for (int i = column; i >= 0; i--)
        {
            if (matrix[row][i] == "Q") return false;
        }
        int maxLeft = Math.Min(row, column);
        for (int i = 1; i <= maxLeft; i++)
        {
            if (matrix[row - i][column - i] == "Q") return false;
        }
        int downLeft = Math.Min(column, matrix.Count - row - 1);
        for (int i = 1; i <= downLeft; i++)
        {
            if (matrix[row + i][column - i] == "Q") return false;
        }
        return true;
    }

    public IList<IList<string>> SolveNQueens(int n)
    {
        List<List<string>> matrix = new List<List<string>>();
        IList<IList<string>> result = new List<IList<string>>();
        for (int i = 0; i < n; i++)
        {
            List<string> temp = new List<string>();
            for (int j = 0; j < n; j++)
            {
                temp.Add(".");
            }
            matrix.Add(temp);
        }
        NQueenHelper(matrix, result, 0);
        return result;
    }
}

class Result
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        foreach (var innerList in solution.SolveNQueens(4))
        {
            Console.WriteLine(string.Join(", ", innerList));
        }
    }
}