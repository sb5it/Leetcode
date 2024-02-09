public class Solution {
    public void SetZeroes(int[][] matrix) {
        int Rows = matrix.Length, Cols = matrix[0].Length;
        var rowIndicator = new bool[Rows];
        var colIndicator = new bool[Cols];

        for (int r = 0; r < Rows; r++){
            for (int c = 0; c < Cols; c++){
                if (matrix[r][c] == 0){
                    rowIndicator[r] = true;
                    colIndicator[c] = true;
                }
            }
        }
        for (int r = 0; r < Rows; r++){
            for (int c = 0; c < Cols; c++){
                if (rowIndicator[r] || colIndicator[c]){
                    matrix[r][c] = 0;
                }
            }
        }
    }
}
