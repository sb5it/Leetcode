public class Solution {
    public int MinimumMoves(int[][] grid) {
        var zeros = new List<(int,int)>();
        var extraStones = new List<(int,int, int)>();

        for(int i = 0; i < grid.Length; i++){
            for(int j = 0; j < grid.Length; j++){
                if(grid[i][j] == 0){
                    zeros.Add((i,j));
                }
                if(grid[i][j] > 1){
                    extraStones.Add((i, j, grid[i][j]-1));
                }
            }
        }

        var min = int.MaxValue;

        void BackTracking(int i, int steps){
            if(i == zeros.Count){
                min = Math.Min(min, steps);
                return;
            }

            for(int s = 0; s < extraStones.Count; s++){
                if(extraStones[s].Item3 > 0){
                    var temp = extraStones[s];
                    extraStones[s] = (extraStones[s].Item1, extraStones[s].Item2, extraStones[s].Item3 - 1);
                    BackTracking(i+1, steps + Dist(zeros[i].Item1, zeros[i].Item2, extraStones[s].Item1, extraStones[s].Item2));
                    extraStones[s] = temp;
                }
            }
        }

        BackTracking(0,0);
        return min;
    }

    private int Dist(int x1, int y1, int x2, int y2){
        return Math.Abs(x1-x2) + Math.Abs(y1 - y2);
    }
}
