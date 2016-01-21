public class Solution
{
    public int AddDigits(int num)
    {
        int result = 0;
        while (num > 0)
        {
            result += num % 10;
            if (result >= 10)
            {
                result -= 9;
            }
            num = num / 10;
        }
        return result;
    }
}