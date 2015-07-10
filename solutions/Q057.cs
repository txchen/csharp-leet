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
    public IList<Interval> Insert(IList<Interval> intervals, Interval newInterval) {
        var answer = new List<Interval>();
        int mergedLow = newInterval.start;
        int mergedHigh = newInterval.end;
        for (int i = 0; i < intervals.Count(); i++)
        {
            // compare newInterval with currentInterval
            if (mergedHigh < intervals[i].start) // i.. are all larger than newInterval, no more merge
            {
                // write merged interval
                answer.Add(new Interval(mergedLow, mergedHigh));
                // write rest
                for (int j = i; j < intervals.Count(); j++)
                {
                    answer.Add(intervals[j]);
                }
                return answer;
            }
            else if (intervals[i].end < mergedLow)
            {
                answer.Add(intervals[i]);
            }
            else // has overlap
            {
                mergedLow = Math.Min(mergedLow, intervals[i].start);
                mergedHigh = Math.Max(mergedHigh, intervals[i].end);
            }
        }
        // merged has not been written yet;
        answer.Add(new Interval(mergedLow, mergedHigh));
        return answer;
    }
}
