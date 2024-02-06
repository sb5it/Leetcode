ublic class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        var result = new List<IList<int>>();
        void dfs(int i, List<int> current, int total){
            if(total == target){
                var append = new List<int>();
                append.AddRange(current);
                result.Add(append);
                return;
            }

            if(i >= candidates.Length || total > target){
                return;
            }

            current.Add(candidates[i]);
            dfs(i, current, total+candidates[i]);
            current.RemoveAt(current.Count - 1);
            dfs(i + 1, current, total);
        }

        dfs(0, new List<int>(), 0);
        return result;
    }
}
