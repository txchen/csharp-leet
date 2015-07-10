public class Solution {
    public void NextPermutation(int[] num) {
        int reverseStart = 0;
        int reverseEnd = num.Length - 1;
        for (int y = num.Length -1; y >= 1; y--)
        {
            if (num[y] > num[y - 1])
            {
                reverseStart = y;
                for (int x = num.Length - 1; x >= y; x--)
                {
                    if (num[x] > num[y - 1]) // swap
                    {
                        int tmp = num[x];
                        num[x] = num[y - 1];
                        num[y - 1] = tmp;
                        break;
                    }
                }
                break;
            }
        }
        while (reverseStart < reverseEnd)
        {
            int tmp = num[reverseStart];
            num[reverseStart] = num[reverseEnd];
            num[reverseEnd] = tmp;
            reverseStart++;
            reverseEnd--;
        }
    }
}
