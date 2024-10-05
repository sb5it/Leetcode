public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        int left = 0, right = nums.Length - 1, partitionIndex;
        while ((partitionIndex = Partition(nums, left, right)) != k - 1){
            if (partitionIndex < k - 1){
                left = partitionIndex + 1;
            }
            else {
                right = partitionIndex - 1;
            }
        }
        return nums[partitionIndex];
    }

    private int Partition(int[] nums, int left, int right)
    {
        int pivotIndex = left, pivot = nums[right];
        for (int i = left; i < right; i++)
            if (nums[i] > pivot){
                (nums[i], nums[pivotIndex]) = (nums[pivotIndex], nums[i]);
                pivotIndex++;
            }

        (nums[pivotIndex], nums[right]) = (nums[right], nums[pivotIndex]);
        return pivotIndex;
    }
}
