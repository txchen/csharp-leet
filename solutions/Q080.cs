public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int write = 0;
        int read = 0;
        int readStart = 0;
        while (read <= nums.Length)
        {
            if (read == nums.Length || nums[readStart] != nums[read])
            {
                if (read - readStart >= 2)
                {
                    nums[write] = nums[write + 1] = nums[readStart];
                    write += 2;
                }
                else if (read - readStart == 1)
                {
                    nums[write] = nums[readStart];
                    write++;
                }
                readStart = read;
            }
            read++;
        }
        return write;
    }
}
