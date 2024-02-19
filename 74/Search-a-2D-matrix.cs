public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int Rows = matrix.Length, Cols = matrix[0].Length;

        int top = 0, bottom = Rows -1, row = - 1;

        while (top <= bottom){
            row = (top + bottom) / 2;
            if(target > matrix[row].Last()){
                top = row + 1;
            }else if(target < matrix[row][0]){
                bottom = row - 1;
             }else{
                break;
            }
        }

        if(top > bottom){
            return false;
        }
        int left = 0, right = Cols - 1;
        while(left <= right){
            var pivot = (left + right) / 2;
            if(target < matrix[row][pivot]){
                right = pivot - 1;
            } else if (target > matrix[row][pivot]){
                left = pivot + 1;
            } else{
                return true;
            }
        }

        return false;
    }
}
