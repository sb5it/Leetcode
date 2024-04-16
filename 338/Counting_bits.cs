public class Solution {
    public int[] CountBits(int n) {
        var result = new List<int>{ 0 };
        var offset = 1;

        for(int i = 1; i < n + 1; i++)
        {
            if(offset * 2 == i){
                offset = i;
            }
            result.Add(1 + result[i-offset]);
        }

        return result.ToArray();
    }
}
