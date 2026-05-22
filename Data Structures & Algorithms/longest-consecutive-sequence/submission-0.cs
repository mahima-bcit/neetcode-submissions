public class Solution {
    public int LongestConsecutive(int[] nums) {
       HashSet<int> seen = new HashSet<int>();

       foreach(int num in nums) {
        seen.Add(num);
       }

       int longest = 0;

       foreach(int num in seen) {
        if (!seen.Contains(num - 1)) {
            int length = 1;
            int next = num + 1;

            while(seen.Contains(next)) {
                length++;
                next++;
            }

            if (length > longest) {
                longest = length;
            }
        }
       }
       return longest;
    }
}
