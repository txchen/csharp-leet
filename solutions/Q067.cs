public class Solution {
    public string AddBinary(string a, string b) {
        char[] answer = new char[a.Length + b.Length];
        for (int i = 0; i < answer.Length; i++)
        {
            answer[i] = '0';
        }
        for (int i = a.Length - 1; i >= 0 ; i--)
		{
            answer[b.Length + i] = a[i];
		}
        for (int j = b.Length - 1; j >= 0; j--)
        {
            int carry = b[j] == '1' ? 1 : 0;
            int currentIndex = j + a.Length;
            while (carry == 1)
            {
                if (answer[currentIndex] == '1')
                {
                    answer[currentIndex--] = '0';
                }
                else
                {
                    answer[currentIndex--] = '1';
                    carry = 0;
                }
            }
        }
        string res = new string(answer).TrimStart('0');
        if (String.IsNullOrEmpty(res))
        {
            return "0";
        }
        return res;
    }
}
