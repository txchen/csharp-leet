class Solution {
    public int Candy(int[] ratings) {
        int[] candies = new int[ratings.Length];
        candies[0] = 1;
        for (int i = 1; i< ratings.Length; i++) {
            if (ratings[i] > ratings[i -1]) {
                candies[i] = candies[i -1] +1;
            } else {
                candies[i] = 1;
            }
        }
        for (int j = ratings.Length -2; j >= 0; j--) {
            if (ratings[j] > ratings[j+1]) {
                candies[j] = Math.Max(candies[j], candies[j+1] + 1);
            }
        }
        return candies.Sum(c => c);
    }
}
