public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
        intervals = intervals.OrderBy(x => x[0]).ToArray();
        var res = 0;
        var previousEnd = intervals.First()[1];
        for(int i = 1; i < intervals.Length; i++) {
            var current = intervals[i];
            if (previousEnd > current[0]){
                res++;
                previousEnd = Math.Min(previousEnd, current[1]);
            } else {
                previousEnd = current[1];
            }
        }
        return res;
    }
}
