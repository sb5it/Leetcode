public class Solution {
    public int[][] Merge(int[][] intervals) {
        intervals = intervals.OrderBy(x => x[0]).ToArray();
        var output = new List<int[]> { new int[] { intervals[0][0], intervals[0][1] } };
        for (int i = 1; i < intervals.Length; i++) {
            var previous = output.Last();
            var current = intervals[i];
            if (current[0] <= previous[1]) {
                previous[1] = Math.Max(current[1], previous[1]);
            }
            else {
                output.Add(current);
            }
        }

        return output.ToArray();
    }
}
