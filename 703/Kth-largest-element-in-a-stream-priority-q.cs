public class KthLargest {

    PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
    int k;

    public KthLargest(int k, int[] nums) {
        this.k = k;
        foreach(var n in nums){
            Add(n);
        }
        
    }
    
    public int Add(int val) {
        pq.Enqueue(val, val);
        while (pq.Count > k)
        {
            pq.Dequeue();
        }

        return pq.Peek();
    }
}
