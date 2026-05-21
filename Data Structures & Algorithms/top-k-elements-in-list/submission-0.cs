public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> countNums = new Dictionary<int, int>();

        foreach (int num in nums) {
            if (countNums.ContainsKey(num)) {
                countNums[num]++;
            } else {
                countNums[num] = 1;
            }
        }

        return countNums.Keys.OrderByDescending(num => countNums[num]).Take(k).ToArray();
    }
}
