public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int i = m+n-1;
        var lastNum1 = m-1;
        var lastNum2 = n-1;

        while(lastNum2>= 0){
            if(lastNum1 >= 0 && nums1[lastNum1] > nums2[lastNum2]){
                nums1[i--] = nums1[lastNum1--];
            }else{
                nums1[i--] = nums2[lastNum2--];
            }
        }
    }
}
