public class Solution {
    public string SmallestFromLeaf(TreeNode root) {
        var paths = new List<string>();
        Traverse(root, "", paths);
        paths = paths.OrderBy(p => p).ToList();
        return paths.First();
    }

    private void Traverse(TreeNode node, string path, List<string> paths){
        if(node is null) return;

        path += ConvertNumberToLetter(node.val);
        if(node.left is null && node.right is null){
            paths.Add(new string(path.Reverse().ToArray()));
            return;
        }

        if (node.left is not null) Traverse(node.left, path, paths);
        if (node.right is not null) Traverse(node.right, path, paths);
    }

    private char ConvertNumberToLetter(int number) {
        return (char)('a' + number);
    }
}
