public class Solution {
    public int RemoveElement(int[] a, int toRemove) {
        int writeIndex = 0;
        for (int readIndex = 0; readIndex < a.Length; readIndex++)
        {
            if (a[readIndex] != toRemove)
            {
                a[writeIndex++] = a[readIndex];
            }
        }
        return a.Take(writeIndex).ToArray().Length;
    }
}
