public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<string> seen = new HashSet<string>();

        for (int r = 0; r < 9; r++) {
            for (int c = 0; c < 9; c++) {
                char val = board[r][c];

                if (val == '.') {
                    continue;
                }

                string rowKey = "row " + r + " has " + val;
                string colKey = "col " + c + " has " + val;
                string boxKey = "box " + (r / 3) + "," + (c / 3) + " has " + val;

                if (seen.Contains(rowKey) || seen.Contains(colKey) || seen.Contains(boxKey)) {
                    return false;
                }

                seen.Add(rowKey);
                seen.Add(colKey);
                seen.Add(boxKey);
            }
        }
        return true;
    }
}
