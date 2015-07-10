public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        // now start working, a[] has empty slot in the end, so start from end
        int i = m + n - 1;
        int ia = m - 1;
        int ib = n - 1;
        while (i >= 0)
        {
            if (ib < 0)
            {
                nums1[i--] = nums1[ia--];
                continue;
            }
            if (ia < 0)
            {
                nums1[i--] = nums2[ib--];
                continue;
            }
            if (nums1[ia] > nums2[ib])
            {
                nums1[i--] = nums1[ia--];
            }
            else
            {
                nums1[i--] = nums2[ib--];
            }
        }
    }
}
