public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }
        
        Dictionary<char, int> charInS = new Dictionary<char, int>();
        
        foreach (char c in s) {
            if (charInS.ContainsKey(c)) {
                charInS[c]++;
            }
            else {
                charInS[c] = 1;
            }
        }

        foreach (char c in t) {
            if (!charInS.ContainsKey(c) || charInS[c] == 0) {
                return false;
            }
            charInS[c]--;
        }

        return true;
        
    }
}
