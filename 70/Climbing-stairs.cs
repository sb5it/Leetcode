public class Solution {
    public int ClimbStairs(int n) {
        if(n == 0 || n == 1){
            return 1;
        }
        if(n == 2){
            return 2;
        }
        int one = 1, two = 1;
        //n < 2
        var count = 0;
        for(int i = 2; i <= n; i++){
            count = one + two;
            one = two;
            two = count;
        }

        return count;
    }
}
