public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
        stack.Push(s[0]);
        for (int i = 1; i < s.Length; i++)
        {
            switch (s[i])
            {
                case '(':
                    stack.Push('(');
                    break;
                case ')':
                    if (stack.Count == 0 || stack.Pop() != '(')
                    {
                        return false;
                    }
                    break;
                case '[':
                    stack.Push('[');
                    break;
                case ']':
                    if (stack.Count == 0 || stack.Pop() != '[')
                    {
                        return false;
                    }
                    break;
                case '{':
                    stack.Push('{');
                    break;
                case '}':
                    if (stack.Count == 0 || stack.Pop() != '{')
                    {
                        return false;
                    }
                    break;
                default:
                    return false;
            }
        }
        return stack.Count == 0;
    }
}
