class Result {
    public bool WordBreakHelper(string source, List<string> collections, int pos)
    {
        for(int i = pos; i < source.Length; i++)
        {
            string substr = source.Substring(i);
            if(collections.Contains(substr))
            {

            }
        }
        return false;
    }
    public bool WordBreak(string source, List<string> collections)
    {
        return WordBreakHelper(source, collections, 0);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        Result result = new Result();
        string source = "catsanddog";
        List<string> lstElements = new List<string> { "cats", "dog", "sand", "play" };

        Console.WriteLine(result.WordBreak(source, lstElements));
    }

}