public class Solution {
    public int MinMeetingRooms(int[][] intervals) {
        var starts = intervals.Select(i => i[0]).OrderBy(x => x).ToArray();
        var ends = intervals.Select(i => i[1]).OrderBy(x => x).ToArray();
        int result = 0, count = 0;
        int s = 0, e = 0;
        while(s < intervals.Length){
            if(starts[s] < ends[e]){
                s++;
                count++;
            } else {
                e++;
                count--;
            }
            result = Math.Max(result, count);
        }
        return result;
    }
}
