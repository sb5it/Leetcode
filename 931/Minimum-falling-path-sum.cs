public class Solution {
    public int MinFallingPathSum(int[][] matrix) {
        var N = matrix.Length;
        for(int r = 1; r < N; r++) {
            for (int c = 0; c < N; c++) {
                var mid = matrix[r-1][c];
                var left = c - 1 >= 0 ? matrix[r-1][c-1] : int.MaxValue;
                var right = c + 1 < N ? matrix[r-1][c+1] : int.MaxValue;
                matrix[r][c] = matrix[r][c] + Math.Min(mid, Math.Min(left, right));
            }
        }
        Console.WriteLine(string.Join(",",matrix.Last()));
        return matrix.Last().Min();
    }
}
