public class Solution {
    public int MinMeetingRooms(int[][] intervals) {
        var prioQ = new PriorityQueue<int[], int>();
        var maxLength = 1;
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        for (int i = 0; i < intervals.Length; i++)
        {
            if(prioQ.Count == 0 || intervals[i][0] < prioQ.Peek()[1])
            {
                prioQ.Enqueue(intervals[i], intervals[i][1]);
            }
            else 
            {
                while (prioQ.Count > 0 && intervals[i][0] >= prioQ.Peek()[1])
                {
                    prioQ.Dequeue();
                }
                prioQ.Enqueue(intervals[i], intervals[i][1]);
            }
            
            maxLength = Math.Max(maxLength, prioQ.Count);
        }
        return maxLength;
    }
}
