public class Solution {
    public IList<string> RestoreIpAddresses(string s) {
        return RestoreIpAddressesInt(s, 4);
    }

    private IList<string> RestoreIpAddressesInt(string s, int count)
    {
        if (s.Length > count * 3 || s.Length < count)
        {
            return new List<string>();
        }
        List<string> answer = new List<string>();
        // try take 1, 2, 3
        for (int j = 1; j <= 3; j++)
        {
            if (s.Length >= j)
            {
                var current = s.Substring(0, j);
                if (int.Parse(current) <= 255 && int.Parse(current).ToString() == current)
                {
                    if (s.Length > j)
                    {
                        var remainings = RestoreIpAddressesInt(s.Substring(j), count - 1);
                        remainings.ToList().ForEach(r => answer.Add(current + "." + r));
                    }
                    if (s.Length == j && count == 1)
                    {
                        answer.Add(current);
                    }
                }
            }
        }
        return answer;
    }

}
