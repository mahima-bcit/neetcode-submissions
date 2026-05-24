public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> window = new HashSet<char>();
        int left = 0;
        int maxLen = 0;

        for (int right = 0; right < s.Length; right++) {
            while(window.Contains(s[right])){
                window.Remove(s[left]);
                left++;
            }
            window.Add(s[right]);
            maxLen = Math.Max(maxLen, right - left + 1);
        }

        return maxLen;
    }
}
