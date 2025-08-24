using System.Reflection;

struct Solution
{
    public struct ItemsInfo
    {
        public int weights { get; set; }
        public int values { get; set; }
    }
    public double FractionalKnapsack(List<int> weights, List<int> values, int capacity)
    {
        List<ItemsInfo> SortedInWeight = weights.Select((wt, i) => new 
                        ItemsInfo { weights = wt, values = values[i] }).OrderByDescending(m => (double)m.values/(double)m.weights).ToList();
        
        int remainingCapacity = capacity; double totalprofits = 0.0;
        for (int i = 0; i < SortedInWeight.Count; i++)
        {
            if(remainingCapacity >= SortedInWeight[i].weights)
            {
                totalprofits += SortedInWeight[i].values;
                remainingCapacity = remainingCapacity - SortedInWeight[i].weights;
            }
            else
            {
                double temp = (double)SortedInWeight[i].values / SortedInWeight[i].weights * remainingCapacity;
                totalprofits += temp;
                break; // as knapsack is already full.
            }           
        }
        return totalprofits;
    }
}

class Result
{
    public static void Main(String[] args)
    {
        var testCases = new List<(List<int> values, List<int> weights, int capacity, double expected)>
        {
            // Test 1 - Classic example
            (new List<int> {60, 100, 120}, new List<int> {10, 20, 30}, 50, 240.0),

            // Test 2 - Different order to check sorting by ratio
            (new List<int> {100, 60, 120}, new List<int> {10, 20, 30}, 50, 250.0),

            // Test 3 - High value small weight
            (new List<int> {500, 100, 200}, new List<int> {5, 20, 30}, 40, 780.0),

            // Test 4 - All weights > capacity (should take best ratio fraction)
            (new List<int> {60, 100, 120}, new List<int> {20, 40, 60}, 10, 30.0),

            // Test 5 - Exact fit
            (new List<int> {40, 50, 100}, new List<int> {10, 20, 30}, 60, 190.0)
        };

        Solution solution = new Solution();

        int testNum = 1;
        foreach (var (values, weights, capacity, expected) in testCases)
        {
            double result = solution.FractionalKnapsack(weights, values, capacity);
            Console.WriteLine($"Test {testNum}: Result = {result}, Expected = {expected}, Pass = {Math.Abs(result - expected) < 1e-6}");
            testNum++;
        }
    }
}