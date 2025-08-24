class Solution
{
    // Complete this function
    public List<int> minPartition(int N)
    {
        // Your code here
        int temp = N;
        List<int> result = new List<int>();

        List<int> IndianCurrency = new List<int> { 1, 2, 5, 10, 20, 50, 100, 200, 500, 2000 }.OrderByDescending(x => x).ToList(); ;
        while (temp != 0)
        {
            foreach (var curr in IndianCurrency)
            {
                if (temp % curr != temp)
                {
                    int k = temp - curr;
                    result.Add(curr);
                    temp = k;
                    break;
                }
            }
        }
        return result;
    }
}

class Result
{
    public static void Main(String[] args)
    {
        Solution solution = new Solution();
        solution.minPartition(43);
    }
}