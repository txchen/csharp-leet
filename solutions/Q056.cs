/**
 * Definition for an interval.
 * public class Interval {
 *     public int start;
 *     public int end;
 *     public Interval() { start = 0; end = 0; }
 *     public Interval(int s, int e) { start = s; end = e; }
 * }
 */
public class Solution {
    public IList<Interval> Merge(IList<Interval> intervals) {
        if (intervals.Count() == 0) {
            return new List<Interval>();
        }
        var answer = new List<Interval>();
        intervals = intervals.OrderBy(i => i.start).ToList();
        var tempInterval = intervals[0];
        for (int i = 1; i < intervals.Count(); i++)
        {
            if (intervals[i].start > tempInterval.end)
            {
                answer.Add(tempInterval);
                tempInterval = intervals[i];
            }
            else // merge
            {
                tempInterval = new Interval(Math.Min(intervals[i].start, tempInterval.start), Math.Max(intervals[i].end, tempInterval.end));
            }
        }
        answer.Add(tempInterval);
        return answer;
    }
}
