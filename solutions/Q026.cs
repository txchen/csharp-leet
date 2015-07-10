public class Solution {
    public int RemoveDuplicates(int[] a) {
        if (a.Length == 0)
        {
            return 0;
        }
        int writeIndex = 0;
        for (int readIndex = 1; readIndex < a.Length; )
        {
            if (a[readIndex] != a[writeIndex])
            {
                writeIndex++;
                a[writeIndex] = a[readIndex];
                while (readIndex < a.Length && a[readIndex] == a[writeIndex])
                {
                    readIndex++;
                }
            }
            else
            {
                readIndex++;
            }
        }
        return a.Take(writeIndex + 1).ToArray().Length;
    }
}
