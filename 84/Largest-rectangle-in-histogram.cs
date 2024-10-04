public class Solution {
    public int LargestRectangleArea(int[] heights) {
        var maxArea = 0;
        var stack = new Stack<(int Index, int Height)>(); //index, height

        for(int i = 0; i < heights.Length; i++) {
            var curr = heights[i];
            var start = i;
            while(stack.Any() && stack.Peek().Height > curr){
                var (index, height) = stack.Pop();
                maxArea = Math.Max(maxArea, height * (i - index));
                start = index;
            }
            stack.Push((start, curr));
        }

        foreach(var item in stack){
            maxArea = Math.Max(maxArea, item.Item2 * (heights.Length - item.Item1));
        }

        return maxArea;
    }
}
