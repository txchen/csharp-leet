public class Solution {
    public int Calculate(string s) {
        Stack<char> operStk = new Stack<char>();
        Stack<int> numStk = new Stack<int>();
        for (int i = 0; i < s.Length; i++) {
            var c = s[i];
            if (char.IsDigit(c)) {
                long currentNumber = 0;
                while (i < s.Length && char.IsDigit(s[i])) {
                    currentNumber = currentNumber * 10 + int.Parse(s[i].ToString());
                    i++;
                }
                numStk.Push((int)currentNumber);
                i--;
            } else if (c == '+' || c == '-') {
                while (operStk.Count > 0 && operStk.Peek() != '(') {
                    ProcessOper(numStk, operStk.Pop());
                }
                operStk.Push(c);
            } else if (c == '(') {
                operStk.Push(c);
            } else if (c == ')') {
                while (true) {
                    var op = operStk.Pop();
                    if (op == '(') {
                        break;
                    }
                    ProcessOper(numStk, op);
                }
            }
        }
        while (operStk.Count > 0) {
            ProcessOper(numStk, operStk.Pop());
        }
        return numStk.Pop();
    }

    private void ProcessOper(Stack<int> numStk, char oper) {
        int num2 = numStk.Pop();
        int num1 = numStk.Pop();
        switch (oper) {
            case '+':
                numStk.Push(num1 + num2);
                break;
            case '-':
            default:
                numStk.Push(num1 - num2);
                break;
        }
    }
}
