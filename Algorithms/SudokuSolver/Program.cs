public class Solution
{
    public bool SodukuHelper(char[][] board)
    {
        //recursion
        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[0].Length; j++)
            {
                if (board[i][j] == '.')
                {
                    for (char k = '1'; k <= '9'; k++)
                    {
                        if (IsValid(i, j, k, board))
                        {
                            board[i][j] = k;
                            if (SodukuHelper(board)) return true;
                            board[i][j] = '.';
                        }
                    }
                    return false;
                }
            }
        }
        return true;
    }

    public bool IsValid(int i, int j, char k, char[][] board)
    {
        for (int row = 0; row < board.Length; row++)
        {
            if (board[row][j] == k) return false;
        }
        for (int col = 0; col < board[0].Length; col++)
        {
            if (board[i][col] == k) return false;
        }
        int blockRow = (i / 3) * 3;
        int blockCol = (j / 3) * 3;
        for (int m = blockRow; m < blockRow + 3; m++)
        {
            for (int n = blockCol; n < blockCol + 3; n++)
            {
                if (board[m][n] == k) return false;
            }
        }
        return true;

    }
    public void SolveSudoku(char[][] board)
    {
        SodukuHelper(board);
    }
}

public class Result { 
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        char[][] board = [
            ['5','3','.','.','7','.','.','.','.'],
            ['6','.','.','1','9','5','.','.','.'],
            ['.','9','8','.','.','.','.','6','.'],
            ['8','.','.','.','6','.','.','.','3'],
            ['4','.','.','8','.','3','.','.','1'],
            ['7','.','.','.','2','.','.','.','6'],
            ['.','6','.','.','.','.','2','8','.'],
            ['.','.','.','4','1','9','.','.','5'],
            ['.','.','.','.','8','.','.','7','9']
        ];
        solution.SolveSudoku(board);
    }
}
