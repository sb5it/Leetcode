public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var result = new int[temperatures.Length];
        Array.Fill(result, 0);
        var stack = new Stack<(int temp, int index)>();
        for(int i = 0; i < temperatures.Length; i++) {
            var curr = temperatures[i];
            while(stack.Any() && stack.Peek().temp < curr){
                var (temp, index) = stack.Pop();
                result[index] = i - index;
            }
            stack.Push((curr, i));
        }
        return result;
    }
}
