public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        var valueToIndex = nums1.Select((value, index) => new { value, index })
                .ToDictionary(x => x.value, x => x.index);
        var unsetValues = new Stack<int>();
        var result = new int[nums1.Length];
        Array.Fill(result, -1);
        for(int i = 0; i < nums2.Length; i++){
            var current = nums2[i];
            while(unsetValues.Any() && current > unsetValues.Peek()){
                var value = unsetValues.Pop();
                var idx = valueToIndex[value];
                result[idx] = current;
            }
            if(valueToIndex.ContainsKey(current))
                unsetValues.Push(current);
        }

        return result;
    }
}
