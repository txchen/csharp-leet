public class Solution {
    public int LongestValidParentheses(string s) {
        int answer = 0;
        Stack<int> stk = new Stack<int>();
        stk.Push(-1);
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
            {
                stk.Push(i);
            }
            else // ')'
            {
                if (stk.Peek() != -1 && s[stk.Peek()] == '(') {
                    stk.Pop();
                    answer = Math.Max(answer, i - stk.Peek());
                }
                else
                {
                    stk.Push(i);
                }
            }
        }
        return answer;
    }
}
