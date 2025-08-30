public class Solution
{
    public void RatInAMaze(int i, int j, List<List<int>> matrix, List<List<int>> visited, string move, List<string> ans)
    {
        if (i == matrix.Count - 1 && j == matrix[0].Count - 1)
        {
            ans.Add(move);
            return;
        }
        //downward
        if(i+1 < matrix.Count && visited[i + 1][j] == 0 && matrix[i + 1][j] == 1)
        {
            visited[i + 1][j] = 1;
            RatInAMaze(i+1, j, matrix, visited, move + "D", ans);
            visited[i + 1][j] = 0;
        }

        //upward
        if(i-1>= 0 && visited[i-1][j] == 0 && matrix[i-1][j] == 1)
        {
            visited[i-1][j] = 1;
            RatInAMaze(i-1, j, matrix, visited, move + "U", ans);
            visited[i-1][j] = 0;
        }

        //left
        if(j - 1 >= 0 && visited[i][j-1] == 0 && matrix[i][j-1] == 1)
        {
            visited[i][j-1] = 1;
            RatInAMaze(i, j - 1, matrix, visited, move + "L", ans);
            visited[i][j - 1] = 0;
        }

        //right
        if(j+1 < matrix.Count && visited[i][j+1] == 0 && matrix[i][j+1] == 1)
        {
            visited[i][j + 1] = 1;
            RatInAMaze(i, j+1, matrix, visited, move + "R", ans);
            visited[i][j + 1] = 0;
        }

    }
}

public class Result
{
    public static void Main(string[] args)
    {
        //0 -- Block | 1 -- Free Cell
        List<List<int>> matrix = new List<List<int>>()
        {
            new List<int>(){1,0,0,0},
            new List<int>(){1,1,0,1},
            new List<int>(){1,1,0,0},
            new List<int>(){0,1,1,1},
        };

        List<List<int>> visited = Enumerable.Range(0,4).Select(r => Enumerable.Repeat(0 , 4).ToList()).ToList();

        Solution s = new Solution();
        List<string> result = new List<string>();
        s.RatInAMaze(0 , 0 , matrix, visited, "", result);
    }
}
