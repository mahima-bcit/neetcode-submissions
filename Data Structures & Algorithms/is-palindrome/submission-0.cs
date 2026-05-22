public class Solution {
    public bool IsPalindrome(string s) {
        string cleaned = "";

        foreach (char c in s) {
            if (char.IsLetterOrDigit(c)) {
                cleaned += char.ToLower(c);
            }
        }

        int left = 0;
        int right = cleaned.Length - 1;

        while (left < right) {
            if (cleaned[left] != cleaned[right]) {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}
