public class Solution {
    public string SimplifyPath(string path) {
        var parts = path.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
        Stack<String> stk = new Stack<string>();
        foreach (var part in parts)
        {
            if (part == "..")
            {
                if (stk.Count > 0)
                {
                    stk.Pop();
                }
            }
            else if (part != ".")
            {
                stk.Push(part);
            }
        }
        return "/" + String.Join("/", stk.Select(s => s).Reverse());
    }
}
