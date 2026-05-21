public class Solution {

    public string Encode(IList<string> strs) {
        string encoded = "";
        foreach (string str in strs) {
            encoded += str.Length + "#" + str;
        }
        return encoded;
    }

    public List<string> Decode(string s) {
        List<string> result = new List<string>();
        int i = 0;

        while (i < s.Length) {
            int j = i;
            while(s[j] != '#') {
                j++;
            }
            int length = int.Parse(s.Substring(i, j - i));
            string str = s.Substring(j + 1, length);
            result.Add(str);

            i = j + 1 + length;
        }

        return result;
   }
}
