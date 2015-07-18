public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        if (k == 0) {
            return new int[0];
        }
        // maintain a LinkedList in c#, every step:
        // 1. remove one element from left(first)
        // 2. before add new element to right (last), pop all the elements from right and left that
        //    are smaller than the new one, because they have no chance to be biggest
        int[] answer = new int[nums.Length - k + 1];
        var list = new LinkedList<Tuple<int, int>>();
        for (int i = 0; i < nums.Length; i++) {
            if (list.Count > 0 && list.First.Value.Item2 == (i - k)) {
                list.RemoveFirst();
            }
            while (list.Count > 0 && list.Last.Value.Item1 < nums[i]) {
                list.RemoveLast();
            }
            while (list.Count > 0 && list.First.Value.Item1 < nums[i]) {
                list.RemoveFirst();
            }
            if (i - k + 1 >= 0) {
                if (list.Count == 0) {
                    answer[i - k + 1] = nums[i];
                } else {
                    answer[i - k + 1] = Math.Max(list.Last.Value.Item1, list.First.Value.Item1);
                }
            }
            list.AddLast(Tuple.Create(nums[i], i));
        }
        return answer;
    }
}
