public class Solution {
    public int[] MissingRolls(int[] rolls, int mean, int n) {
        var numberOfObs = n + rolls.Length;

        var targetSum = (mean * numberOfObs) - rolls.Sum();
        if(targetSum / (double)n > 6 || targetSum / (double)n < 1){
            return new int []{};
        }

        if(n == 1){
            return new int []{ targetSum };
        }
        
        var averageValue = targetSum / n;
        var mod = targetSum % n;
        var result = Enumerable.Repeat(averageValue, n).ToArray();
        for(int i = 0; i < result.Length && mod != 0; i++){
            result[i]+= 1;
            mod-=1;
        }

        return result;
    }
}
