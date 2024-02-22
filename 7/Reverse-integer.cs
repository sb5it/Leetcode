public class Solution {
    public int Reverse(int x) {
        if(x >= 0 && x < 10){
            return x;
        }
        bool isNegative = false;
        if(x < 0){
            isNegative = true;
            x = -1 * x;
        }
        var reversed = 0;
        while(x > 0){
            var lastDigit = x % 10;
            if (reversed > int.MaxValue / 10 || (reversed == int.MaxValue / 10 && lastDigit > 7))
                return 0;
        
            reversed = reversed * 10 + lastDigit;
            x = x - lastDigit;
            x = x / 10;
        }

        if(isNegative){
            reversed = reversed * -1;
        }

        return reversed;
    }
}
