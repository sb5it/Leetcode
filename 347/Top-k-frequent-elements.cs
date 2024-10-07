public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var freq = new Dictionary<int, int>();
        foreach(var n in nums)
            freq[n] = freq.TryGetValue(n, out int value) ? value + 1 : 1;
        var priorityQueue = new PriorityQueue<int, int>();
        foreach(var n in freq){
            priorityQueue.Enqueue(n.Key, n.Value);
            if(priorityQueue.Count > k)
                priorityQueue.Dequeue();
        }
        
        return priorityQueue.UnorderedItems.Select(item => item.Element).ToArray();
    }
}
