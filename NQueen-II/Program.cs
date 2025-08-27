public class Solution
{
    public void NQueenHelper(List<List<string>> matrix, ref int TotalCount, int column)
    {
        if (column == matrix.Count)
        {
            TotalCount++;
            return;
        }

        for (int i = 0; i < matrix.Count; i++)
        {
            if (IsSafe(matrix, i, column))
            {
                matrix[i][column] = "Q";
                NQueenHelper(matrix, ref TotalCount, column + 1);
                matrix[i][column] = ".";
            }
        }
    }
    public bool IsSafe(List<List<string>> matrix, int row, int column)
    {
        for (int i = column; i >= 0; i--)
        {
            if (matrix[row][i] == "Q") return false;
        }
        int UpperLeft = Math.Min(row, column);
        for (int i = 1; i <= UpperLeft; i++)
        {
            if (matrix[row - i][column - i] == "Q") return false;
        }
        int DownRight = Math.Min(column, matrix.Count - row - 1);
        for (int i = 1; i <= DownRight; i++)
        {
            if (matrix[row + i][column - i] == "Q") return false;
        }
        return true;
    }
    public int TotalNQueens(int n)
    {
        List<List<string>> matrix = new List<List<string>>();
        for (int i = 0; i < n; i++)
        {
            List<string> temp = new List<string>();
            for (int j = 0; j < n; j++)
            {
                temp.Add(".");
            }
            matrix.Add(temp);
        }
        int TotalCount = 0;
        NQueenHelper(matrix, ref TotalCount, 0);
        return TotalCount;
    }
}

public class Result
{
   public static void Main(string[] args)
   {
        Solution solution = new Solution();
        Console.WriteLine(solution.TotalNQueens(4));
   }
}