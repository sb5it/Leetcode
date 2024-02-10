public class Solution {
    public void Rotate(int[][] matrix) {
        int left = 0, right = matrix.Length - 1;

        while(left<right){
            for(int i = 0; i < right-left; i++){
                int top = left, bottom = right;
                int topLeft = matrix[top][left + i];
                matrix[top][left + i] = matrix[bottom - i][left];
                matrix[bottom - i][left] = matrix[bottom][right - i];
                matrix[bottom][right - i] = matrix[top + i][right];
                matrix[top + i][right] = topLeft;
            }
            
            left++;
            right--;
        }
    }
}
