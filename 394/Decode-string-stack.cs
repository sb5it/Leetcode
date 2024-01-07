public class Solution {
    public string DecodeString(string s) {
        var stack = new Stack<string>();
        var repeat = 0;
        var currentString = new StringBuilder();
        foreach(var c in s){
            if(c == '['){
                stack.Push(currentString.ToString());
                stack.Push(repeat.ToString());
                currentString = currentString.Clear();
                repeat = 0;
            }  else if(c == ']'){
                var num = Convert.ToInt32(stack.Pop());
                var prevString = stack.Pop();
                var temp = new StringBuilder();
                for(int i = 1; i <= num; i++){
                    temp.Append(currentString.ToString());
                }
                currentString.Clear();
                currentString.Append(prevString);
                currentString.Append(temp.ToString());
            }
            else if(char.IsDigit(c)){
                repeat = repeat*10 + (int)(c -'0');
            } 
            else {
                currentString.Append(c);
            }
        }
        return currentString.ToString();
    }
}
