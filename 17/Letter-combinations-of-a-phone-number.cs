public class Solution {
    public IList<string> LetterCombinations(string digits) {
        if(digits == ""){
            return [];
        }
        var dict = new Dictionary<char, string> {
            {'2',"abc"},
            {'3',"def"},
            {'4',"ghi"},
            {'5',"jkl"},
            {'6',"mno"},
            {'7',"pqrs"},
            {'8',"tuv"},
            {'9',"wxyz"},
        };
        var res = new List<string>();
        var arr = digits.ToCharArray();
        void Backtracking(int i, string result){
            if(result.Length == digits.Length){
                res.Add(result);
                return;
            }
            foreach(var c in dict[arr[i]]){
                Backtracking(i + 1, result + c);
            }
        }
        Backtracking(0, "");
        return res;
    }
}
