public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int left = 0;
        int right = numbers.Length - 1;

        int sum = numbers[left] + numbers[right];
        while(sum != target) {
            if (sum > target) {
                right--;
            }
            if (sum < target) {
                left++;
            }
            sum = numbers[left] + numbers[right];
        }

        return new int[] {left + 1, right + 1};
    }
}
