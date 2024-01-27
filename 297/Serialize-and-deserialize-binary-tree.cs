public class Codec {
    List<string> _nodeList = new List<string>();
    int pointer = 0;
    // Encodes a tree to a single string.
    public string serialize(TreeNode root) {
        SerializeTraverseDfs(root);
        return string.Join(",", _nodeList);
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data) {
        _nodeList = data.Split(',').ToList();
        return DeSerializeTraverseDfs();
    }

    private TreeNode DeSerializeTraverseDfs(){
        Console.WriteLine(_nodeList[pointer]);
        if(_nodeList[pointer] == "N"){
            pointer++;
            return null;
        }
        var root = new TreeNode(Convert.ToInt32(_nodeList[pointer]));
        pointer++;
        root.left = DeSerializeTraverseDfs();
        root.right = DeSerializeTraverseDfs();
        return root;
    }

    private void SerializeTraverseDfs(TreeNode node){
        if (node is null){
            _nodeList.Add("N");
            return;
        }
        _nodeList.Add(node.val.ToString());
        SerializeTraverseDfs(node.left);
        SerializeTraverseDfs(node.right);
    }
}
