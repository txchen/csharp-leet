public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stk = new Stack<int>();
        int p1, p2;
        foreach (string t in tokens) {
            switch (t) {
                case "+":
                    p2 = stk.Pop();
                    p1 = stk.Pop();
                    stk.Push(p1 + p2);
                    break;
                case "-":
                    p2 = stk.Pop();
                    p1 = stk.Pop();
                    stk.Push(p1 - p2);
                    break;
                case "*":
                    p2 = stk.Pop();
                    p1 = stk.Pop();
                    stk.Push(p1 * p2);
                    break;
                case "/":
                    p2 = stk.Pop();
                    p1 = stk.Pop();
                    stk.Push(p1 / p2);
                    break;
                default:
                    stk.Push(int.Parse(t));
                    break;
            }
        }
        return stk.Peek();
    }
}
