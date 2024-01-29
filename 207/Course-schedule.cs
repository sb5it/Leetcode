public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        var dict = new Dictionary<int, List<int>>();
        var visited = new HashSet<int>();
        foreach(var c in Enumerable.Range(0, numCourses))
            dict.Add(c, new List<int>());
        foreach(var p in prerequisites)
            dict[p.First()].AddRange(p.Skip(1).ToList());

        bool DFS(int crs){
            if (visited.Contains(crs)) return false;
            if (dict[crs].Count == 0) return true;
            visited.Add(crs);
            foreach (var c in dict[crs])
                if (!DFS(c)) return false;
            visited.Remove(crs);
            dict[crs].Clear();
            return true;
        }

        foreach(var c in Enumerable.Range(0, numCourses))
            if (!DFS(c)) return false;
        return true;
    }
}
