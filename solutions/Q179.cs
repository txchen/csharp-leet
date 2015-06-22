public class Solution{
    public string LargestNumber(int[] num)
    {
        Array.Sort(num,CompareNum);
        if (num[0] == 0) {
            return "0";
        }
        return String.Concat(num);
    }

    private static int CompareNum(int a, int b)
    {
        string sa = b.ToString();
        string sb = a.ToString();
        return (sa + sb).CompareTo(sb + sa);
    }
}
