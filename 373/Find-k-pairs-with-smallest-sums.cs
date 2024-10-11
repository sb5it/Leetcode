public class Solution {
    public IList<IList<int>> KSmallestPairs(int[] nums1, int[] nums2, int k) {
        var result = new List<IList<int>>();
        var minHeap = new PriorityQueue<(int i, int j), int>();

        for (int i = 0; i < Math.Min(nums1.Length, k); i++) {
            minHeap.Enqueue((i, 0), nums1[i] + nums2[0]);
        }

        while (k > 0 && minHeap.Count > 0) {
            var (i, j) = minHeap.Dequeue();
            result.Add(new List<int> { nums1[i], nums2[j] });
            k--;

            if (j + 1 < nums2.Length) {
                minHeap.Enqueue((i, j + 1), nums1[i] + nums2[j + 1]);
            }
        }

        return result;
    }
}
