public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        var stack = new Stack<int>();
        foreach(var a in asteroids) {
            if (stack.Count == 0){
                stack.Push(a);
            } else {
                if (stack.Peek() < 0) {
                    stack.Push(a);
                } else if(a > 0){
                    stack.Push(a);
                } else {
                    var destroyed = false;
                    while (stack.Count > 0) {
                        if(stack.Peek() < 0) {
                            stack.Push(a);
                            break;
                        }
                        if(-a > stack.Peek())
                            stack.Pop();
                        else if(-a == stack.Peek()) {
                            stack.Pop();
                            destroyed = true;
                            break;
                        }
                        else
                            break;
                    }
                    if (stack.Count == 0 && !destroyed)
                        stack.Push(a);

                }
            }
        }
        return stack.Reverse().ToArray();
    }
}
