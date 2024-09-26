public class Solution {
    public bool IsHappy(int n) {
        var hash = new HashSet<int>();
        while (!hash.Contains(n)){
            if(n == 1)
                return true;
            hash.Add(n);
            n = Squarify(n);
        }
        return false;
    }

    private int Squarify(int n){
        var result = 0;
        while(n > 0){
            var digit = n % 10;
            result += digit * digit;
            n = n-digit;
            n = n / 10;
        }
        return result;
    }
}
