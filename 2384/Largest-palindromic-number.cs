public class Solution {
    public string LargestPalindromic(string num) {
        var numsCounter = new int[10];
        var sb = new StringBuilder();

        foreach(var c in num){
            int n = c - '0';
            numsCounter[n]++;
        }

        var largestOdd = -1;
        for(var i = 0; i < numsCounter.Length; i++){
            
            if(numsCounter[i] % 2 != 0){
                largestOdd = i;
            }
        }
        
        if(largestOdd >= 0){
            sb.Append(largestOdd);
            numsCounter[largestOdd]--;
        }

        for(var i = 0; i < numsCounter.Length; i++){
            if(numsCounter[i] >= 2){
                while(numsCounter[i] > 1){
                    sb.Insert(0, i);
                    sb.Append(i);
                    numsCounter[i] = numsCounter[i] - 2;
                }
            }
        }

        var result = sb.ToString();
        var trimmed = result.Trim('0');


        return trimmed.Length == 0 ? "0" : trimmed;
    }
}
