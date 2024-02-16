public class Solution {
    public int NumIslands(char[][] grid) {
        int Row = grid.Length, Col = grid[0].Length;
        var cnt = 0;
        for(int i = 0; i < Row; i++) {
            for (int j = 0; j < Col; j++) {
                if(grid[i][j] == '1'){
                    cnt++;
                    MarkIslandAsVisitedBfs(grid, i, j);
                }
            }
        }

        return cnt;
    }

    private void MarkIslandAsVisitedDfs(char[][] grid, int i, int j){
        if (i < 0 || j < 0) return;
        int Row = grid.Length, Col = grid[0].Length;
        if (i >= Row || j >= Col || grid[i][j] != '1') return;
        
        grid[i][j] = '2';
        MarkIslandAsVisitedDfs(grid, i + 1, j);
        MarkIslandAsVisitedDfs(grid, i - 1, j);
        MarkIslandAsVisitedDfs(grid, i, j + 1);
        MarkIslandAsVisitedDfs(grid, i, j - 1);
    }

    private void MarkIslandAsVisitedBfs(char[][] grid, int i, int j){
        int Row = grid.Length, Col = grid[0].Length;
        var q = new Queue<(int, int)>();
        q.Enqueue((i,j));
        while (q.Count > 0){
            var node = q.Dequeue();
            if (node.Item1 < 0 || node.Item2 < 0) continue;
            if (node.Item1 >= Row || node.Item2 >= Col || grid[node.Item1][node.Item2] != '1') continue;
            grid[node.Item1][node.Item2] = '2';
            q.Enqueue((node.Item1 + 1, node.Item2));
            q.Enqueue((node.Item1 - 1, node.Item2));
            q.Enqueue((node.Item1, node.Item2 + 1));
            q.Enqueue((node.Item1, node.Item2 - 1));
        }
    }
}
