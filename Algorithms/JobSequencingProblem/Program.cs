using System.Reflection;

class Solution
{
    public struct JobModel
    {
        public int profits { get; set; }
        public int deadline { get; set; }
    }
    public List<int> JobSequencing(List<int> Profits, List<int> deadline)
    {
        int currentProfit = 0; int totalSum = 0;
        List<JobModel> sortedJobs = Profits.
        Select((p, it) => new JobModel { profits = p, deadline = deadline[it] }).OrderByDescending(m => m.profits).ToList();
        int MaxDeadlines = deadline.Max();

        List<int> result = Enumerable.Repeat(-1, MaxDeadlines).ToList();
        
        for(int i = 0; i < sortedJobs.Count; i++)
        {
            for (int j = sortedJobs[i].deadline-1; j >= 0; j--)
            {
                if (result[j] == -1)
                {
                    result[j] = i;
                    totalSum++;
                    currentProfit += sortedJobs[i].profits;
                    break;
                }
            }
        }

        return new List<int> { totalSum, currentProfit };
    }
}
class Result
{
    public static void Main(String[] args)
    {   
        List<int> Profits = new List<int> {20, 10, 40, 30};
        List<int> deadlines = new List<int> {4,1,1,1};
        Solution solution = new Solution();

        solution.JobSequencing(Profits, deadlines).ForEach(m => Console.WriteLine(m));
    }
}
