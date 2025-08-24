using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Numerics;


public struct Meetings
{
    public int start { get; set; }
    public int end { get; set; }
    public int pos { get; set; }
}

public class Result
{    
    public int MaxMeetings(List<int> start, List<int> end)
    {
        List<Meetings> answer = new List<Meetings>(); 
        int count = 0;
        var sortedmeetings = start.Select((s, it) => new Meetings { start = s, end = end[it], pos = it + 1 })
            .OrderBy(m=>m.end).ToList();
        int limit = sortedmeetings[0].end;
        answer.Add(sortedmeetings[0]);
        for(int i = 1; i < sortedmeetings.Count; i++)
        {
            if (sortedmeetings[i].start > limit)
            {
                limit = sortedmeetings[i].end;
                answer.Add(sortedmeetings[i]);
            }
            else
                count++;
        }
        return count;
    }      
}
public class Solution
{
    public static void Main(String[] args)
    {
        Result result = new Result();

        List<int> start = new List<int> { 1000, 935, 1100};
        List<int> end = new List<int> { 12400, 1240, 1130};

        //List<int> start = new List<int> { 900, 1235, 1100};
        //List<int> end = new List<int> { 1100, 1240, 1200};

        //List<int> start = new List<int> { 900, 940, 950, 1100, 1500, 1800 };
        //List<int> end = new List<int> { 910, 1200, 1120, 1130, 1900, 2000 };

        Console.WriteLine(result.MaxMeetings(start, end));
    }
}

